namespace FootballClubManagementSystem
{
   public record class MatchResult(string Opponent,DateTime Date,int GoalsScored,int Goalsconceded)
    {
        public void Display()
        {
            Console.WriteLine($"Opponent :{Opponent},Date:{Date},GoalsScored ={GoalsScored},GoalsConceded ={Goalsconceded}");
        }
    };
    
    
}