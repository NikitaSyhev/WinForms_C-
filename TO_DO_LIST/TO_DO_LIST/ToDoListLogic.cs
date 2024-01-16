using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO_DO_LIST
{
    [Serializable]
    internal class ToDoListLogic
    {

        private DateTime _date;
        private DateTime _deadline;
        private string _name;
        private string _surname;
        private bool _isAdministrator;
        private bool _isDone;
        private string _taskDescription;


        public DateTime Date { get { return _date; }  }
        public DateTime Deadline { get { return _deadline; } }   
        public string Name { get { return _name; }}
        public string Surname { get { return _surname; } }
        public bool IsAdministrator { get { return _isAdministrator; } }
        public bool IsDone { get { return _isDone; } }
        public string TaskDescription { get { return _taskDescription; }}

        public ToDoListLogic(string name, string surname, DateTime date,DateTime deadline ,string taskDescription ,bool isDone = false, bool isAdministrator = false)
        {
            this._name = name;
            this._surname = surname;
            this._date = date;
            this._taskDescription = taskDescription; 
            this._isDone = isDone;
            this._isAdministrator = isAdministrator;
            this._deadline = deadline;
        }

        public ToDoListLogic() { }



    }
}
