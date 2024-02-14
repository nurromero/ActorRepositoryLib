using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorRepositoryLib
{
    public class Actor
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }


        public Actor(int id, string name, int birthYear)
        {
            Id = id;
            Name = name;
            BirthYear = birthYear;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, BirthYear: {BirthYear}";

        }

        //Validate metode til Name
        public void ValidateName()
        {
            if (Name == null)
            {
                throw new ArgumentNullException("Name cant be null.");
            }

            if(Name.Length < 4)
            {
                throw new ArgumentException("Name has to be atleast 4 letters long.");
            }
        }

        //Validate metode til Year
        public void ValidateYear()
        {
            if (BirthYear <= 1820)
            {
                throw new ArgumentException("Birthyear must be ATLEAST 1820.");
            }

        }
    }
}
