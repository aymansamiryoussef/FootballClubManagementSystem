using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClubManagementSystem.Contracts
{
    public interface IMatchSchaduler
    {
        public void ScheduleMatch(Match match);
    }
}
