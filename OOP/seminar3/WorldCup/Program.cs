using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;


namespace WorldCup
{
    internal class Program
    {
        static void ReadData(out List<Team> teams, out List<Stadium> stadiums, out List<Match> matches)
        {
            using (var sr = new StreamReader("matches.txt"))
            {
 
  
                teams = new List<Team>();
                
                string line;
                string[] parts;
                int count = int.Parse(sr.ReadLine());
                for (int i = 0; i < count; ++i)
                {
                    line = sr.ReadLine();
                    parts = line.Split(';');
                    var team = new Team
                    {
                        Id = int.Parse(parts[0]),
                        Name = parts[1]
                    };
                    teams.Add(team);

                }

                
                stadiums = new List<Stadium>();
                
                count = int.Parse(sr.ReadLine());
                for (int i = 0; i < count; ++i)
                {
                    line = sr.ReadLine();
                    parts = line.Split(';');
                    var stadium = new Stadium
                    {
                        Id = int.Parse(parts[0]),
                        Name = parts[1],
                        City = parts[2]

                    };
                    stadiums.Add(stadium);
                }

                
                matches = new List<Match>();
                
                count = int.Parse(sr.ReadLine());
                for (int i = 0; i < count; ++i)
                {
                    line = sr.ReadLine();
                    parts = line.Split(';');

                    int team1Id = int.Parse(parts[0]),
                        team2Id = int.Parse(parts[1]),
                        stadiumId = int.Parse(parts[2]);
                    Team team1 = FindTeam(teams, team1Id);
                    Team team2 = FindTeam(teams, team2Id);
                    Stadium stadium = FindStadium(stadiums, stadiumId);

                    var match = new Match
                    {
                        Team1 = team1,
                        Team2 = team2,
                        Stadium = stadium,
                        Date = DateTime.Parse(parts[3])

                    };
                    matches.Add(match);
                }

               
            }


        }
        
        
        static Team FindTeam(List<Team> teams, int teamId)
        {
            int i = 0;
            while (i < teams.Count && (teams[i].Id != teamId))
                i++;
            if (i < teams.Count)
                return teams[i];
            return null;
        }
        
        static Stadium FindStadium(List<Stadium> stadiums, int stadiumId)
        {
            int i = 0;
            while (i < stadiums.Count && (stadiums[i].Id != stadiumId))
                i++;
            if (i < stadiums.Count)
                return stadiums[i];
            return null;
        }
        
        public static void Main(string[] args)
        {
            ReadData(out var teams, out var matches, out var stadiums);
        }
    }
}