using FootballClubManagementSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FootballClubManagementSystem
{
    public class Club : IManageable
    {
        public Club(string name, int foundedYear, string stadium, decimal budget)
        {
            Name = name;
            FoundedYear = foundedYear;
            Stadium = stadium;
            _budgate = budget;
        }

        public string Name { get; set; }

        public int FoundedYear { get; set; }

        public string Stadium { get; set; }

        decimal _budgate;

        public List<Player> Players { get; set; } = new List<Player>();
        public List<Coache> coaches { get; set; } = new List<Coache>();
        public List<MedicalStaff> MedicalTeam { get; set; } = new List<MedicalStaff>();
        private List<Match> _matchs = new List<Match>();
        private List<MatchResult> _matchResults = new List<MatchResult>();
        public void AddBudget(decimal budget)
        {
            _budgate += budget;
        }

        public void ScheduleMatch(Match match)
        {
            _matchs.Add(match);
        }
        public void RecordeMatchResult(MatchResult matchResult)
        {
            _matchResults.Add(matchResult);
        }
        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void AssginCoach(Coache coache)
        {
            coaches.Add(coache);
        }

        public void RemoveCoach(string name)
        {
            Coache coache = coaches.FirstOrDefault(c => c.Name == name);
            if (coache != null)
            {
                coaches.Remove(coache);
            }

        }

        public void RemovePlayer(int playerId)
        {
            Player player = Players.FirstOrDefault(p => p.JerseyNumber == playerId);
            Players.Remove(player);
        }



        public void AddMedicalStuff(MedicalStaff medicalStaff)
        {
            MedicalTeam.Add(medicalStaff);
        }
        public void PrintMatchHistory()
        {

            Console.WriteLine($"Match History  for {Name}:");
            foreach (Match match in _matchs)
            {
                var matchresult = _matchResults.FirstOrDefault(c => c.Opponent == match.Opponent);
                Console.WriteLine($"{match.Date}vs {match.Opponent}{matchresult.GoalsScored}-{matchresult.Goalsconceded}");

            }
        }
        public void DisplayClub()
        {
            Console.WriteLine($"Club:{Name}\n Stadium:{Stadium}\n Budget: {_budgate}");
            Console.WriteLine("Players:");
            foreach(Player p in Players)
            {
                Console.WriteLine(p.DisplayInfo());
            }
            Console.WriteLine("Coaching stuff:");
            foreach(Coache c in coaches)
            {
                Console.WriteLine(c.DisplayInfo());
            }
            Console.WriteLine("Medical stuff:");
            foreach (MedicalStaff M in MedicalTeam)
            {
                Console.WriteLine(M.DisplayInfo());
            }
            PrintMatchHistory();

        }
    }
}
