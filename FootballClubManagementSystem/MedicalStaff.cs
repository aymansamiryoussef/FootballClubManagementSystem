using FootballClubManagementSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClubManagementSystem
{
    public class MedicalStaff:Person,IStuff
    {

        public string specialization { get; set; }
        public MedicalStaff( string name, int age, string specialization) : base(name, age)
        {
            this.specialization = specialization;
            
        }

        public override string DisplayInfo()
        {
            return $"Coach:{Name},Age:{Age},Specialization:{specialization},Role:{GetRole()}";
        }

        public string GetRole()
        {
            return "Medical Team" ;
        }
    }
}
