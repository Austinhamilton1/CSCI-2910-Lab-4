
namespace CSCI_2910_Lab_4
{
    public class Program
    {
        static List<Person> people;
        public static void Main(string[] args)
        {
            people = new List<Person>();
            using (StreamReader sr = new StreamReader(FileRoot.Root
                + Path.DirectorySeparatorChar + "data.csv"))
            {
                //read the file line by line
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    //split the line on commas and then create an address object with the fields
                    //3 - 5
                    //use the rest of the line and the address to create a person and add
                    //that to the people list
                    string[] fields = line.Split(',');
                    Address address = new Address(fields[2], fields[3], fields[4], fields[5]);
                    people.Add(new Person(fields[0], fields[1], address));
                }
            }

            people.Sort();

            using (StreamWriter writer = new StreamWriter(FileRoot.Root
                + Path.DirectorySeparatorChar + "data.psv"))
            {
                foreach(Person person in people)
                {
                    writer.WriteLine(person);
                }
            }
        }
    }
}