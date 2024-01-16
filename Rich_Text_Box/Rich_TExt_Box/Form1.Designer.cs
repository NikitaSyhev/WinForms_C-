namespace Rich_TExt_Box
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
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.usualFont = new System.Windows.Forms.Button();
            this.boldFont = new System.Windows.Forms.Button();
            this.italicsFont = new System.Windows.Forms.Button();
            this.textSize = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(29, 43);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(396, 395);
            this.RichTextBox.TabIndex = 0;
            this.RichTextBox.Text = "";
            // 
            // usualFont
            // 
            this.usualFont.Location = new System.Drawing.Point(431, 43);
            this.usualFont.Name = "usualFont";
            this.usualFont.Size = new System.Drawing.Size(75, 23);
            this.usualFont.TabIndex = 1;
            this.usualFont.Text = "Обычный";
            this.usualFont.UseVisualStyleBackColor = true;
            this.usualFont.MouseClick += new System.Windows.Forms.MouseEventHandler(this.typeFont_MouseClick);
            // 
            // boldFont
            // 
            this.boldFont.Location = new System.Drawing.Point(431, 72);
            this.boldFont.Name = "boldFont";
            this.boldFont.Size = new System.Drawing.Size(75, 23);
            this.boldFont.TabIndex = 2;
            this.boldFont.Text = "Жирный";
            this.boldFont.UseVisualStyleBackColor = true;
            this.boldFont.MouseClick += new System.Windows.Forms.MouseEventHandler(this.typeFont_MouseClick);
            // 
            // italicsFont
            // 
            this.italicsFont.Location = new System.Drawing.Point(431, 101);
            this.italicsFont.Name = "italicsFont";
            this.italicsFont.Size = new System.Drawing.Size(75, 23);
            this.italicsFont.TabIndex = 3;
            this.italicsFont.Text = "Курсив";
            this.italicsFont.UseVisualStyleBackColor = true;
            this.italicsFont.MouseClick += new System.Windows.Forms.MouseEventHandler(this.typeFont_MouseClick);
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(542, 75);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(100, 20);
            this.textSize.TabIndex = 4;
            this.textSize.TextChanged += new System.EventHandler(this.textSize_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(542, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Размер шрифта";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(688, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Выбор цвета";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(431, 338);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(153, 37);
            this.Open.TabIndex = 7;
            this.Open.Text = "Открыть";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OpenButton_MouseClick);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(646, 338);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(153, 37);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button7_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьToolStripMenuItem.Text = "Open Form";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textSize);
            this.Controls.Add(this.italicsFont);
            this.Controls.Add(this.boldFont);
            this.Controls.Add(this.usualFont);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Button usualFont;
        private System.Windows.Forms.Button boldFont;
        private System.Windows.Forms.Button italicsFont;
        private System.Windows.Forms.TextBox textSize;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
    }
}

