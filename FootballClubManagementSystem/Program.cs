using System.Runtime.InteropServices;

namespace FootballClubManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Object
            Club club = new Club("Manchester United", 2001, "Old Trafford", 500_000_000m);
            Player player1 = new Player("Cristiano Ronaldo", 38, "Forward", 7, 7.8);
            player1.UpdateSalary(500_000m);
            Player player2 = new Player("Bruno Fernandes", 28, "Midfielder", 8, 9.8);
            player2.UpdateSalary(300_000m);
            Coache coache = new Coache("Erik Ten Hag", 53, "UEFA Pro", "4-3-3");
            MedicalStaff medicalStaff = new MedicalStaff("Dr.Smith", 40, "Sports -Medicin");
            Match match = new Match("Liverpool", new DateTime(2023, 5, 15), "50000");
            MatchResult matchResult = new("Liverpool", new DateTime(2023, 5, 15), 2, 1);
            Match match2 = new Match("Arsenal", new DateTime(2023, 5, 15), "50000");
            MatchResult matchResult2 = new("Arsenal", new DateTime(2023, 5, 1), 3, 1);
            #endregion

            #region Methods
            club.ScheduleMatch(match);
            club.ScheduleMatch(match2);
            club.RecordeMatchResult(matchResult);
            club.RecordeMatchResult(matchResult2);
            club.AddPlayer(player1);
            club.AddPlayer(player2);
            club.AssginCoach(coache);
            club.AddMedicalStuff(medicalStaff);
            club.DisplayClub();
            #endregion

            #region Original Vs Updated
            MatchResult Original = new("Chelsea", new DateTime(2023, 5, 15), 0, 0);
            MatchResult Updated = Original with { GoalsScored = 1 };
            Original.Display();
            Updated.Display();
            #endregion


        }
    }
}
