using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClubManagementSystem
{
    public abstract class Person
    {
        protected Person( string name, int age)
        {

            Name = name;
            Age = age;
        }

        
        public string Name { get; set; }

        public int Age { get; set; }
        public abstract string DisplayInfo();
    }
}
