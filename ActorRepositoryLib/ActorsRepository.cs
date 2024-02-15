using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorRepositoryLib
{
    public class ActorsRepository
    {
        // Opretter en List med actors
        private List<Actor> _actors = new List<Actor>();

        //Property
        private int _nextId = 1;


        // Get(), returnerer alle Actor objekter i listen
        public IEnumerable<Actor> Get()
        {
            return _actors;
        }

        // birthYearBefore search, while also handling null values
        public IEnumerable<Actor> Get(int? birthYearBefore)
        {
            if (birthYearBefore.HasValue)
            {
                return _actors.Where(a => a.BirthYear < birthYearBefore.Value).ToList();
            }
            else
            {
                return _actors;
            }
           
        
        }

        // birthYearAfter search (commented out cuz it wont take 2 gets?? ugh)
        //public IEnumerable<Actor> Get(int? birthYearAfter)
        //{
        //    if (birthYearAfter.HasValue)
        //    {
        //        return _actors.Where(a => a.BirthYear > birthYearAfter.Value).ToList();
        //    }
        //    else
        //    {
        //        return _actors;
        //    }
           
        //}

        // Adds an Actor to the repository og den assigner en unique ID
        public Actor Add(Actor actor)
        {
            actor.Id = _nextId++;
            _actors.Add(actor);
            return actor;
        }


        // Deletes the Author object with the specified ID
        // And returns the deleted actor object or null if no actor object with that ID exists.
        public Actor Delete(int id)
        {
            var actor = _actors.FirstOrDefault(a => a.Id == id);
            if (actor != null)
            {
                _actors.Remove(actor);
                return actor;
            }

            return null;
            
        }

        // Updates the Actor object with the specified ID with the data also
        // Returns the updated Actor object, or null if no Actor object was found
        public Actor Update(int id, Actor data)
        {
            var actor = _actors.FirstOrDefault(a => a.Id == id);
            if(actor != null)
            {
                actor.Name = data.Name;
                actor.BirthYear = data.BirthYear;
                return actor;
            }
            return null;
        }
    }
}
