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
    }
}
