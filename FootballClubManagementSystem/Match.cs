using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClubManagementSystem
{
   public record class Match(string Opponent, DateTime Date, string Venue);
}
