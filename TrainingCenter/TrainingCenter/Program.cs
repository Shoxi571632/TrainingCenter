using TrainingCenter.Information;

namespace TrainingCenter;

internal class Program
{
    static void Main(string[] args)
    {
        var centerService = new TrainingCenterInformation();
        bool exit = false;

        while (!exit)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\t\t\t\t\t\t\t\t ________________________________________");
            Console.WriteLine("\t\t\t\t\t\t\t\t|           1.Training Center            |");
            Console.WriteLine("\t\t\t\t\t\t\t\t|________________________________________|");

            Console.WriteLine("\t\t\t\t\t\t\t\t ________________________________________");
            Console.WriteLine("\t\t\t\t\t\t\t\t|           2.Student                    |");
            Console.WriteLine("\t\t\t\t\t\t\t\t|________________________________________|");

            Console.WriteLine("\t\t\t\t\t\t\t\t ________________________________________");
            Console.WriteLine("\t\t\t\t\t\t\t\t|           3.Exit                       |");
            Console.WriteLine("\t\t\t\t\t\t\t\t|________________________________________|");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Choose: >>");
            var choice = Console.ReadLine();
            Console.ResetColor();


            switch (choice)
            {
                //1.Training Center
                case "1":
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t\t\t\t\t ________________________________________");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|          1.Courses                     |");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|________________________________________|");

                        Console.WriteLine("\t\t\t\t\t\t\t\t ________________________________________");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|          2.Teacher                     |");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|________________________________________|");

                        Console.WriteLine("\t\t\t\t\t\t\t\t ________________________________________");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|          3.About the center            |");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|________________________________________|");

                        Console.WriteLine("\t\t\t\t\t\t\t\t ________________________________________");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|          4.View applications           |");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|________________________________________|");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\t\t\t\t\t\t\t ________________________________________");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|          5.Return to home screen       |");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|________________________________________|");

                        var back = Console.ReadLine();
                        switch (back)
                        {
                            //Courses
                            case "1":

                                break;
                                //Teacher
                            case "2":
                                break;
                            //About the center
                            case "3":
                                centerService.TrainingCenterInformations();
                                // Thread.Sleep(1500);

                                Console.ReadLine();
                                break;
                            //View applications
                            case "4":
                                break;
                            //Return to home screen
                            case "5":
                                goto MainLoop;
                                break;
                        }
                        break;
                    }
                    break;

                //2.Student
                case "2":
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t\t\t\t\t ________________________________________");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|          1.Courses                     |");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|________________________________________|");

                        Console.WriteLine("\t\t\t\t\t\t\t\t ________________________________________");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|          2.Teacher                     |");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|________________________________________|");

                        Console.WriteLine("\t\t\t\t\t\t\t\t ________________________________________");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|          3.About the center            |");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|________________________________________|");

                        Console.WriteLine("\t\t\t\t\t\t\t\t ________________________________________");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|          4.Submission of applications  |");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|________________________________________|");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\t\t\t\t\t\t\t ________________________________________");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|          5.Return to home screen       |");
                        Console.WriteLine("\t\t\t\t\t\t\t\t|________________________________________|");
                        var back = Console.ReadLine();
                        switch (back)
                        {
                            //Courses
                            case "1":
                                break;
                            //Teacher
                            case "2":
                                break;
                            //About the center
                            case "3":
                                break;
                            //View applications
                            case "4":
                                break;
                            //Return to home screen
                            case "5":
                                goto MainLoop;
                                break;
                        }
                        break;
                    }
                    break;

                //3.Exit
                case "3":
                    exit = true;
                    break;

            }
                MainLoop:;
        }
            Console.ReadLine();
    }
}
