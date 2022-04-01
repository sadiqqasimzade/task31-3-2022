using System;
using Task.Models;
using Task.Custom_Exceptions;
namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte choise;
            do
            {
                ChoiseInput("-----------------------\n1)Create 2 users and Show Info\n2)Create new group\nChoise:", out choise);
                switch (choise)
                {
                    case 0: break;

                    case 1:
                        UserTask();
                        break;

                    case 2:
                        CreateGroup(out Group group);
                        do
                        {
                            ChoiseInput("-----------------------\n1)Show all students\n2)Get student by id\n3)Add student\n0)Quit\nChoise:", out choise);
                            switch (choise)
                            {
                                case 0: break;
                                case 1:
                                    foreach (var student in group.GetAllStudents())
                                        Console.WriteLine(student);
                                    break;
                                case 2:
                                    IdInput(out short id);
                                    try
                                    {
                                        Console.WriteLine(group.GetStudent(id));
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                    break;
                                case 3:
                                AddStudentPoint:
                                    try
                                    {
                                        group.AddStudent(new Student(StringInput("FullName"), PointInput()));
                                    }
                                    catch (NoSpaceAvailable ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        goto AddStudentPoint;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Wrong Input");
                                    break;
                            }
                        } while (choise != 0);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            } while (choise != 0);
        }

        //StringInput
        static string StringInput(string str)
        {
            string temp;
            do
            {
                Console.Write(str + ":");
                temp = Console.ReadLine();
            } while (String.IsNullOrEmpty(temp) && String.IsNullOrWhiteSpace(temp));

            return temp;
        }

        //PointInput
        static double PointInput()
        {
            double temp;
        DoubleInput:
            try
            {
                Console.Write("Point:");
                temp = Convert.ToDouble(Console.ReadLine());
                if (temp > 100 || temp < 0) throw new Exception("Point must be between 0-100 ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto DoubleInput;
            }
            return temp;
        }

        //LimitInput
        static int LimitInput()
        {
            int limit;
        IntInput:
            try
            {
                Console.Write("Limit:");
                limit = Convert.ToInt32(Console.ReadLine());
                if (limit < 5 || limit > 18) throw new Exception("Limit must be between 5-18");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto IntInput;
            }
            return limit;
        }

        //UserTask
        static void UserTask()
        {
            User user1, user2;
        User1Point:
            try
            {
                Console.WriteLine("User 1:");
                user1 = new User(StringInput("Email"), PasswordInput());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto User1Point;
            }
        User2Point:
            try
            {
                Console.WriteLine("User 2:");
                user2 = new User(StringInput("FullName"), StringInput("Email"), PasswordInput());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto User2Point;
            }

            user1.ShowInfo();
            user2.ShowInfo();
        }

        //CreateGroup
        static void CreateGroup(out Group group)
        {
        CreateGroupPoint:
            try
            {
                group = new Group(GroupNoInput(), LimitInput());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto CreateGroupPoint;
            }
        }

        //ChoiseInput
        static void ChoiseInput(string str, out sbyte choise)
        {
        SetChoisePoint:
            try
            {
                Console.Write(str);
                choise = Convert.ToSByte(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto SetChoisePoint;
            }
        }

        //IdInput
        static void IdInput(out short id)
        {
            do
            {
            SetIdPoint:
                try
                {
                    Console.Write("Id:");
                    id = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto SetIdPoint;
                }
            } while (id < 0);
        }

        static string PasswordInput()
        {
            string password;
            while (true)
            {
                Console.Write("Password:");
                password = Console.ReadLine();
                if (!String.IsNullOrEmpty(password) || !String.IsNullOrWhiteSpace(password) || password.Length >= 8)
                {
                    bool isDigit = false;
                    bool isUpper = false;
                    bool isLower = false;
                    foreach (var letter in password)
                    {
                        if (char.IsDigit(letter)) isDigit = true;
                        else if (char.IsUpper(letter)) isUpper = true;
                        else if (char.IsLower(letter)) isLower = true;

                        if (isDigit && isLower && isUpper) return password;
                    }
                }
            }
        }

        static string GroupNoInput()
        {
            string groupNo;
            while (true)
            {
                Console.Write("Group no:");
                groupNo = Console.ReadLine();
                if (!String.IsNullOrEmpty(groupNo) && !String.IsNullOrWhiteSpace(groupNo) && groupNo.Length == 5)
                {
                    int upperCounter = 0;
                    int digitCounter = 0;
                    for (int i = 0; i < 2; i++)
                        if (char.IsUpper(groupNo[i])) upperCounter++;

                    if (upperCounter == 2)
                    {
                        for (int i = 2; i < 5; i++)
                            if (char.IsDigit(groupNo[i]))
                                digitCounter++;
                    }
                    else continue;
                    if (digitCounter == 3) return groupNo;
                }
            }
        }

    }
}
