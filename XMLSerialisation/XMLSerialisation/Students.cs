using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerialisation
{
    [Serializable]
    public class Students
    {
        [XmlAttribute]
        public string name { get; set; }
        [XmlAttribute]
        public int number { get; set; }
        [XmlAttribute]
        public string surname { get; set; }
        [XmlAttribute]
        public string patronimic { get; set; }
        [XmlAttribute]
        public DateTime date { get; set; }

        public Students () { }
        public Students(int number, string name,  string surname, string patronimic, DateTime date)
        {
            this.name = name;
            this.number = number;
            this.surname = surname;
            this.patronimic = patronimic;
            this.date = date;
        }
        static public void Serealize_it(List<Students> students, string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Students>));
            using (Stream fStream = new FileStream(filename,
                FileMode.Append, FileAccess.Write, FileShare.None))
            {
                xmlSerializer.Serialize(fStream, students);
            }
        }
       


    }
}
