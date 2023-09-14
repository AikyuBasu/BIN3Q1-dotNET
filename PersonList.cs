
namespace be.ipl.domaine
{
    public class PersonList
    {
       
        private static PersonList instance;
        private IDictionary<String, Person> personMap;

        private PersonList()
        {
            personMap = new Dictionary<String, Person>();
        }

        public static PersonList GetInstance()
        {

            instance ??= new PersonList();

            return instance;
        }

        public void AddPerson(Person person)
        {
            if (person == null)
                throw new ArgumentException("invalid parameter");
            personMap.Add(person.GetName(), person);
        }

        public IEnumerator<Person> personList()
        {
            return personMap.Values.GetEnumerator();
        }

    }
}


