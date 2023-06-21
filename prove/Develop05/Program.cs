using System;

class Program
{
    static void Main(string[] args)
    {
        //www.plantuml.com/plantuml/png/hLHDgnCn5DtdLmJSl67QF_0eZ_TijHIaY5su495qSgt1J38aTugY_dVptJXC5vPsqKdElRdtd9EFPulCuDXBqabcBTrg9kalilnoSeCzw-6HMZH2dHAq0TiPCQ3GQX9vhuL2-qZTFo6hrLehYsE7sZmzaTQNVOZfLBcg2vec_59luPVI8PHf27cr1Tmc4WzDRfRXciWqMiXK0T9-W4uR7eWqaMMx4NQGx6V6pbfmqkxiMlU310JkmQFMalmXxXUiMVrUBkb1-0G_hy0t24OnEK7Ntw3xBeN5W1CIRSuLijbTxXZx5V_CpGOkGY5Q2ZV4rG0iqWx84BA-UxWJTHKJlB2937lJGRW3jqYjx4Hn_QZLQFTZ7shc-KklHuK1edVP1pz6qKCQXYODfV60lquKZc2ojWWN9Xc-QWEJ_sN3WPqXgFyg9AZgWi-8zRbPh4_tLp7TpBTfzJzNxACH23wIoLHztsd6P_iwI0e5Diy_VNQ8JzWf3Z-ghChXQIXwdL0tdD7Y-zTQr4NBp0jp_NN9Bqi-8UqBBtlYlqxoCoW-zl8l

        int points = 0;

        bool quit = false;

        List<Goal> goals = new List<Goal>();

        while (quit != true) {
            Console.WriteLine($"You have {points} points");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu: ");
            int menuAnswer = int.Parse(Console.ReadLine());
            

            switch (menuAnswer)
            {
                case 1: 
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    int goaltype = int.Parse(Console.ReadLine());

                    if (goaltype == 1) {
                        //Old method
                        // Console.Write("What is the name of your goal? ");
                        // string goalName = Console.ReadLine();

                        // Console.Write("What is a short description of it? ");
                        // string goalDescription = Console.ReadLine();

                        // Console.Write("What is the amount of points associated with this goal? ");
                        // int goalPoints = int.Parse(Console.ReadLine());

                        //goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints, false));

                        //New Method
                        goals.Add(new SimpleGoal(false));


                    }

                    else if (goaltype == 2) {
                        //Old Method
                        /*Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();

                        Console.Write("What is a short description of it? ");
                        string goalDescription = Console.ReadLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        int goalPoints = int.Parse(Console.ReadLine());

                        goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));*/

                        //New Method
                        goals.Add(new EternalGoal());
                    }

                    else if (goaltype == 3) {
                        //Old Method 
                        /*Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();

                        Console.Write("What is a short description of it? ");
                        string goalDescription = Console.ReadLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        int goalPoints = int.Parse(Console.ReadLine());

                        Console.Write("How many times does this goal need to accomplished for a bonus? ");
                        int bonusNum = int.Parse(Console.ReadLine());

                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        int bonusAmount = int.Parse(Console.ReadLine());

                        goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, bonusNum, bonusAmount));*/

                        //New Method
                        goals.Add(new ChecklistGoal());
                    }
                    break;
                
                case 2:   
                    int i = 1;  
                    foreach (Goal goal in goals) {
                        goal.DisplayGoal(i);
                        i++;
                    }
                    Console.WriteLine();
                    break;


                case 3: 


                    break;
                    
                
                case 4: 


                    break;

                
                case 5: 
                    Console.WriteLine("The Goals are: ");
                    int l = 1;
                    foreach (Goal goal in goals) {
                        goal.DisplayGoal(l);
                        l++;
                    }
                    
                    Console.Write("Which goal did you accomplish? ");
                    int goalIndex = int.Parse(Console.ReadLine());

                    int addedPoints = goals[goalIndex - 1].RecordGoal();
                    points += addedPoints;

                    Console.WriteLine($"You now have {points} points.\n");
                    break;


                case 6: 
                    Console.WriteLine();
                    Console.WriteLine("GoodBye");
                    
                    quit = true;
                    break;

                    
                default:
                    Console.WriteLine("Invalid Answer! \nNumber must be between 1 and 6!");
                    break;
            }
        }
    }
}