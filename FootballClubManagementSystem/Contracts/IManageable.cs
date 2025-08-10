using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClubManagementSystem.Contracts
{
    public interface IManageable
    {

        void AddPlayer(Player player);

        void RemovePlayer(int playerId);

        void AssginCoach(Coache coache);

        void RemoveCoach(string  coachname);

        void AddMedicalStuff(MedicalStaff medicalStaff);


    }
}
