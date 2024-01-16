using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TO_DO_LIST
{
    public partial class Form1 : Form
    {

       private List<ToDoListLogic> taskList = new List<ToDoListLogic>(); // List для хранения объектов класса
        List<ToDoListLogic> loadedTasks = new List<ToDoListLogic>(); // List для чтения из файла
        private List<TextBox> numbers = new List<TextBox>();
        private string name = string.Empty;
        private string surname = string.Empty;
        private DateTime date = DateTime.Now;
        private string taskDescription = string.Empty;
        private int counterTask = 1;
        private bool isDone;
        private DateTime deadline;


        public Form1()
        {
            InitializeComponent();
            addToList(); // добавили в список
            addNumbersToTasks();
            isDone = false;
            MessageBox.Show("Указывайте имя, фамилию, записывайте задачу. После этого нажимайте кнопку Add в строке с задачей");
            loadedTasks = LoadTasks("tasks.txt"); // этот метод нам вернул список задач
            initialisation(loadedTasks);

        }

        private void initialisation(List<ToDoListLogic> tasks)
        {

                for (int i = 0; i < tasks.Count; i++)
                {
                    textBox5.Text = tasks[0].Name.ToString();
                    textBox6.Text = tasks[0].Surname.ToString();
                    textBox8.Text = tasks[0].Date.ToString();
                    dateTimePicker1.Text = tasks[0].Deadline.ToString();
                    textBox4.Text = tasks[0].TaskDescription.ToString();
                    checkBox1.Checked = tasks[0].IsDone;
                textBox9.Text = tasks[1].Name.ToString();
                textBox10.Text = tasks[1].Surname.ToString();
                textBox12.Text = tasks[1].Date.ToString();
                dateTimePicker2.Text = tasks[1].Deadline.ToString();
                textBox19.Text = tasks[1].TaskDescription.ToString();
                checkBox3.Checked = tasks[1].IsDone;

            }
           
         
        }

        private void SaveTasks(string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Append))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, taskList);
            }

        }
        private List<ToDoListLogic> LoadTasks(string fileName)
        { 

            if (File.Exists(fileName))
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    loadedTasks = (List<ToDoListLogic>)formatter.Deserialize(fileStream);
                }
            }
            return loadedTasks;
           
        }

        private void addToList()
        {
            numbers.Add(textBox11);
            numbers.Add(textBox23);
            numbers.Add(textBox42);
            numbers.Add(textBox45);
            numbers.Add(textBox48);
            numbers.Add(textBox51);
            numbers.Add(textBox54);
            numbers.Add(textBox57);
            numbers.Add(textBox60);
            numbers.Add(textBox63);
            numbers.Add(textBox66);
        }


        private void DeadLineRed(DateTimePicker date)
        {
            if(date.Value <= DateTime.Now)
            {
                date.BackColor = Color.Red;
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.BlanchedAlmond;
            DeadLineRed(dateTimePicker1);
            DeadLineRed(dateTimePicker2);
            DeadLineRed(dateTimePicker3);
            DeadLineRed(dateTimePicker4);
            DeadLineRed(dateTimePicker5);
            DeadLineRed(dateTimePicker6);
            DeadLineRed(dateTimePicker7);
            DeadLineRed(dateTimePicker8);
            DeadLineRed(dateTimePicker9);
            DeadLineRed(dateTimePicker10);
            DeadLineRed(dateTimePicker11);
           
        }

        private void addNumbersToTasks()
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i].Text = counterTask.ToString();
                counterTask++;
            }
        }

        private void createTask(string name, string surname, DateTime date,DateTime deadline , string taskDescription, bool isDine = false)
        {
            var task = new ToDoListLogic(name, surname, date ,deadline ,taskDescription);
            taskList.Add(task);
            SaveTasks("tasks.txt");
        }
       


        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            name = textBox5.Text.ToString();
            surname= textBox6.Text.ToString();
            date= DateTime.Now;
            textBox8.Text = date.ToString();
            taskDescription = textBox4.Text.ToString();
            deadline = dateTimePicker1.Value;
            
            if(checkBox1.Checked)
            {
                isDone = true;
            }
            createTask(name, surname, date, deadline, taskDescription, isDone);

        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            name = textBox9.Text.ToString();
            surname = textBox10.Text.ToString();
            date = DateTime.Now;
            textBox12.Text = date.ToString();
            taskDescription = textBox19.Text.ToString();
            deadline = dateTimePicker2.Value;

            if (checkBox3.Checked)
            {
                isDone = true;
            }
            createTask(name, surname, date, deadline, taskDescription, isDone);

        }

        private void buttonAdd3_Click(object sender, EventArgs e)
        {
            name = textBox13.Text.ToString();
            surname = textBox14.Text.ToString();
            date = DateTime.Now;
            textBox16.Text = date.ToString();
            taskDescription = textBox41.Text.ToString();
            deadline = dateTimePicker3.Value;

            if (checkBox4.Checked)
            {
                isDone = true;
            }
            createTask(name, surname, date, deadline, taskDescription, isDone);

        }

        private void buttonAdd4_Click(object sender, EventArgs e)
        {
            name = textBox17.Text.ToString();
            surname = textBox18.Text.ToString();
            date = DateTime.Now;
            textBox20.Text = date.ToString();
            taskDescription = textBox44.Text.ToString();
            deadline = dateTimePicker4.Value;
            if (checkBox2.Checked)
            {
                isDone = true;
            }
            createTask(name, surname, date, deadline, taskDescription, isDone);

        }

        private void buttonAdd5_Click(object sender, EventArgs e)
        {
            name = textBox21.Text.ToString();
            surname = textBox22.Text.ToString();
            date = DateTime.Now;
            textBox24.Text = date.ToString();
            taskDescription = textBox47.Text.ToString();
            deadline = dateTimePicker5.Value;
            if (checkBox5.Checked)
            {
                isDone = true;
            }
            createTask(name, surname, date, deadline, taskDescription, isDone);

        }

        private void buttonAdd6_Click(object sender, EventArgs e)


        {
            name = textBox25.Text.ToString();
            surname = textBox26.Text.ToString();
            date = DateTime.Now;
            textBox28.Text = date.ToString();
            taskDescription = textBox50.Text.ToString();
            deadline = dateTimePicker6.Value;
            if (checkBox6.Checked)
            {
                isDone = true;
            }
            createTask(name, surname, date, deadline, taskDescription, isDone);
        }

      

        private void buttonAdd7_Click(object sender, EventArgs e)
        {
            name = textBox29.Text.ToString();
            surname = textBox30.Text.ToString();
            date = DateTime.Now;
            textBox31.Text = date.ToString();
            taskDescription = textBox53.Text.ToString();
            deadline = dateTimePicker7.Value;
            if (checkBox7.Checked)
            {
                isDone = true;
            }
            createTask(name, surname, date, deadline, taskDescription, isDone);
        }

        private void buttonAdd8_Click(object sender, EventArgs e)
        {
            name = textBox33.Text.ToString();
            surname = textBox34.Text.ToString();
            date = DateTime.Now;
            textBox36.Text = date.ToString();
            taskDescription = textBox56.Text.ToString();
            deadline = dateTimePicker8.Value;
            if (checkBox8.Checked)
            {
                isDone = true;
            }
            createTask(name, surname, date, deadline, taskDescription, isDone);
        }

        private void buttonAdd9_Click(object sender, EventArgs e)
        {
            name = textBox37.Text.ToString();
            surname = textBox38.Text.ToString();
            date = DateTime.Now;
            textBox40.Text = date.ToString();
            taskDescription = textBox59.Text.ToString();
            deadline = dateTimePicker9.Value;
            if (checkBox9.Checked)
            {
                isDone = true;
            }
            createTask(name, surname, date, deadline, taskDescription, isDone);

        }

        private void buttonAdd10_Click(object sender, EventArgs e)
        {
            name = textBox1.Text.ToString();
            surname = textBox2.Text.ToString();
            date = DateTime.Now;
            textBox7.Text = date.ToString();
            taskDescription = textBox62.Text.ToString();
            deadline = dateTimePicker10.Value;
            if (checkBox10.Checked)
            {
                isDone = true;
            }
            createTask(name, surname, date, deadline, taskDescription, isDone);

        }

        private void buttonAdd11_Click(object sender, EventArgs e)
        {
            name = textBox27.Text.ToString();
            surname = textBox32.Text.ToString();
            date = DateTime.Now;
            textBox39.Text = date.ToString();
            taskDescription = textBox65.Text.ToString();
            deadline = dateTimePicker11.Value;
            if (checkBox11.Checked)
            {
                isDone = true;
            }
            createTask(name, surname, date, deadline, taskDescription, isDone);

        }
    }
}
