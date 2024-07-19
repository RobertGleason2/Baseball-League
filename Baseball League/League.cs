using System;
using System.Collections.Generic;
using System.Text;

namespace Baseball_League
{
    class League
    {
        private string _name;
        private List<Player> _players;
        private List<Coach> _coaches;
        private List<Team> _teams;
        public string Name { set { _name = value; } get { return _name; } }
        public League() : this("No Name") { }
        public League(string name)
        {
            Name = name;
            _players = new List<Player>();
            _coaches = new List<Coach>();
            _teams = new List<Team>();
        }
        public bool CreatePlayer(string firstName, string lastName)
        {
            bool success = false;
            Player player = new Player(firstName, lastName);
            _players.Add(player);
            success = true;

            return success;
        }
        public string ListOfAllPlayers
        {
            get
            {
                string list = "";
                foreach(Player player in _players)
                {
                    list += player + "\n";
                }
                return list;
            }
        }
        public void DisplayListOfAllPlayers()
        {
            Console.WriteLine("The list of all the players is\n");
            Console.WriteLine(ListOfAllPlayers);
        }
        public bool ChangePostionToPlayer(string firstName, string lastName, string position)
        {
            bool success = false;
            Player foundPlayer = null;
            foreach(Player player in _players)
            {
                if(player.FirstName.Equals(firstName) && player.LastName.Equals(lastName))
                {
                    foundPlayer = player;
                }
            }
            if (foundPlayer != null)
            {
                string UpperCasePosition = position.ToUpper();
                //Enum.TryParse()
                POSITIONS desiredPosition;
                if (Enum.TryParse(UpperCasePosition, out desiredPosition))
                {
                    foundPlayer.Position = desiredPosition;
                    success = true;
                }
            }
            return success;
        }
        public bool CreateCoach(string firstName, string lastName)
        {
            bool success = false;
            Coach coach = new Coach(firstName,lastName);
            _coaches.Add(coach);
            success = true;

            return success;
        }
        public string ListOfAllCoaches
        {
            get
            {
                string list = "";
                foreach(Coach coach in _coaches)
                {
                    list += coach + "\n";
                }
                return list;
            }
        }
        public void DisplayListOfCoaches()
        {
            Console.WriteLine("The list of all the coaches is\n");
            Console.WriteLine(ListOfAllCoaches);
        }
        
        public bool ChangeTitleToCoach(string firstName, string lastName, string titleName)
        {
            bool success = false;
            Coach foundCoach = null;
            foreach (Coach coach in _coaches)
            {
                if (coach.FirstName.Equals(firstName) && coach.LastName.Equals(lastName))
                {
                    foundCoach = coach;
                }
            }
            if (foundCoach != null)
            {
                string UpperCasePosition = titleName.ToUpper();
                //Enum.TryParse()
                TITLE desiredTitle;
                if (Enum.TryParse(UpperCasePosition, out desiredTitle))
                {
                    foundCoach.Title = desiredTitle;
                    success = true;
                }
            }
            return success;
        }

        public bool CreateTeam(string teamName)
        {
            bool success = false;
            Team team = new Team(teamName);
            _teams.Add(team);
            success = true;

            return success;
        }
        public bool AddCoachToRoster(string firstName, string lastName, string teamName)
        {
            bool success = false;
            Coach foundCoach = null;
            Team foundTeam = null;
            foreach(Coach coach in _coaches)
            {
                if(coach.FirstName.Equals(firstName) && coach.LastName.Equals(lastName))
                {
                    foundCoach = coach;

                }
            }
            foreach(Team team in _teams)
            {
                if (team.Name.Equals(teamName))
                {
                    foundTeam = team;
                }
            }
            foundTeam.Add(foundCoach);
            success = true;
            return success;
        }

        public bool AddPlayerToRoster(string firstName, string lastName, string teamName)
        {
            bool success = false;
            Player foundPlayer = null;
            Team foundTeam = null;
            foreach (Player player in _players)
            {
                if (player.FirstName.Equals(firstName) && player.LastName.Equals(lastName))
                {
                    foundPlayer = player;

                }
            }
            foreach (Team team in _teams)
            {
                if (team.Name.Equals(teamName))
                {
                    foundTeam = team;
                }
            }
            foundTeam.Add(foundPlayer);
            success = true;
            return success;
        }
        public void RosterOfTeam(string teamName)
        {
            Team foundTeam = null;
            foreach (Team team in _teams)
            {
                if (team.Name.Equals(teamName))
                {
                    foundTeam = team;
                }
            }
            Console.WriteLine("The roster of the team" + teamName + "is\n");
            Console.WriteLine(foundTeam.TeamRoster);
        }

        public string ListOfAllTeams
        {
            get
            {
                string list = "";
                foreach(Team team in _teams)
                {
                    list += team + "\n";
                }
                return list;
            }
        }
        public void DisplayListOfTeams()
        {
            Console.WriteLine("The list of teams are\n");
            Console.WriteLine(ListOfAllTeams);
        }
    }
}
