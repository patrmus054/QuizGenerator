namespace Quiz
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
            this.btCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbQuizType = new System.Windows.Forms.ComboBox();
            this.textboxTitle = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btRemove = new System.Windows.Forms.PictureBox();
            this.btAdd = new System.Windows.Forms.PictureBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(887, 655);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(115, 60);
            this.btCreate.TabIndex = 0;
            this.btCreate.Tag = "";
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cbQuizType);
            this.panel1.Controls.Add(this.textboxTitle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 195);
            this.panel1.TabIndex = 1;
            // 
            // cbQuizType
            // 
            this.cbQuizType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbQuizType.FormattingEnabled = true;
            this.cbQuizType.Location = new System.Drawing.Point(28, 102);
            this.cbQuizType.Name = "cbQuizType";
            this.cbQuizType.Size = new System.Drawing.Size(913, 33);
            this.cbQuizType.TabIndex = 2;
            // 
            // textboxTitle
            // 
            this.textboxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxTitle.Location = new System.Drawing.Point(28, 23);
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textboxTitle.Size = new System.Drawing.Size(913, 36);
            this.textboxTitle.TabIndex = 1;
            this.textboxTitle.Text = "      Title";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkCyan;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 213);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(990, 436);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.btRemove);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Location = new System.Drawing.Point(877, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 436);
            this.panel2.TabIndex = 0;
            // 
            // btRemove
            // 
            this.btRemove.Image = ((System.Drawing.Image)(resources.GetObject("btRemove.Image")));
            this.btRemove.Location = new System.Drawing.Point(32, 141);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(67, 59);
            this.btRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btRemove.TabIndex = 1;
            this.btRemove.TabStop = false;
            this.btRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // btAdd
            // 
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.Location = new System.Drawing.Point(32, 26);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(67, 59);
            this.btAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btAdd.TabIndex = 0;
            this.btAdd.TabStop = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(830, 556);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(172, 93);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 727);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbQuizType;
        private System.Windows.Forms.RichTextBox textboxTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btRemove;
        private System.Windows.Forms.PictureBox btAdd;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

