namespace FootballClubManagementSystem
{
    public class Player : Person
    {

        public Player( string name, int age, string position, int jerseyNumber, double skillRating) : base( name, age)
        {
           
            Position = position;
            JerseyNumber = jerseyNumber;
            SkillRating = skillRating;
        }
        public string Position { get; set; }

        public int JerseyNumber { get; set; }

        public double SkillRating { get; set; }

        public decimal Salary { get; private set; }

        public override string DisplayInfo()
        {
            return $"Player:{Name},Age:{Age},Position:{Position},Jersey:{JerseyNumber},Salary:${Salary}";
        }

        public void UpdateSalary(decimal amount)
        {
            Salary = amount;
        }

    }
}