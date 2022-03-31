using System;
using Task.Models;
namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte choise;
            Group group = new Group("AP205", 5);
            User user1 = new User(StringInput("Email"), StringInput("Password"));
            User user2 = new User("FullName", "Email", "Passwo1rd");
            do
            {
            SetChoisePoint:
                try
                {
                    Console.Write("1)Show Info\n2)Create new group\nChoise:");
                    choise = Convert.ToSByte(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto SetChoisePoint;
                }

                switch (choise)
                {
                    case 0: break;
                    case 1:
                        user1.ShowInfo();
                        user2.ShowInfo();
                        break;
                    case 2:
                        do
                        {
                            try
                            {
                                Console.Write("1)Show all students\n2)Get student by id\n3)Add student\n0)Quit\nChoise:");
                                choise = Convert.ToSByte(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto SetChoisePoint1;
                            }
                            switch (choise)
                            {
                                case 0: break;
                                case 1:
                                    foreach (var student in group.GetAllStudents())
                                    {
                                        Console.WriteLine(student);
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine(group.GetStudent(1));
                                    break;
                                case 3:
                                    AddStudentPoint:
                                    try
                                    {
                                    group.AddStudent(new Student(StringInput("FullName"), PointInput()));
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
                    SetChoisePoint1:

                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }

            } while (choise != 0);

        }
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
        static double PointInput()
        {
            double temp;
            do
            {
            DoubleInput:
                try
                {
                    Console.Write("Point:");
                    temp = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto DoubleInput;
                }
            } while (temp>100||temp<0);
            return temp;
        }

        static int LimitInput()
        {
            int temp;
            do
            {
            IntInput:
                try
                {
                    Console.Write("Limit:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto IntInput;
                }
            } while (temp >= 5 || temp <= 18);
       
            return temp;
        }
    }
}
