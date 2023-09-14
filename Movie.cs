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
        private String title;
        private int releaseYear;
        private List<Actor> actors;
        private Director director;

        public Movie(String title, int releaseYear)
        {
            actors = new List<Actor>();
            this.title = title;
            this.releaseYear = releaseYear;
        }

        public Director GetDirector()
        {
            return director;
        }
        public void SetDirector(Director director)
        {
            if (director == null)
                return;
            this.director = director;
            director.AddMovie(this);
        }

        public String GetTitle()
        {
            return title;
        }
        public void SetTitle(String title)
        {
            this.title = title;
        }
        public int GetReleaseYear()
        {
            return releaseYear;
        }
        public void SetReleaseYear(int releaseYear)
        {
            this.releaseYear = releaseYear;
        }

        public bool AddActor(Actor actor)
        {
            if (actors.Contains(actor))
                return false;

            actors.Add(actor);
            if (!actor.ContainsMovie(this))
                actor.AddMovie(this);

            return true;
        }

        public bool ContainsActor(Actor actor)
        {
            return actors.Contains(actor);
        }

     public override String ToString()
        {
            return "Movie [title=" + title + ", releaseYear=" + releaseYear + "]";
        }



    }
}