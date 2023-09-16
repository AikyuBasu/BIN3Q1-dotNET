using System.Runtime.Serialization;



namespace be.ipl.domaine
{
   

public class Person : ISerializable
{

private static readonly long serialVersionUID = 1L;

private readonly String _name; // ne se définit pas a l'intitialization. au contraire de const. 
private readonly String _firstname;
private readonly DateTime _birthDate;

                                // fonctionnement GETTER/SETTER ; pas de "get/set" avant la fonction et majuscule.
                                // Peut utilisé get/set en mot clé (implémentation automatique)
public virtual String Name {  get { return _name; } }

public String Firstname { get { return _firstname; } }

public String Birthdate { get { return _birthDate.ToString(); } }


public Person(String name, String firstname, DateTime birthDate)
{
    this._name = name;
    this._firstname = firstname;
    this._birthDate = birthDate;
}


    public override String ToString()
{
    return "Person [name = " + _name + ", firstname = " + _firstname + ", birthDate =  " + _birthDate + "]";
}

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}