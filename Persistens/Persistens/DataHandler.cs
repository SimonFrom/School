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
    }
}
