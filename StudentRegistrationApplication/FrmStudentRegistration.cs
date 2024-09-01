using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApplication
{
    internal class FrmStudentRegistration
    {
        static void Main(string[] args)
        {
            while (true)//doing a looping so that it will run continuously
            {
                //output design
                Console.WriteLine(DateTime.Now.ToString("\t\t\t MM/dd/yy"));
                Console.WriteLine("================ STUDENT REGISTRATION ==================");
                Console.WriteLine("  ================   STI COLLEGE   ==================");
                // input that show if they want to enroll 
                Console.Write("Do you want to enroll? (type Y for yes or N for no): ");
                string InputEnroll = Console.ReadLine().ToUpper();// it uppercase the input for easy identifying
                if (InputEnroll == "Y")// decision statement for input enroll if they want or not 
                {
                    Console.Write("Do you have money about 32 thousands above? (type Y for yes or N for no): ");
                    string InputMoney = Console.ReadLine().ToUpper(); ;// it uppercase the input for easy identifying
                    if (InputMoney == "Y")// another decision statement for requirements about money
                    {
                        Console.Write("Do you have the following requirement files:\nSHS Diploma, \nForm137, \nGood moral, \nPSA, \nGrades, \nMed Certificate files?\n(type Y for yes or N for no): ");
                        string InputRequirements = Console.ReadLine().ToUpper();
                        if (InputRequirements == "Y")//another decision statement to know if the user has the following requirements file to fully enrolled
                        {
                            Console.WriteLine("\nSearching for the Requirement files...\n");
                            //the files path to check if the requirment files is there
                            string directorPath = @"C:\Users\Misyel E\OneDrive\Documents\Requirements";

                            string[] FilesToCheck =
                            {
                             "SHS Diploma.pdf",
                             "Form137.pdf",
                             "Goodmoral.pdf",
                             "PSA.pdf",
                             "Grades.xlsx",
                             "Med Certificate.pdf",
                             };
                            foreach (string file in FilesToCheck)
                            {
                                string FilePath = Path.Combine(directorPath, file);
                                if (File.Exists(FilePath))
                                {
                                    Console.WriteLine($"File {file} exists.");
                                    
                                }
                                else
                                {
                                    Console.WriteLine($"File {file} does not exists");
                                   
                                } 
                            }
                            Console.WriteLine("==================================================");//the last output if wanting to enroll
                            Console.WriteLine("If files does not exists, please download the file to fully enrolled.");
                            Console.WriteLine("If all the files exists, Congrats you are now enrolled to STI College!");
                        }
                        else if (InputRequirements == "N")// to know if the files is downloaded
                        {
                            Console.Write("Please download the requirement files to be enrolled.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input try again.(type Y for yes or N for no)");//invalid user input to the question instruction
                        }
                    }

                    else if (InputMoney == "N")//requirments money if no money more than 32k
                    {
                        Console.WriteLine("Enrolling in this school needs to have money about 32 thousands above. thank you for consideration.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again.(type Y for yes or N for no)");//invalid user input to the question instruction
                    }
                }
                else if (InputEnroll == "N")//if not want to enroll
                {
                    Console.WriteLine("Thank you for consideration.");
                }
                else
                {
                    Console.WriteLine("Invalid input try again.(type Y for yes or N for no)");//invalid user input to the question instruction
                }
                Console.ReadKey();
                }
            }
        }
    }