namespace RectangleLabs
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonViewComment = new System.Windows.Forms.Button();
            this.labelComments = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectanglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ellipsesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonEllips = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(518, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(577, 177);
            this.textBox1.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(518, 246);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(258, 102);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить комментарий";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonViewComment
            // 
            this.buttonViewComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewComment.Location = new System.Drawing.Point(806, 246);
            this.buttonViewComment.Name = "buttonViewComment";
            this.buttonViewComment.Size = new System.Drawing.Size(289, 102);
            this.buttonViewComment.TabIndex = 2;
            this.buttonViewComment.Text = "Список комментариев";
            this.buttonViewComment.UseVisualStyleBackColor = true;
            this.buttonViewComment.Click += new System.EventHandler(this.buttonViewComment_Click);
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComments.Location = new System.Drawing.Point(520, 370);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(187, 31);
            this.labelComments.TabIndex = 3;
            this.labelComments.Text = "Комментарии";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrawingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1152, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newDrawingToolStripMenuItem
            // 
            this.newDrawingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectanglesToolStripMenuItem,
            this.toolStripSeparator1,
            this.ellipsesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newDrawingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.newDrawingToolStripMenuItem.Name = "newDrawingToolStripMenuItem";
            this.newDrawingToolStripMenuItem.Size = new System.Drawing.Size(136, 29);
            this.newDrawingToolStripMenuItem.Text = "New drawing";
            this.newDrawingToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // rectanglesToolStripMenuItem
            // 
            this.rectanglesToolStripMenuItem.Name = "rectanglesToolStripMenuItem";
            this.rectanglesToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.rectanglesToolStripMenuItem.Text = "Rectangles";
            this.rectanglesToolStripMenuItem.Click += new System.EventHandler(this.rectanglesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // ellipsesToolStripMenuItem
            // 
            this.ellipsesToolStripMenuItem.Name = "ellipsesToolStripMenuItem";
            this.ellipsesToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.ellipsesToolStripMenuItem.Text = "Ellipses";
            this.ellipsesToolStripMenuItem.Click += new System.EventHandler(this.ellipsesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonEllips
            // 
            this.buttonEllips.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEllips.Location = new System.Drawing.Point(30, 564);
            this.buttonEllips.Name = "buttonEllips";
            this.buttonEllips.Size = new System.Drawing.Size(289, 102);
            this.buttonEllips.TabIndex = 2;
            this.buttonEllips.Text = "Покрасить Эллипсы";
            this.buttonEllips.UseVisualStyleBackColor = true;
            this.buttonEllips.Click += new System.EventHandler(this.buttonEllips_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 733);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.buttonEllips);
            this.Controls.Add(this.buttonViewComment);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonViewComment;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newDrawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem rectanglesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipsesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonEllips;
    }
}

