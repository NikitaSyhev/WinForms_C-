namespace AutorisationExample
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.labelUsers = new System.Windows.Forms.Label();
            this.buttonTestLogin = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.lbConnect = new System.Windows.Forms.Label();
            this.buttonSaveToDB = new System.Windows.Forms.Button();
            this.buttonEntrance = new System.Windows.Forms.Button();
            this.labelRoles = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(28, 43);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(253, 38);
            this.textBoxLogin.TabIndex = 0;
            // 
            // maskedTextBoxPassword
            // 
            this.maskedTextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPassword.Location = new System.Drawing.Point(336, 43);
            this.maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            this.maskedTextBoxPassword.PasswordChar = '*';
            this.maskedTextBoxPassword.Size = new System.Drawing.Size(253, 38);
            this.maskedTextBoxPassword.TabIndex = 1;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUser.Location = new System.Drawing.Point(22, 9);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(88, 31);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "Логин";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassword.Location = new System.Drawing.Point(330, 9);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(108, 31);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Пароль";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddUser.Location = new System.Drawing.Point(630, 79);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(168, 38);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Добавить";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsers.Location = new System.Drawing.Point(624, 227);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(193, 31);
            this.labelUsers.TabIndex = 2;
            this.labelUsers.Text = "Пользователи";
            // 
            // buttonTestLogin
            // 
            this.buttonTestLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTestLogin.Location = new System.Drawing.Point(630, 123);
            this.buttonTestLogin.Name = "buttonTestLogin";
            this.buttonTestLogin.Size = new System.Drawing.Size(168, 38);
            this.buttonTestLogin.TabIndex = 3;
            this.buttonTestLogin.Text = "Проверить";
            this.buttonTestLogin.UseVisualStyleBackColor = true;
            this.buttonTestLogin.Click += new System.EventHandler(this.buttonTestLogin_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(28, 236);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(568, 245);
            this.dataGridViewUsers.TabIndex = 4;
            // 
            // lbConnect
            // 
            this.lbConnect.AutoSize = true;
            this.lbConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbConnect.Location = new System.Drawing.Point(22, 529);
            this.lbConnect.Name = "lbConnect";
            this.lbConnect.Size = new System.Drawing.Size(170, 31);
            this.lbConnect.TabIndex = 2;
            this.lbConnect.Text = "Соединение";
            // 
            // buttonSaveToDB
            // 
            this.buttonSaveToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveToDB.Location = new System.Drawing.Point(28, 182);
            this.buttonSaveToDB.Name = "buttonSaveToDB";
            this.buttonSaveToDB.Size = new System.Drawing.Size(189, 38);
            this.buttonSaveToDB.TabIndex = 3;
            this.buttonSaveToDB.Text = "Обновить БД";
            this.buttonSaveToDB.UseVisualStyleBackColor = true;
            this.buttonSaveToDB.Click += new System.EventHandler(this.buttonSaveToDB_Click);
            // 
            // buttonEntrance
            // 
            this.buttonEntrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEntrance.Location = new System.Drawing.Point(630, 364);
            this.buttonEntrance.Name = "buttonEntrance";
            this.buttonEntrance.Size = new System.Drawing.Size(168, 38);
            this.buttonEntrance.TabIndex = 5;
            this.buttonEntrance.Text = "Войти";
            this.buttonEntrance.UseVisualStyleBackColor = true;
            this.buttonEntrance.Click += new System.EventHandler(this.buttonEntrance_Click);
            // 
            // labelRoles
            // 
            this.labelRoles.AutoSize = true;
            this.labelRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoles.Location = new System.Drawing.Point(22, 86);
            this.labelRoles.Name = "labelRoles";
            this.labelRoles.Size = new System.Drawing.Size(70, 31);
            this.labelRoles.TabIndex = 6;
            this.labelRoles.Text = "Role";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPosition.Location = new System.Drawing.Point(330, 86);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(111, 31);
            this.labelPosition.TabIndex = 7;
            this.labelPosition.Text = "Position";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Administrator",
            "User"});
            this.comboBoxRole.Location = new System.Drawing.Point(28, 120);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(253, 21);
            this.comboBoxRole.TabIndex = 8;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "DIrector",
            "Manager",
            "Worker"});
            this.comboBoxPosition.Location = new System.Drawing.Point(336, 123);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(253, 21);
            this.comboBoxPosition.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 588);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelRoles);
            this.Controls.Add(this.buttonEntrance);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.buttonSaveToDB);
            this.Controls.Add(this.buttonTestLogin);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lbConnect);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.maskedTextBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassword;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Button buttonTestLogin;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label lbConnect;
        private System.Windows.Forms.Button buttonSaveToDB;
        private System.Windows.Forms.Button buttonEntrance;
        private System.Windows.Forms.Label labelRoles;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.ComboBox comboBoxPosition;
    }
}

