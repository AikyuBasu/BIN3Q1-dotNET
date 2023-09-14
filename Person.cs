using System.Runtime.Serialization;



namespace be.ipl.domaine
{
   

public class Person : ISerializable
{

private static readonly long serialVersionUID = 1L;

private readonly String name; // ne se définit pas a l'intitialization. au contraire de const. 
private readonly String firstname;
private readonly DateTime birthDate;

public String GetName()
{
    return name;
}

public String GetFirstname()
{
    return firstname;
}

public String GetBirthDate()
{
    return birthDate.ToString();
}


public Person(String name, String firstname, DateTime birthDate)
{
    this.name = name;
    this.firstname = firstname;
    this.birthDate = birthDate;
}


    public override String ToString()
{
    return "Person [name = " + name + ", firstname = " + firstname + ", birthDate =  " + GetBirthDate() + "]";
}

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}