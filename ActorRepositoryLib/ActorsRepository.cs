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
        private int _nextId = 0;


        // Get(), returnerer alle Actor objekter i listen
        // Optional parameters  
        public IEnumerable<Actor> Get(int? birthYear=null, string? name=null, string? orderBy=null)
        {
            IQueryable<Actor> query = _actors.AsQueryable();

            if(birthYear != null)
            {
                query = query.Where(a => a.BirthYear == birthYear);
            }
            if(name != null)
            {
                query = query.Where(a => a.Name == name);
            }
            if(orderBy != null)
            {
                query = orderBy switch
                {
                    "name" => query.OrderBy(a => a.Name),
                    "birthYear" => query.OrderBy(a => a.BirthYear),
                    //Default value
                    _ => query
                };
            }

            return query;
        }

        public Actor GetId(int id)
        {
            return _actors[id];
        }

        // Adds an Actor to the repository og den assigner en unique ID
        public Actor Add(Actor actor)
        {
            actor.Id = _nextId++;
            _actors.Add(actor);
            return actor;
        }

        // Deletes the Author object with the specified ID
        // And returns the deleted actor object or null if no actor object with that ID exists.
        public Actor? Delete(int id)
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
        public Actor? Update(int id, Actor data)
        {
            var actor = _actors.FirstOrDefault(a => a.Id == id);
            if(actor != null)
            {
                _actors[id] = data;
                return actor;
            }

            return null;
        }
    }
}
