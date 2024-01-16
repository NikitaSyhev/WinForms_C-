namespace ScrollBars_HW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Horizont = new System.Windows.Forms.TextBox();
            this.TextBox_Scroll = new System.Windows.Forms.HScrollBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Picture_ScrollBar = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Picture_ScrollBar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TextBox_Scroll);
            this.panel1.Controls.Add(this.textBox_Horizont);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 448);
            this.panel1.TabIndex = 0;
            // 
            // textBox_Horizont
            // 
            this.textBox_Horizont.Location = new System.Drawing.Point(0, 0);
            this.textBox_Horizont.Multiline = true;
            this.textBox_Horizont.Name = "textBox_Horizont";
            this.textBox_Horizont.Size = new System.Drawing.Size(98, 50);
            this.textBox_Horizont.TabIndex = 0;
            // 
            // TextBox_Scroll
            // 
            this.TextBox_Scroll.Location = new System.Drawing.Point(0, 431);
            this.TextBox_Scroll.Name = "TextBox_Scroll";
            this.TextBox_Scroll.Size = new System.Drawing.Size(164, 17);
            this.TextBox_Scroll.TabIndex = 1;
            this.TextBox_Scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TextBox_Scroll_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 112);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 102);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TEXT_BOX";
            // 
            // Picture_ScrollBar
            // 
            this.Picture_ScrollBar.Location = new System.Drawing.Point(55, 378);
            this.Picture_ScrollBar.Name = "Picture_ScrollBar";
            this.Picture_ScrollBar.Size = new System.Drawing.Size(158, 17);
            this.Picture_ScrollBar.TabIndex = 5;
            this.Picture_ScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Picture_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "PICTURE_BOX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar TextBox_Scroll;
        private System.Windows.Forms.TextBox textBox_Horizont;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar Picture_ScrollBar;
        private System.Windows.Forms.Label label1;
    }
}

