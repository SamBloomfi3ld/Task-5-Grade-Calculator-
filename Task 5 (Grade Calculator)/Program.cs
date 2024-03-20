using System;

namespace task4
{
    class prog
    {
        //here is a funtion i used to calculate the average marks
        static double calculateAverage(int mathmarks, int physicsmarks, int chemistrymarks, int Computersciencemarks)
        {
            return (mathmarks + physicsmarks + chemistrymarks + Computersciencemarks) / 4;
        }
        // here is the funtion i used to calculate the grade based on the average marks they get
        static char CalculateGrade(double averageMarks)
        {
            if (averageMarks >= 80)
            {
                return 'A';
            }
            else if (averageMarks >= 70)
            {
                return 'B';
            }
            else if (averageMarks >= 60)
            {
                return 'C';
            }
            else if (averageMarks >= 50)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }

        //here is the main method
        static void Main(string[] args)
        {
            try
            {
                //display message to user asking to promt their name
                Console.WriteLine("Enter your name:");
                //read and store user input in an string variable name
                string name = Console.ReadLine();

                //creating a new line display welcome message using user's name
                Console.WriteLine($"\nWelcome {name} to my Grade Calculator program");
                //output lets begin message
                Console.WriteLine("Lets begin.");

                //displaying message and ask for user input 
                Console.WriteLine("\nEnter your marks for Mathmatics (out of 100):");
                //read and store user input in an int variable mathmarks
                int mathmarks = Convert.ToInt32(Console.ReadLine());

                //displaying message and ask for user input
                Console.WriteLine("\nEnter your marks for Physics (out of 100):");
                //read and store user input in an int variable physicsmarks
                int physicsmarks = Convert.ToInt32(Console.ReadLine());

                //displaying message and ask for user input
                Console.WriteLine("\nEnter your marks for Chemistry (out of 100):");
                //read and store user input in an int variable chemistrymarks
                int chemistrymarks = Convert.ToInt32(Console.ReadLine());

                //displaying message and ask for user input
                Console.WriteLine("\nEnter your marks for Computer Science (out of 100):");
                //read and store user input in an int variable Computersciencemarks
                int Computersciencemarks = Convert.ToInt32(Console.ReadLine());

                //display a message to the user stating that here are their marks including their name
                Console.WriteLine($"\nHere is your grade {name}");

                //calculating the average grade and storing it in average marks variable double
                double averageMarks = calculateAverage(mathmarks, physicsmarks, chemistrymarks, Computersciencemarks);

                //initialized grade as char and calculating the grade based on the average marks
                char grade = CalculateGrade(averageMarks);

                //creating a switch statement to print out messages based on what grade they get
                switch (grade)
                {
                    case 'A':
                        {
                            Console.WriteLine("Excellent! Your grade is A");
                        }
                        break;
                    case 'B':
                        {
                            Console.WriteLine("Good! Your grade is B");
                        }
                        break;
                    case 'C':
                        {
                            Console.WriteLine("Satisfactory. Your grade is C");
                        }
                        break;
                    case 'D':
                        {
                            Console.WriteLine("Pass. Your grade is D");
                        }
                        break;
                    case 'F':
                        {
                            Console.WriteLine("Fail. Your grade is F");
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Grade is invalid!");
                        }
                        break;




                }

            }
            catch (Exception ex)
            {
                //the try and catch is to hand the execption and dissplay a message of error when something goes wrong
                Console.WriteLine($"The Execption:{ex.Message}");
            }


        }
    }
}