using Application_Console_CSharp;

namespace be.ipl.domaine
{
    [Serializable]
    public class Actor : Person {

    private readonly int _sizeInCentimeter;
    private IList<Movie> _movies;

    public int SizeInCentimeter { get {  return _sizeInCentimeter; } }



    public Actor(String name, String firstname, DateTime birthDate, int sizeInCentimeter) : base (name, firstname, birthDate) 
    {
        this._sizeInCentimeter = sizeInCentimeter;
        _movies = new List<Movie>();
    }
    
    public override String ToString()
    {
        return "Actor [name = " + Name + " firstname = " + Firstname + " sizeInCentimeter = " + _sizeInCentimeter + " birthdate = " + Birthdate + "]";
    }

    /**
     * 
     * @return list of movies in which the actor has played
     */
    public IEnumerator<Movie> Movies()
    {
        return _movies.GetEnumerator();
    }

    /**
     * add movie to the list of movies in which the actor has played
     * @param movie
     * @return false if the movie is null or already present
     */
    public bool AddMovie(Movie movie)
    {
        if ((movie == null) || _movies.Contains(movie))
            return false;

        if (!movie.ContainsActor(this))
            movie.AddActor(this);

        _movies.Add(movie);

        return true;
    }

    public bool ContainsMovie(Movie movie)
    {
        return _movies.Contains(movie);
    }


    public override String Name
    {
        get { return base.Name.ToUpper(); }
    }
}


}

