using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Windows.Controls;
using System.Xml.Linq;

namespace DataProviderExample
{
    public class Detachment // Отряд
    {
        private ObservableCollection<Hobbit> hobbits;
        
        public Detachment()
        {
            hobbits = new ObservableCollection<Hobbit>
            {
                new Hobbit{name = "Bilbo", role = "stranger" }
                //new Hobbit{name = "Frodo", role = "stranger" },
                //new Hobbit{name = "Legolas", role = "stranger" },
            };
        }
        //public void addHobbit(string name)
        //{
        //    hobbits.Add(new Hobbit { id=counter++, name = name, role = "stranger"});
            
        //}
        
        public ObservableCollection<Hobbit> GetHobbits()
        {
            return hobbits;
        }
    }
    public class Hobbit
    {
        static private int Id = 0;
        static public int id { get { return Id; } set { Id = value; } }
        public string name { get; set; }
        public string role { get; set; }
        public string full_data { get { return this.ToString(); } }
        public Hobbit ()
        {
            Id++;
        }
        public override string ToString()
        {
            return $"N: {id} Name: {name} Role: {role}";
        }
    }
}
