using System;
using System.Collections.Generic;
using System.Collections;

namespace Assessment
{
    class RainbowSchool
    {
        public static List<string> TeachersList = new List<string> { "1", "Mr.Baviskar", "1/A", "2", "Mrs.Singh", "2/B", "3", "Mr.Shimpi", "3/C", "4", "Mr.Rajput", "4/D"};
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\nWELCOME TO RAINBOW SCHOOL STAFF LIST.");
                Console.WriteLine("\nHere you can View, Add, Update And Delete Teachers Data.");
                Console.WriteLine("\nEnter the number for following actions. \n\n1.View Data\n2.Add Data\n3.Update Data\n4.Delete Data");
                int key;
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        {
                            ViewData();
                            break;
                        }

                    case 2:
                        {
                            AddData();
                            break;
                        }

                    case 3:
                        {
                            UpdateData();
                            break;
                        }

                    case 4:
                        {
                            DeleteData();
                            break;
                        }
                }
                if (key > 4 || key < 0)
                {
                    Console.WriteLine("\nInvalid Key..");
                }
                Console.Write("\n\nTo continue press 0.. ");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice == 0 );
        }
        public static void ViewData()
        {
            int size = TeachersList.Count;
            Console.WriteLine("ID\tTeacher Name\tSection");
            for (int i = 0; i < TeachersList.Count; i += 3)
            {
                Console.Write(TeachersList[i] + "\t" + TeachersList[i + 1] + "\t" + TeachersList[i + 2] + "\n");
            }
        }
        public static void AddData()
        {
            Console.WriteLine("\nEnter New Teacher ID : ");
            string s = Console.ReadLine();
            TeachersList.Add(s);
            Console.WriteLine("\nEnter New Teacher Name : ");
            s = Console.ReadLine();
            TeachersList.Add(s);
            Console.WriteLine("\nEnter New Teacher Class and Section : ");
            s = Console.ReadLine();
            TeachersList.Add(s);
        }

        public static void UpdateData()
        {
            int size1 = TeachersList.Count;
            Console.WriteLine("\nEnter Teacher name you want to update..");
            string Name = Console.ReadLine();
            bool flag = false;
            for (int i = 1; i < size1; i += 3)
            {
                if (Name == TeachersList[i])
                {
                    Console.WriteLine("\nEnter new name..");
                    string p = Console.ReadLine();
                    TeachersList[i] = p;
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("\nName doesnt exist, please check and try again..");
            }
        }
        public static void DeleteData()
        {
            Console.WriteLine("\nEnter the name you want to delete");
            string s = Console.ReadLine();
            bool flag = false;
            for (int i = 0; i < TeachersList.Count; i += 3)
            {
                if (TeachersList[i + 1] == s)
                {
                    TeachersList.RemoveAt(i);
                    TeachersList.RemoveAt(i);
                    TeachersList.RemoveAt(i);
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("\nName Doesnt Exist ,please Try Again.");
            }
        } 
    }
}