using System;

namespace Baseball_League
{
    public class Program
    {
        public static void Main(string[] args)
        {
            League league = new League("OOD League");
            Console.WriteLine("Welcome to our League Management System\n");
            bool finished = false;
            while (!finished)
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1. Players");
                Console.WriteLine("2. Coaches");
                Console.WriteLine("3. Teams");
                Console.WriteLine("9. Exit");
                string input = Console.ReadLine();
                string teamName;
                string coachFirstName;
                string coachLastName;
                string playerFirstName;
                string playerLastName;
                switch (input)
                {
                    case "1":
                        Console.WriteLine("We now deal with Players");
                        bool inputPlayer = false;
                        while (!inputPlayer)
                        {
                            Console.WriteLine("\nPlease enter your choice ");
                            Console.WriteLine("1. Create player");
                            Console.WriteLine("2. List All");
                            Console.WriteLine("3. Change Position to players");
                            Console.WriteLine("9. Quit");
                            string inputLinePlayer = Console.ReadLine();
                            switch (inputLinePlayer)
                            {
                                case "1":
                                    Console.WriteLine("\nLet's create a player.\n");
                                    Console.WriteLine("Please enter the first name\n");
                                    string inputFirstName = Console.ReadLine();
                                    Console.WriteLine("\nPlease enter the last name\n");
                                    string inputLastName = Console.ReadLine();
                                    bool playerCreated = league.CreatePlayer(inputFirstName, inputLastName);
                                    if (playerCreated)
                                    {
                                        Console.WriteLine("The player " + inputFirstName + " " + inputLastName + " " + "was successfully created.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("There was an error creating a new player.");
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Let's list all the players.");
                                    league.DisplayListOfAllPlayers();
                                    break;
                                case "3":
                                    Console.WriteLine("Let's change a position of a player.");
                                    Console.WriteLine("Please enter the first name of the player");
                                    playerFirstName = Console.ReadLine();
                                    Console.WriteLine("Please enter the last name of the player");
                                    playerLastName = Console.ReadLine();
                                    Console.WriteLine("Please enter the name of the position you want to change");
                                    string inputPosition = Console.ReadLine();
                                    bool changedPosition = league.ChangePostionToPlayer(playerFirstName, playerLastName, inputPosition);
                                    if (changedPosition)
                                    {
                                       Console.WriteLine("The player " + playerFirstName + " " + playerLastName + "'s " + "position was changed to " + inputPosition);
                                    }
                                    else
                                    {
                                        Console.WriteLine("There was an error changing the position");
                                    }
                                    break;
                                case "9":
                                    inputPlayer = true;
                                    break;
                                default:
                                    Console.WriteLine("I do no undrestand that choice \n");
                                    break;
                            }
                        }
                        Console.WriteLine( "Returning to the main menu.");
                        break;
                    case "2":
                        Console.WriteLine("We now deal with Coaches");
                        bool inputCoaches = false;
                        while(!inputCoaches){
                            Console.WriteLine("\nPlease enter your choice.");
                            Console.WriteLine("1. Create coach");
                            Console.WriteLine("2. List All");
                            Console.WriteLine("3. Change a title of a coach");
                            Console.WriteLine("9. Quit");
                            string inputCoachLine = Console.ReadLine();
                            switch (inputCoachLine)
                            {
                                case "1":
                                    Console.WriteLine("Let's create a coach");
                                    Console.WriteLine("Please enter the first name");
                                    coachFirstName = Console.ReadLine();
                                    Console.WriteLine("Please enter the last name");
                                    coachLastName = Console.ReadLine();
                                    bool coachCreated = league.CreateCoach(coachFirstName, coachLastName);
                                    if (coachCreated)
                                    {
                                        Console.WriteLine("The coach was successfully created");
                                    }
                                    else
                                    {
                                        Console.WriteLine("There was an error creating the coach");
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Let's list all the coaches");
                                    league.DisplayListOfCoaches();
                                    break;
                                case "3":
                                    Console.WriteLine("Let's change the title of a coach");
                                    Console.WriteLine("Please enter the first name of the coach");
                                    coachFirstName = Console.ReadLine();
                                    Console.WriteLine("Please enter the last name of the coach");
                                    coachLastName = Console.ReadLine();
                                    Console.WriteLine("Please enter the name of the title you want to change");
                                    string inputTitle = Console.ReadLine();
                                    bool changedPosition = league.ChangeTitleToCoach(coachFirstName, coachLastName, inputTitle);
                                    if (changedPosition)
                                    {
                                        Console.WriteLine("The coach " + coachFirstName + " " + coachLastName + "'s " + "title was changed to " + inputTitle);
                                    }
                                    else
                                    {
                                        Console.WriteLine("There was an error changing the title");
                                    }
                                    break;
                                case "9":
                                    inputCoaches = true;
                                    break;
                                default:
                                    Console.WriteLine("I do not understand that choice\n");
                                    break;
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("We now deal with Teams");
                        bool inputTeam = false;
                        while (!inputTeam)
                        {
                            Console.WriteLine("Please enter your choices");
                            Console.WriteLine("1. Create a team");
                            Console.WriteLine("2. List All Teams");
                            Console.WriteLine("3. Add coach to a team");
                            Console.WriteLine("4. Add player to a team");
                            Console.WriteLine("5. List the roster of a team");
                            Console.WriteLine("9. Exit");
                            string inputTeamLine = Console.ReadLine();

                            switch (inputTeamLine)
                            {
                                case "1":
                                    Console.WriteLine("Let's create a team");
                                    Console.WriteLine("Plaese enter the name of the team");
                                    string inputTeamName = Console.ReadLine();
                                    bool teamCreated = league.CreateTeam(inputTeamName);
                                    if (teamCreated)
                                    {
                                        Console.WriteLine("The team " + inputTeamName + " was successfully created");
                                    }
                                    else
                                    {
                                        Console.WriteLine("There was an error creating the team");
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Let's list all the teams");
                                    league.DisplayListOfTeams();
                                    break;
                                case "3":
                                    Console.WriteLine("Let's add a coach to a team\n");
                                    Console.WriteLine("Please enter the first name of the coach");
                                    coachFirstName = Console.ReadLine();
                                    Console.WriteLine("Please enter the last name of the coach");
                                    coachLastName = Console.ReadLine();
                                    Console.WriteLine("Please enter the name of the team you");
                                    teamName = Console.ReadLine();
                                    bool coachAdded = league.AddCoachToRoster(coachFirstName, coachLastName, teamName);
                                    if (coachAdded)
                                    {
                                        Console.WriteLine("The coach" +coachFirstName + coachLastName + "was added to " + teamName);
                                    }
                                    else
                                    {
                                        Console.WriteLine("There was an error adding the coach to the team");
                                    }
                                    break;
                                case "4":
                                    Console.WriteLine("Let's add a player to a team\n");
                                    Console.WriteLine("Let's add a coach to a team\n");
                                    Console.WriteLine("Please enter the first name of the coach");
                                    playerFirstName = Console.ReadLine();
                                    Console.WriteLine("Please enter the last name of the coach");
                                    playerLastName = Console.ReadLine();
                                    Console.WriteLine("Please enter the name of the team you");
                                    teamName = Console.ReadLine();
                                    bool playerAdded = league.AddPlayerToRoster(playerFirstName, playerLastName, teamName);
                                    if (playerAdded)
                                    {
                                        Console.WriteLine("The coach" + playerFirstName + playerLastName + "was added to " + teamName);
                                    }
                                    else
                                    {
                                        Console.WriteLine("There was an error adding the player to the team");
                                    }
                                    break;
                                case "5":
                                    Console.WriteLine("Let's list the roster of a team\n");
                                    Console.WriteLine("Please enter the name of the team");
                                    teamName = Console.ReadLine();
                                    league.RosterOfTeam(teamName);
                                    break;
                                case "9":
                                    inputTeam = true;
                                    break;
                                default:
                                    Console.WriteLine("I don't understand that choice");
                                    break;
                            }
                        }
                        break;
                    case "9":
                        finished = true;
                        break;
                    default:
                        Console.WriteLine("I do no undrestand that choice \n");
                        break;
                }
            }
            Console.WriteLine("Thank you for using our program");
        }
    }
}
