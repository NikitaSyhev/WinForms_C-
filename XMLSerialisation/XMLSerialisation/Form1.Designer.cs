namespace XMLSerialisation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.patronimic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.MaskedTextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.listStudents = new System.Windows.Forms.ListBox();
            this.deleteStudent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(214, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Классный журнал";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(12, 113);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 20);
            this.number.TabIndex = 1;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(12, 162);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(100, 20);
            this.surname.TabIndex = 2;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 216);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 3;
            // 
            // patronimic
            // 
            this.patronimic.Location = new System.Drawing.Point(12, 265);
            this.patronimic.Name = "patronimic";
            this.patronimic.Size = new System.Drawing.Size(100, 20);
            this.patronimic.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "дата рождения";
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(12, 320);
            this.birthday.Mask = "00/00/0000";
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(100, 20);
            this.birthday.TabIndex = 10;
            this.birthday.ValidatingType = typeof(System.DateTime);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(201, 113);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(84, 76);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(201, 272);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(84, 76);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // listStudents
            // 
            this.listStudents.FormattingEnabled = true;
            this.listStudents.Location = new System.Drawing.Point(502, 113);
            this.listStudents.Name = "listStudents";
            this.listStudents.Size = new System.Drawing.Size(120, 95);
            this.listStudents.TabIndex = 13;
            // 
            // deleteStudent
            // 
            this.deleteStudent.Location = new System.Drawing.Point(300, 320);
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(157, 20);
            this.deleteStudent.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Номер студента для удаления";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 82);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save To XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deleteStudent);
            this.Controls.Add(this.listStudents);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patronimic);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox patronimic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox birthday;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ListBox listStudents;
        private System.Windows.Forms.TextBox deleteStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

