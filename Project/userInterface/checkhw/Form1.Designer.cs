namespace checkhw
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
            this.langList = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Browse_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filetext = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Next_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // langList
            // 
            this.langList.FormattingEnabled = true;
            this.langList.Items.AddRange(new object[] {
            "C",
            "JAVA",
            "PYTHON"});
            this.langList.Location = new System.Drawing.Point(27, 185);
            this.langList.Name = "langList";
            this.langList.Size = new System.Drawing.Size(259, 28);
            this.langList.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Input";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Browse_btn
            // 
            this.Browse_btn.Location = new System.Drawing.Point(670, 156);
            this.Browse_btn.Name = "Browse_btn";
            this.Browse_btn.Size = new System.Drawing.Size(94, 29);
            this.Browse_btn.TabIndex = 1;
            this.Browse_btn.Text = "Browse";
            this.Browse_btn.UseVisualStyleBackColor = true;
            this.Browse_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(342, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose input file:";
            // 
            // filetext
            // 
            this.filetext.Location = new System.Drawing.Point(525, 158);
            this.filetext.Name = "filetext";
            this.filetext.Size = new System.Drawing.Size(125, 27);
            this.filetext.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(525, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(342, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose output file:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(525, 311);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(342, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choose students file:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Next_btn
            // 
            this.Next_btn.Location = new System.Drawing.Point(670, 379);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(94, 45);
            this.Next_btn.TabIndex = 10;
            this.Next_btn.Text = "Next";
            this.Next_btn.UseVisualStyleBackColor = true;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Colonna MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(173, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 85);
            this.label4.TabIndex = 11;
            this.label4.Text = "HW Testing";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(27, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 34);
            this.label5.TabIndex = 12;
            this.label5.Text = "Choose programming language: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Next_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filetext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Browse_btn);
            this.Controls.Add(this.langList);
            this.Name = "Form1";
            this.Text = "Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox langList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Browse_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filetext;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
