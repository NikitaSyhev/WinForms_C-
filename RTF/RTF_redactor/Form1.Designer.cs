namespace RTF_redactor
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
            this.openBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.usualFont = new System.Windows.Forms.Button();
            this.boldFont = new System.Windows.Forms.Button();
            this.italicsFont = new System.Windows.Forms.Button();
            this.sizeBtn = new System.Windows.Forms.Button();
            this.textSize = new System.Windows.Forms.TextBox();
            this.colorBtn = new System.Windows.Forms.Button();
            this.backgroundBtn = new System.Windows.Forms.Button();
            this.underlinedFont = new System.Windows.Forms.Button();
            this.buttonFontType = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.историяФайловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.буферОбменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bufferForm = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(12, 24);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(122, 35);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openBtn_MouseClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 100);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(122, 35);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(372, 20);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(416, 418);
            this.TextBox.TabIndex = 2;
            this.TextBox.Text = "";
            // 
            // usualFont
            // 
            this.usualFont.Location = new System.Drawing.Point(291, 24);
            this.usualFont.Name = "usualFont";
            this.usualFont.Size = new System.Drawing.Size(75, 23);
            this.usualFont.TabIndex = 3;
            this.usualFont.Text = "Обычный";
            this.usualFont.UseVisualStyleBackColor = true;
            this.usualFont.MouseClick += new System.Windows.Forms.MouseEventHandler(this.typeFont_MouseClick);
            // 
            // boldFont
            // 
            this.boldFont.Location = new System.Drawing.Point(291, 53);
            this.boldFont.Name = "boldFont";
            this.boldFont.Size = new System.Drawing.Size(75, 23);
            this.boldFont.TabIndex = 4;
            this.boldFont.Text = "Жирный";
            this.boldFont.UseVisualStyleBackColor = true;
            this.boldFont.MouseClick += new System.Windows.Forms.MouseEventHandler(this.typeFont_MouseClick);
            // 
            // italicsFont
            // 
            this.italicsFont.Location = new System.Drawing.Point(291, 83);
            this.italicsFont.Name = "italicsFont";
            this.italicsFont.Size = new System.Drawing.Size(75, 23);
            this.italicsFont.TabIndex = 5;
            this.italicsFont.Text = "Курсив";
            this.italicsFont.UseVisualStyleBackColor = true;
            this.italicsFont.MouseClick += new System.Windows.Forms.MouseEventHandler(this.typeFont_MouseClick);
            // 
            // sizeBtn
            // 
            this.sizeBtn.Location = new System.Drawing.Point(183, 24);
            this.sizeBtn.Name = "sizeBtn";
            this.sizeBtn.Size = new System.Drawing.Size(102, 23);
            this.sizeBtn.TabIndex = 6;
            this.sizeBtn.Text = "Размер шрифта";
            this.sizeBtn.UseVisualStyleBackColor = true;
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(183, 56);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(100, 20);
            this.textSize.TabIndex = 7;
            this.textSize.TextChanged += new System.EventHandler(this.textSize_TextChanged);
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(183, 83);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(102, 23);
            this.colorBtn.TabIndex = 8;
            this.colorBtn.Text = "Выбор цвета";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // backgroundBtn
            // 
            this.backgroundBtn.Location = new System.Drawing.Point(12, 403);
            this.backgroundBtn.Name = "backgroundBtn";
            this.backgroundBtn.Size = new System.Drawing.Size(122, 35);
            this.backgroundBtn.TabIndex = 9;
            this.backgroundBtn.Text = "Картинка для фона";
            this.backgroundBtn.UseVisualStyleBackColor = true;
            this.backgroundBtn.Click += new System.EventHandler(this.backgroundBtn_Click);
            // 
            // underlinedFont
            // 
            this.underlinedFont.Location = new System.Drawing.Point(291, 112);
            this.underlinedFont.Name = "underlinedFont";
            this.underlinedFont.Size = new System.Drawing.Size(75, 23);
            this.underlinedFont.TabIndex = 10;
            this.underlinedFont.Text = "Подчеркнутый";
            this.underlinedFont.UseVisualStyleBackColor = true;
            this.underlinedFont.MouseClick += new System.Windows.Forms.MouseEventHandler(this.typeFont_MouseClick);
            // 
            // buttonFontType
            // 
            this.buttonFontType.Location = new System.Drawing.Point(183, 112);
            this.buttonFontType.Name = "buttonFontType";
            this.buttonFontType.Size = new System.Drawing.Size(102, 23);
            this.buttonFontType.TabIndex = 11;
            this.buttonFontType.Text = "Выбор шрифта";
            this.buttonFontType.UseVisualStyleBackColor = true;
            this.buttonFontType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonFontType_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.историяФайловToolStripMenuItem,
            this.буферОбменаToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 24);
            this.menuStrip3.TabIndex = 14;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // историяФайловToolStripMenuItem
            // 
            this.историяФайловToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openHistory});
            this.историяФайловToolStripMenuItem.Name = "историяФайловToolStripMenuItem";
            this.историяФайловToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.историяФайловToolStripMenuItem.Text = "История файлов";
            // 
            // openHistory
            // 
            this.openHistory.Name = "openHistory";
            this.openHistory.Size = new System.Drawing.Size(121, 22);
            this.openHistory.Text = "Открыть";
            this.openHistory.Click += new System.EventHandler(this.openHistory_Click);
            // 
            // буферОбменаToolStripMenuItem
            // 
            this.буферОбменаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bufferForm});
            this.буферОбменаToolStripMenuItem.Name = "буферОбменаToolStripMenuItem";
            this.буферОбменаToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.буферОбменаToolStripMenuItem.Text = "Буфер обмена";
            // 
            // bufferForm
            // 
            this.bufferForm.Name = "bufferForm";
            this.bufferForm.Size = new System.Drawing.Size(180, 22);
            this.bufferForm.Text = "Открыть";
            this.bufferForm.Click += new System.EventHandler(this.bufferForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFontType);
            this.Controls.Add(this.underlinedFont);
            this.Controls.Add(this.backgroundBtn);
            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.textSize);
            this.Controls.Add(this.sizeBtn);
            this.Controls.Add(this.italicsFont);
            this.Controls.Add(this.boldFont);
            this.Controls.Add(this.usualFont);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormTheme);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button usualFont;
        private System.Windows.Forms.Button boldFont;
        private System.Windows.Forms.Button italicsFont;
        private System.Windows.Forms.Button sizeBtn;
        private System.Windows.Forms.TextBox textSize;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Button backgroundBtn;
        private System.Windows.Forms.Button underlinedFont;
        private System.Windows.Forms.Button buttonFontType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem историяФайловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openHistory;
        private System.Windows.Forms.ToolStripMenuItem буферОбменаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bufferForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

