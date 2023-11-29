using System;
using System.IO;
using System.Linq;

namespace AssignmentStudentData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\shiva\\OneDrive\\Desktop\\File.txt.txt";
            Console.WriteLine(" Enter\n 1.Sorting the data by student's name \n 2.Searching by name ");
            int num = int.Parse(Console.ReadLine());
            string[] str = File.ReadAllLines(filePath);




            try
            {
                if (num == 1)
                {
                    Console.WriteLine("Rainbow School Student Details");
                    Console.WriteLine("Name \t Class\t Address \t");
                    Array.Sort(str);
                    for (int i = 0; i < str.Length; i++)
                    {
                        Console.WriteLine(str[i]);
                    }

                }
                else if (num == 2)
                {

                    Console.WriteLine("Enter the name for Searching");
                    string nameToSearch = Console.ReadLine().Trim(); 

                    bool found = false;

                    for (int i = 0; i < str.Length; i++)
                    {
                      
                        

                      
                        if (str[i].Contains(nameToSearch))
                        {
                            Console.WriteLine("Details as follows:\n" + str[i]);
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Student not found with the name: " + nameToSearch);
                    }
                }
            }



            catch (Exception ex)
            {
                Console.WriteLine("Error Occured" + ex.Message);
            }

            finally
            {
                Console.WriteLine("Program ends here");
            }
            Console.ReadKey();
        }

    }
}
