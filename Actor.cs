using Application_Console_CSharp;

namespace be.ipl.domaine
{
    [Serializable]
    public class Actor : Person {

    private static readonly long serialVersionUID = 1L;
    private readonly int sizeInCentimeter;
    private IList<Movie> movies;

    public int GetSizeInCentimeter()
    {
        return sizeInCentimeter;
    }



    public Actor(String name, String firstname, DateTime birthDate, int sizeInCentimeter) : base (name, firstname, birthDate) 
    {
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

        if (!movie.ContainsActor(this))
            movie.AddActor(this);

        movies.Add(movie);

        return true;
    }

    public bool ContainsMovie(Movie movie)
    {
        return movies.Contains(movie);
    }


    public override String GetName()
    {
        return base.GetName().ToUpper();
    }
}


}

