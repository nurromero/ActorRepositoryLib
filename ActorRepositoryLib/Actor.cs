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
        public string? Name { get; set; }
        public int BirthYear { get; set; }


        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, BirthYear: {BirthYear}";

        }

        //Validate metode til Name
        public bool ValidateName()
        {
            if (Name == null)
            {
                throw new ArgumentNullException("Name cant be null.");
            }

            if(Name.Length < 3)
            {
                throw new ArgumentException("Name has to be atleast 3 letters long.");
            }

            return true;
        }

        //Validate metode til Year
        public bool ValidateYear()
        {
            if (BirthYear < 1820)
            {
                throw new ArgumentException("Birthyear must be ATLEAST 1820.");
            }

            return true;
        }

        // Validate metode
        public bool Validate()
        {
            ValidateName();
            ValidateYear();

            return true;
        }
    }
}
