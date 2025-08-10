using FootballClubManagementSystem.Contracts;
using System.ComponentModel;

namespace FootballClubManagementSystem
{
    public class Coache : Person,IStuff
    {
        
        public string LicenseLevel { get; set; }

        public string TacticalFormation { get; set; }
        public Coache( string name, int age, string licenseLevel, string tacticalFormation) : base( name, age)
        {
            LicenseLevel = licenseLevel;
            TacticalFormation = tacticalFormation;

        }

        public override string DisplayInfo()
        {
            return $"Coach:{Name},Age:{Age},License:{LicenseLevel},Formation:{TacticalFormation},Role:{GetRole()}";
        }

        public string GetRole()
        {
            return "Coach" ;
        }
    }
}