namespace Phasmophobia_Troll_Menu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            checkBox2 = new CheckBox();
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Float (Beta)";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 62);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "is the game open: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 62);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Null";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 37);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(113, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Freeze Character";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(162, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 118);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(14, 72);
            button1.Name = "button1";
            button1.Size = new Size(119, 31);
            button1.TabIndex = 2;
            button1.Text = "Set";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 43);
            textBox1.MaxLength = 5;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 23);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 20);
            label3.Name = "label3";
            label3.Size = new Size(119, 21);
            label3.TabIndex = 0;
            label3.Text = "Basketball Point";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(2, 84);
            label4.Name = "label4";
            label4.Size = new Size(168, 17);
            label4.TabIndex = 5;
            label4.Text = "Made By: Erenn#6859";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 110);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(checkBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Phasmophobia Troll Menu";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private CheckBox checkBox2;
        private Panel panel1;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private Label label4;
    }
}