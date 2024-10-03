using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistens
{
    public class DataHandler
    {

        
        private string dataFileName = "";

        public string DataFileName
        {
            get { return dataFileName; }
        }

        public DataHandler(string DataFileName)
        {
            dataFileName = DataFileName;    
        }

        public void SavePerson(Person person)
        {
            StreamWriter sw = new StreamWriter(DataFileName);
            sw.WriteLine(person.MakeTitle());
            sw.Close();
        }

        public void SavePersons(Person[] persons)
        {
            
            StreamWriter sw = new StreamWriter(DataFileName);
            for (int i = 0; i < persons.Length; i++)
            {
                string title = persons[i].MakeTitle();
                sw.WriteLine(title);
            }
            sw.Close();
        }

        public Person LoadPerson()
        {
            Person person = new Person("navn",DateTime.Now,0,false,0);
            StreamReader sr = new StreamReader(DataFileName);
            string line = sr.ReadLine(); 
            sr.Close();
            string[] personArray = line.Split(';');

            person.Name = personArray[0];
            person.BirthDate = DateTime.Parse(personArray[1]);
            person.Height = Double.Parse(personArray[2]);
            person.IsMarried = bool.Parse(personArray[3]);
            person.NoOfChildren = int.Parse(personArray[4]);

            return person;   
        }
        
        

        public Person[] LoadPersons()
        {
            string[] lines = new string[] { };
            string[] part = new string[5];
            Person[] person = null;

            try
            {
                using StreamReader sr = new StreamReader(DataFileName);
                {
                    lines = sr.ReadToEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    sr.Close();
                }
                person = new Person[lines.Length];
                    for (int i = 0; i < lines.Length; i++)
                    {
                    part = lines[i].Split(';');
                    person[i] = new Person(part[0], DateTime.Parse(part[1]), double.Parse(part[2]), bool.Parse(part[3]), int.Parse(part[4]));
                    }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            return person;

        }
    }
    
}
