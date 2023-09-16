using be.ipl.domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Console_CSharp
{
    public class Movie
    {
        private String _title;
        private int _releaseYear;
        private List<Actor> _actors;
        private Director? _director = null;

        public Movie(String title, int releaseYear)
        {
            _actors = new List<Actor>();
            this._title = title;
            this._releaseYear = releaseYear;
        }

        public Director? Director
        {
            get => _director;
            set
            {
                if (value == null) return;
                this._director = value;
                _director?.AddMovie(this);
            }
        }

        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int ReleaseYear
        {
            get { return _releaseYear; }
            set { _releaseYear = value; }
        }

        public bool AddActor(Actor actor)
        {
            if (_actors.Contains(actor))
                return false;

            _actors.Add(actor);
            if (!actor.ContainsMovie(this))
                actor.AddMovie(this);

            return true;
        }

        public bool ContainsActor(Actor actor)
        {
            return _actors.Contains(actor);
        }

     public override String ToString()
        {
            return "Movie [title=" + _title + ", releaseYear=" + _releaseYear + "]";
        }



    }
}