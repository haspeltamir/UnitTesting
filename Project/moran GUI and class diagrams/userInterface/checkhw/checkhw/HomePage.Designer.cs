namespace checkhw
{
    partial class HomePage
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chooseInput = new System.Windows.Forms.Label();
            this.file_url = new System.Windows.Forms.TextBox();
            this.output_url = new System.Windows.Forms.TextBox();
            this.chooseOutput = new System.Windows.Forms.Label();
            this.students_url = new System.Windows.Forms.TextBox();
            this.chooseStudents = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lang_C = new System.Windows.Forms.RadioButton();
            this.lang_J = new System.Windows.Forms.RadioButton();
            this.lang_P = new System.Windows.Forms.RadioButton();
            this.output_btn = new FontAwesome.Sharp.IconButton();
            this.students_btn = new FontAwesome.Sharp.IconButton();
            this.next_btn = new FontAwesome.Sharp.IconButton();
            this.input_btn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Input";
            // 
            // chooseInput
            // 
            this.chooseInput.AutoSize = true;
            this.chooseInput.BackColor = System.Drawing.Color.Transparent;
            this.chooseInput.Font = new System.Drawing.Font("Dubai", 12F);
            this.chooseInput.Location = new System.Drawing.Point(396, 159);
            this.chooseInput.Name = "chooseInput";
            this.chooseInput.Size = new System.Drawing.Size(154, 34);
            this.chooseInput.TabIndex = 2;
            this.chooseInput.Text = "Choose input file:";
            // 
            // file_url
            // 
            this.file_url.Cursor = System.Windows.Forms.Cursors.Default;
            this.file_url.Location = new System.Drawing.Point(583, 163);
            this.file_url.Name = "file_url";
            this.file_url.Size = new System.Drawing.Size(125, 27);
            this.file_url.TabIndex = 3;
            // 
            // output_url
            // 
            this.output_url.Cursor = System.Windows.Forms.Cursors.Default;
            this.output_url.Location = new System.Drawing.Point(583, 239);
            this.output_url.Name = "output_url";
            this.output_url.Size = new System.Drawing.Size(125, 27);
            this.output_url.TabIndex = 6;
            // 
            // chooseOutput
            // 
            this.chooseOutput.AutoSize = true;
            this.chooseOutput.BackColor = System.Drawing.Color.Transparent;
            this.chooseOutput.Font = new System.Drawing.Font("Dubai", 12F);
            this.chooseOutput.Location = new System.Drawing.Point(396, 235);
            this.chooseOutput.Name = "chooseOutput";
            this.chooseOutput.Size = new System.Drawing.Size(166, 34);
            this.chooseOutput.TabIndex = 5;
            this.chooseOutput.Text = "Choose output file:";
            // 
            // students_url
            // 
            this.students_url.Cursor = System.Windows.Forms.Cursors.Default;
            this.students_url.Location = new System.Drawing.Point(583, 317);
            this.students_url.Name = "students_url";
            this.students_url.Size = new System.Drawing.Size(125, 27);
            this.students_url.TabIndex = 9;
            // 
            // chooseStudents
            // 
            this.chooseStudents.AutoSize = true;
            this.chooseStudents.BackColor = System.Drawing.Color.Transparent;
            this.chooseStudents.Font = new System.Drawing.Font("Dubai", 12F);
            this.chooseStudents.Location = new System.Drawing.Point(396, 313);
            this.chooseStudents.Name = "chooseStudents";
            this.chooseStudents.Size = new System.Drawing.Size(181, 34);
            this.chooseStudents.TabIndex = 8;
            this.chooseStudents.Text = "Choose students file:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Colonna MT", 48F);
            this.title.Location = new System.Drawing.Point(173, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(437, 85);
            this.title.TabIndex = 11;
            this.title.Text = "HW Testing";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.BackColor = System.Drawing.Color.Transparent;
            this.chooseLabel.Font = new System.Drawing.Font("Dubai", 12F);
            this.chooseLabel.Location = new System.Drawing.Point(27, 148);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(272, 34);
            this.chooseLabel.TabIndex = 12;
            this.chooseLabel.Text = "Choose programming language: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::checkhw.Properties.Resources.c_original_logo_icon_146611;
            this.pictureBox1.Location = new System.Drawing.Point(59, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::checkhw.Properties.Resources.java_original_wordmark_logo_icon_146459;
            this.pictureBox2.Location = new System.Drawing.Point(51, 275);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::checkhw.Properties.Resources.python_vertical_logo_icon_168039;
            this.pictureBox3.Location = new System.Drawing.Point(59, 359);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // lang_C
            // 
            this.lang_C.AutoSize = true;
            this.lang_C.BackColor = System.Drawing.Color.Transparent;
            this.lang_C.Location = new System.Drawing.Point(35, 219);
            this.lang_C.Name = "lang_C";
            this.lang_C.Size = new System.Drawing.Size(17, 16);
            this.lang_C.TabIndex = 22;
            this.lang_C.TabStop = true;
            this.lang_C.UseVisualStyleBackColor = false;
            // 
            // lang_J
            // 
            this.lang_J.AutoSize = true;
            this.lang_J.BackColor = System.Drawing.Color.Transparent;
            this.lang_J.Location = new System.Drawing.Point(34, 290);
            this.lang_J.Name = "lang_J";
            this.lang_J.Size = new System.Drawing.Size(17, 16);
            this.lang_J.TabIndex = 23;
            this.lang_J.TabStop = true;
            this.lang_J.UseVisualStyleBackColor = false;
            // 
            // lang_P
            // 
            this.lang_P.AutoSize = true;
            this.lang_P.BackColor = System.Drawing.Color.Transparent;
            this.lang_P.Location = new System.Drawing.Point(35, 370);
            this.lang_P.Name = "lang_P";
            this.lang_P.Size = new System.Drawing.Size(17, 16);
            this.lang_P.TabIndex = 24;
            this.lang_P.TabStop = true;
            this.lang_P.UseVisualStyleBackColor = false;
            // 
            // output_btn
            // 
            this.output_btn.BackColor = System.Drawing.Color.Transparent;
            this.output_btn.FlatAppearance.BorderSize = 0;
            this.output_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.output_btn.ForeColor = System.Drawing.Color.Transparent;
            this.output_btn.IconChar = FontAwesome.Sharp.IconChar.CloudArrowUp;
            this.output_btn.IconColor = System.Drawing.Color.Black;
            this.output_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.output_btn.Location = new System.Drawing.Point(718, 233);
            this.output_btn.Name = "output_btn";
            this.output_btn.Size = new System.Drawing.Size(54, 39);
            this.output_btn.TabIndex = 25;
            this.output_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.output_btn.UseVisualStyleBackColor = false;
            this.output_btn.Click += new System.EventHandler(this.output_btn_Click);
            // 
            // students_btn
            // 
            this.students_btn.BackColor = System.Drawing.Color.Transparent;
            this.students_btn.FlatAppearance.BorderSize = 0;
            this.students_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.students_btn.ForeColor = System.Drawing.Color.Transparent;
            this.students_btn.IconChar = FontAwesome.Sharp.IconChar.CloudArrowUp;
            this.students_btn.IconColor = System.Drawing.Color.Black;
            this.students_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.students_btn.Location = new System.Drawing.Point(718, 311);
            this.students_btn.Name = "students_btn";
            this.students_btn.Size = new System.Drawing.Size(54, 39);
            this.students_btn.TabIndex = 26;
            this.students_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.students_btn.UseVisualStyleBackColor = false;
            this.students_btn.Click += new System.EventHandler(this.students_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.Transparent;
            this.next_btn.FlatAppearance.BorderSize = 0;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.ForeColor = System.Drawing.Color.Transparent;
            this.next_btn.IconChar = FontAwesome.Sharp.IconChar.AnglesDown;
            this.next_btn.IconColor = System.Drawing.Color.Black;
            this.next_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.next_btn.Location = new System.Drawing.Point(727, 392);
            this.next_btn.Name = "next_btn";
            this.next_btn.Rotation = 270D;
            this.next_btn.Size = new System.Drawing.Size(61, 39);
            this.next_btn.TabIndex = 27;
            this.next_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // input_btn
            // 
            this.input_btn.BackColor = System.Drawing.Color.Transparent;
            this.input_btn.FlatAppearance.BorderSize = 0;
            this.input_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_btn.ForeColor = System.Drawing.Color.Transparent;
            this.input_btn.IconChar = FontAwesome.Sharp.IconChar.CloudArrowUp;
            this.input_btn.IconColor = System.Drawing.Color.Black;
            this.input_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.input_btn.Location = new System.Drawing.Point(718, 157);
            this.input_btn.Name = "input_btn";
            this.input_btn.Size = new System.Drawing.Size(54, 39);
            this.input_btn.TabIndex = 15;
            this.input_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.input_btn.UseVisualStyleBackColor = false;
            this.input_btn.Click += new System.EventHandler(this.input_btn_Click);
            this.input_btn.Paint += new System.Windows.Forms.PaintEventHandler(this.input_btn_Paint);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.students_btn);
            this.Controls.Add(this.output_btn);
            this.Controls.Add(this.lang_P);
            this.Controls.Add(this.lang_J);
            this.Controls.Add(this.lang_C);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.input_btn);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.students_url);
            this.Controls.Add(this.chooseStudents);
            this.Controls.Add(this.output_url);
            this.Controls.Add(this.chooseOutput);
            this.Controls.Add(this.file_url);
            this.Controls.Add(this.chooseInput);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HomePage_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label chooseInput;
        private System.Windows.Forms.TextBox file_url;
        private System.Windows.Forms.TextBox output_url;
        private System.Windows.Forms.Label chooseOutput;
        private System.Windows.Forms.TextBox students_url;
        private System.Windows.Forms.Label chooseStudents;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton lang_C;
        private System.Windows.Forms.RadioButton lang_J;
        private System.Windows.Forms.RadioButton lang_P;
        private FontAwesome.Sharp.IconButton output_btn;
        private FontAwesome.Sharp.IconButton students_btn;
        private FontAwesome.Sharp.IconButton next_btn;
        private FontAwesome.Sharp.IconButton input_btn;
    }
}