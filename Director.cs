using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Console_CSharp
{
    internal class Director
    {
    }
}

public class Director extends Person implements Serializable {


    private static final long serialVersionUID = 5952964360274024205L;
private List<Movie> directedMovies;

public Director(String name, String firstname, Calendar birthDate)
{
    super(name, firstname, birthDate);
    directedMovies = new ArrayList<Movie>();
}

public boolean addMovie(Movie movie)
{

    if (directedMovies.contains(movie))
        return false;

    if (movie.getDirector() == null)
        movie.setDirector(this);

    directedMovies.add(movie);

    return true;

}

public Iterator<Movie> Movies()
{
    return directedMovies.iterator();
}
	
	
}
