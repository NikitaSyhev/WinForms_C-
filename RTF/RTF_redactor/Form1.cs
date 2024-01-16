using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTF_redactor
{
    public partial class Form1 : Form
    {

        private List<string> recentFiles = new List<string>(); // список редактивруемых файлов
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();

        }
        Form2 form2;

        private void FormTheme(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            bool isDay = currentTime.Hour >= 6 & currentTime.Hour <= 18;
            if (isDay)
            {
                BackColor = Color.White;
                ForeColor = Color.Black;

            }
            else
            {
                BackColor = Color.Black;
                ForeColor = Color.Red;

            }
        }

        private void openBtn_MouseClick(object sender, MouseEventArgs e)
        {
            string result = OpenFile();
            if (result != "none")
            {
                TextBox.LoadFile(result);
                
              
            }

        }
        
        private string OpenFile()
        {
            using (OpenFileDialog of = new OpenFileDialog())
            {
                of.Filter = "RTF files (*.rtf)|*.rtf";
                of.InitialDirectory = Environment.CurrentDirectory;

                if (of.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = of.FileName;
                    AddFileToHistory(selectedFile);
                    return of.FileName;
                   
                }
            }
            return "none";
        }
        private void AddFileToHistory(string filePath)
        {
            
            if (!recentFiles.Contains(filePath))
            {
                recentFiles.Insert(0, filePath);
            }
            if (recentFiles.Count > 150)
            {
                recentFiles.RemoveAt(recentFiles.Count - 1);
            }

        }
         private void typeFont_MouseClick(object sender, MouseEventArgs e)
        {
            var defaulFont = TextBox.Font;
            if (TextBox.SelectedText != null) // работает если мы выделили текст
            {
                if (((Button)sender).Text == "Жирный")
                {

                    TextBox.SelectionFont = new Font(defaulFont.FontFamily,
                        defaulFont.Size, FontStyle.Bold);

                }
                if (((Button)sender).Text == "Подчеркнутый")
                {

                    TextBox.SelectionFont = new Font(defaulFont.FontFamily,
                        defaulFont.Size, FontStyle.Underline);

                }
                else
                {
                    if (((Button)sender).Text == "Курсив")
                    {
                        TextBox.SelectionFont = new Font(defaulFont.FontFamily,
                        defaulFont.Size, FontStyle.Italic);
                    }
                    else
                    {
                        TextBox.SelectionFont = new Font(defaulFont.FontFamily,
                        defaulFont.Size, FontStyle.Regular);
                    }
                }

            }
        }

        private void textSize_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int SizeText = Convert.ToInt32(textBox.Text);
            var defaulFont = TextBox.Size;
            if (TextBox.SelectedText != null)
            {

                TextBox.SelectionFont = new Font(TextBox.SelectionFont.FontFamily, SizeText, TextBox.SelectionFont.Style);
            }
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            TextBox.SelectionColor = colorDialog.Color;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveFile()
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Сохранить как...";
            sf.OverwritePrompt = true;
            sf.CheckFileExists = true;
            sf.Filter = "RTF Files | *.rtf";
            sf.ShowHelp = true;
            if (sf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedFile = sf.FileName;
                    AddFileToHistory(selectedFile);
                    TextBox.SaveFile(sf.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
        }
       private Image openPicture()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Файлы изображений (*.bmp; *.jpg; *.jpeg; *.png; *.gif)|*.bmp; *.jpg; *.jpeg; *.png; *.gif";
            openFileDialog.Title = "Открыть файл изображения";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string imagePath = openFileDialog.FileName;
                Image image = Image.FromFile(imagePath);

                return image;
            }
            else return null;   
        }

        private void backgroundBtn_Click(object sender, EventArgs e)
        {
            Image backGround = openPicture();
            this.BackgroundImage = backGround;
        }

        private void buttonFontType_MouseClick(object sender, MouseEventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font newFont = new Font(fontDialog.Font.FontFamily, TextBox.Font.Size, TextBox.Font.Style);
                TextBox.SelectionFont = fontDialog.Font;
            }
        }

        private void openHistory_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Все файлы|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                if (recentFiles.Contains(selectedFilePath))
                {
                    MessageBox.Show("Выбран файл: " + selectedFilePath);
                }
                else
                {
                    MessageBox.Show("Файл не найден в списке недавних файлов.");
                }
            }

        }

        private void bufferForm_Click(object sender, EventArgs e)
        {
            
            form2.Show();
            
        }
    }
 
}
