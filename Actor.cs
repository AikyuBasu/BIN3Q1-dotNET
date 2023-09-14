using Application_Console_CSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be.ipl.domaine
{
    public class Actor : Person {

    private static readonly long serialVersionUID = 1L;
    private readonly int sizeInCentimeter;
    private IList<Movie> movies;

    public int GetSizeInCentimeter()
    {
        return sizeInCentimeter;
    }



    public Actor(String name, String firstname, DateTime birthDate, int sizeInCentimeter) 
    {
        base(name, firstname, birthDate);
        this.sizeInCentimeter = sizeInCentimeter;
        movies = new List<Movie>();
    }
    
    public override String ToString()
    {
        return "Actor [name = " + GetName() + " firstname = " + GetFirstname() + " sizeInCentimeter = " + sizeInCentimeter + " birthdate = " + GetBirthDate() + "]";
    }

    /**
     * 
     * @return list of movies in which the actor has played
     */
    public IEnumerator<Movie> Movies()
    {
        return movies.GetEnumerator();
    }

    /**
     * add movie to the list of movies in which the actor has played
     * @param movie
     * @return false if the movie is null or already present
     */
    public bool AddMovie(Movie movie)
    {
        if ((movie == null) || movies.Contains(movie))
            return false;

        if (!movie.containsActor(this))
            movie.addActor(this);

        movies.Add(movie);

        return true;
    }

    public bool ContainsMovie(Movie movie)
    {
        return movies.Contains(movie);
    }


    public override String GetName()
    {
        return base.GetName().ToUpperCase();
    }
}


}

