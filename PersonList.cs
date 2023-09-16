
namespace be.ipl.domaine
{
    public class PersonList
    {
       
        private static PersonList? _instance;
        private IDictionary<String, Person> _personMap;

        private PersonList()
        {
            _personMap = new Dictionary<String, Person>();
        }

        public static PersonList GetInstance()
        {

            _instance ??= new PersonList();

            return _instance;
        }

        public void AddPerson(Person person)
        {
            if (person == null)
                throw new ArgumentException("invalid parameter");
            _personMap.Add(person.Name, person);
        }

        public IEnumerator<Person> personList()
        {
            return _personMap.Values.GetEnumerator();
        }

    }
}


