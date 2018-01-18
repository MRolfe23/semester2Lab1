using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] answers = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
            string[] exam = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

            int correct;
            int incorrect;
            int i = 0;
            int SENTINAL = 1;

            Console.WriteLine("Welcome to the Exam!");
            Console.WriteLine("=====================");
            Console.WriteLine("Please enter the following to complete the Exam and recieve your score!");
            Console.WriteLine("*****Note: you will be able to take the exam as many times as you would like*****");
            Console.WriteLine("hit enter to start exam");
            Console.ReadKey();
            Console.WriteLine("===================================================================================");
            while(SENTINAL != -1)
            {
                correct = 0;
                incorrect = 0;
                Console.WriteLine("1)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  INCORRECT");
                Console.WriteLine("B)  CORRECT");
                Console.WriteLine("C)  INCORRECT");
                Console.WriteLine("D)  INCORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("1)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  INCORRECT");
                    Console.WriteLine("B)  CORRECT");
                    Console.WriteLine("C)  INCORRECT");
                    Console.WriteLine("D)  INCORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("2)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  INCORRECT");
                Console.WriteLine("B)  INCORRECT");
                Console.WriteLine("C)  INCORRECT");
                Console.WriteLine("D)  CORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("2)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  INCORRECT");
                    Console.WriteLine("B)  INCORRECT");
                    Console.WriteLine("C)  INCORRECT");
                    Console.WriteLine("D)  CORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("3)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  CORRECT");
                Console.WriteLine("B)  INCORRECT");
                Console.WriteLine("C)  INCORRECT");
                Console.WriteLine("D)  INCORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("3)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  CORRECT");
                    Console.WriteLine("B)  INCORRECT");
                    Console.WriteLine("C)  INCORRECT");
                    Console.WriteLine("D)  INCORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("4)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  CORRECT");
                Console.WriteLine("B)  INCORRECT");
                Console.WriteLine("C)  INCORRECT");
                Console.WriteLine("D)  INCORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("4)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  CORRECT");
                    Console.WriteLine("B)  INCORRECT");
                    Console.WriteLine("C)  INCORRECT");
                    Console.WriteLine("D)  INCORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("5)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  INCORRECT");
                Console.WriteLine("B)  INCORRECT");
                Console.WriteLine("C)  CORRECT");
                Console.WriteLine("D)  INCORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("5)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  INCORRECT");
                    Console.WriteLine("B)  INCORRECT");
                    Console.WriteLine("C)  CORRECT");
                    Console.WriteLine("D)  INCORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("6)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  CORRECT");
                Console.WriteLine("B)  INCORRECT");
                Console.WriteLine("C)  INCORRECT");
                Console.WriteLine("D)  INCORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("6)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  CORRECT");
                    Console.WriteLine("B)  INCORRECT");
                    Console.WriteLine("C)  INCORRECT");
                    Console.WriteLine("D)  INCORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("7)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  INCORRECT");
                Console.WriteLine("B)  CORRECT");
                Console.WriteLine("C)  INCORRECT");
                Console.WriteLine("D)  INCORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("7)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  INCORRECT");
                    Console.WriteLine("B)  CORRECT");
                    Console.WriteLine("C)  INCORRECT");
                    Console.WriteLine("D)  INCORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("8)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  CORRECT");
                Console.WriteLine("B)  INCORRECT");
                Console.WriteLine("C)  INCORRECT");
                Console.WriteLine("D)  INCORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("8)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  CORRECT");
                    Console.WriteLine("B)  INCORRECT");
                    Console.WriteLine("C)  INCORRECT");
                    Console.WriteLine("D)  INCORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("9)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  INCORRECT");
                Console.WriteLine("B)  INCORRECT");
                Console.WriteLine("C)  CORRECT");
                Console.WriteLine("D)  INCORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("9)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  INCORRECT");
                    Console.WriteLine("B)  INCORRECT");
                    Console.WriteLine("C)  CORRECT");
                    Console.WriteLine("D)  INCORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("10)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  INCORRECT");
                Console.WriteLine("B)  INCORRECT");
                Console.WriteLine("C)  INCORRECT");
                Console.WriteLine("D)  CORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("10)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  INCORRECT");
                    Console.WriteLine("B)  INCORRECT");
                    Console.WriteLine("C)  INCORRECT");
                    Console.WriteLine("D)  CORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("11)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  INCORRECT");
                Console.WriteLine("B)  CORRECT");
                Console.WriteLine("C)  INCORRECT");
                Console.WriteLine("D)  INCORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("11)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  INCORRECT");
                    Console.WriteLine("B)  CORRECT");
                    Console.WriteLine("C)  INCORRECT");
                    Console.WriteLine("D)  INCORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("12)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  INCORRECT");
                Console.WriteLine("B)  INCORRECT");
                Console.WriteLine("C)  CORRECT");
                Console.WriteLine("D)  INCORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("12)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  INCORRECT");
                    Console.WriteLine("B)  INCORRECT");
                    Console.WriteLine("C)  CORRECT");
                    Console.WriteLine("D)  INCORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("13)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  INCORRECT");
                Console.WriteLine("B)  INCORRECT");
                Console.WriteLine("C)  INCORRECT");
                Console.WriteLine("D)  CORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("13)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  INCORRECT");
                    Console.WriteLine("B)  INCORRECT");
                    Console.WriteLine("C)  INCORRECT");
                    Console.WriteLine("D)  CORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("14)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  CORRECT");
                Console.WriteLine("B)  INCORRECT");
                Console.WriteLine("C)  INCORRECT");
                Console.WriteLine("D)  INCORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("14)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  CORRECT");
                    Console.WriteLine("B)  INCORRECT");
                    Console.WriteLine("C)  INCORRECT");
                    Console.WriteLine("D)  INCORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("15)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  INCORRECT");
                Console.WriteLine("B)  INCORRECT");
                Console.WriteLine("C)  INCORRECT");
                Console.WriteLine("D)  CORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("15)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  INCORRECT");
                    Console.WriteLine("B)  INCORRECT");
                    Console.WriteLine("C)  INCORRECT");
                    Console.WriteLine("D)  CORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("16)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  INCORRECT");
                Console.WriteLine("B)  INCORRECT");
                Console.WriteLine("C)  CORRECT");
                Console.WriteLine("D)  INCORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("16)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  INCORRECT");
                    Console.WriteLine("B)  INCORRECT");
                    Console.WriteLine("C)  CORRECT");
                    Console.WriteLine("D)  INCORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("17)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  INCORRECT");
                Console.WriteLine("B)  INCORRECT");
                Console.WriteLine("C)  CORRECT");
                Console.WriteLine("D)  INCORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("17)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  INCORRECT");
                    Console.WriteLine("B)  INCORRECT");
                    Console.WriteLine("C)  CORRECT");
                    Console.WriteLine("D)  INCORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("18)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  INCORRECT");
                Console.WriteLine("B)  CORRECT");
                Console.WriteLine("C)  INCORRECT");
                Console.WriteLine("D)  INCORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("18)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  INCORRECT");
                    Console.WriteLine("B)  CORRECT");
                    Console.WriteLine("C)  INCORRECT");
                    Console.WriteLine("D)  INCORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("19)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  INCORRECT");
                Console.WriteLine("B)  INCORRECT");
                Console.WriteLine("C)  INCORRECT");
                Console.WriteLine("D)  CORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("19)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  INCORRECT");
                    Console.WriteLine("B)  INCORRECT");
                    Console.WriteLine("C)  INCORRECT");
                    Console.WriteLine("D)  CORRECT");

                    exam[i] = Console.ReadLine();
                }

                i++;

                Console.WriteLine("20)");
                Console.WriteLine("Please enter the correct answer to the Problem:");
                Console.WriteLine("A)  CORRECT");
                Console.WriteLine("B)  INCORRECT");
                Console.WriteLine("C)  INCORRECT");
                Console.WriteLine("D)  INCORRECT");

                exam[i] = Console.ReadLine();

                while (exam[i] != "A" && exam[i] != "B" && exam[i] != "C" && exam[i] != "D")
                {
                    Console.WriteLine("20)");
                    Console.WriteLine("Please enter the correct answer to the Problem:");
                    Console.WriteLine("A)  CORRECT");
                    Console.WriteLine("B)  INCORRECT");
                    Console.WriteLine("C)  INCORRECT");
                    Console.WriteLine("D)  INCORRECT");

                    exam[i] = Console.ReadLine();
                }
                Console.WriteLine("===========================================================");

                i = 0;

                while (i < 20)
                {
                    if ( answers[i] == exam[i])
                    {
                        correct++;
                    }
                    else
                    {
                        incorrect++;
                    }

                    i++;
                }

                if (correct >= 15)
                {
                    Console.WriteLine("You Passed!");
                }
                else
                {
                    Console.WriteLine("You Failed!");
                }
                Console.WriteLine("Total number correct: " + correct);
                Console.WriteLine("Total number incorrect: " + incorrect);

                i = 0;

                if (incorrect > 0)
                {
                    Console.WriteLine("Here is a list of all the questions you answered incorrectly");

                    while (i < 20)
                        {
                        if (answers[i] != exam[i])
                        {
                            Console.WriteLine("# " + (i + 1));
                        }

                            i++;
                        }
                }
                Console.WriteLine("If you would like to retake the exam please enter 1 or enter -1 to quit program.");
                SENTINAL = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
