using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace XMLSerialisation
{
    public partial class Form1 : Form

    {
        List<Students> students = new List<Students>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int _number;
            string _name, _surname, _patronimic;
            _number = Convert.ToInt32(number.Text);
            _name = Convert.ToString(name.Text);
            _surname = Convert.ToString(surname.Text);
            _patronimic = Convert.ToString(patronimic.Text);
            DateTime _birthday = dateAdd();
            addStudentToLIST(_number, _name, _surname, _patronimic, _birthday);
            listStudents.Items.Add(_surname);
        }

        private void addStudentToLIST(int number, string name, string surname, string patronimic, DateTime date)
        {
            Students student = new Students(number, name,surname,patronimic,date);
            students.Add(student);
        }

        private DateTime dateAdd()
        {
            string inputDate = birthday.Text; // Получаем введенную дату из MaskedTextBox
            string dateFormat = "dd/MM/yyyy";
            DateTime parsedDate;
            DateTime.TryParseExact(inputDate, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);
            return parsedDate;

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int parsedNumber = Convert.ToInt32(deleteStudent.Text);
            int _number = parsedNumber - 1;
            students.RemoveAt(_number);
        }

        private void saveToXml(string path = "students.xml")
        {
            Students.Serealize_it(students, path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveToXml();
        }
    }
}
