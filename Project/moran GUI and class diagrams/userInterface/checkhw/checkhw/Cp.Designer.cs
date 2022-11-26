namespace checkhw
{
    partial class Cp
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
            this.components = new System.ComponentModel.Container();
            this.parameters = new System.Windows.Forms.Label();
            this.similarityBox = new System.Windows.Forms.CheckBox();
            this.idBox = new System.Windows.Forms.CheckBox();
            this.originBox = new System.Windows.Forms.CheckBox();
            this.compilationBox = new System.Windows.Forms.CheckBox();
            this.indentationBox = new System.Windows.Forms.CheckBox();
            this.classBox = new System.Windows.Forms.CheckBox();
            this.variableBox = new System.Windows.Forms.CheckBox();
            this.folder_url = new System.Windows.Forms.TextBox();
            this.saveFolder = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.stateText = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.save_btn = new FontAwesome.Sharp.IconButton();
            this.executeBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start_check_btn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // parameters
            // 
            this.parameters.AutoSize = true;
            this.parameters.BackColor = System.Drawing.Color.Transparent;
            this.parameters.Font = new System.Drawing.Font("Dubai", 13.8F);
            this.parameters.Location = new System.Drawing.Point(51, 41);
            this.parameters.Name = "parameters";
            this.parameters.Size = new System.Drawing.Size(295, 39);
            this.parameters.TabIndex = 16;
            this.parameters.Text = "Choose Parameters to Check:";
            // 
            // similarityBox
            // 
            this.similarityBox.AutoSize = true;
            this.similarityBox.BackColor = System.Drawing.Color.Transparent;
            this.similarityBox.Font = new System.Drawing.Font("Dubai", 12F);
            this.similarityBox.Location = new System.Drawing.Point(68, 349);
            this.similarityBox.Name = "similarityBox";
            this.similarityBox.Size = new System.Drawing.Size(278, 38);
            this.similarityBox.TabIndex = 15;
            this.similarityBox.Text = "Similarity to Expected Output";
            this.similarityBox.UseVisualStyleBackColor = false;
            // 
            // idBox
            // 
            this.idBox.AutoSize = true;
            this.idBox.BackColor = System.Drawing.Color.Transparent;
            this.idBox.Font = new System.Drawing.Font("Dubai", 12F);
            this.idBox.Location = new System.Drawing.Point(68, 303);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(216, 38);
            this.idBox.TabIndex = 14;
            this.idBox.Text = "Contains ID and Name";
            this.idBox.UseVisualStyleBackColor = false;
            // 
            // originBox
            // 
            this.originBox.AutoSize = true;
            this.originBox.BackColor = System.Drawing.Color.Transparent;
            this.originBox.Font = new System.Drawing.Font("Dubai", 12F);
            this.originBox.Location = new System.Drawing.Point(68, 260);
            this.originBox.Name = "originBox";
            this.originBox.Size = new System.Drawing.Size(210, 38);
            this.originBox.TabIndex = 13;
            this.originBox.Text = "Originality Validation";
            this.originBox.UseVisualStyleBackColor = false;
            // 
            // compilationBox
            // 
            this.compilationBox.AutoSize = true;
            this.compilationBox.BackColor = System.Drawing.Color.Transparent;
            this.compilationBox.Font = new System.Drawing.Font("Dubai", 12F);
            this.compilationBox.Location = new System.Drawing.Point(68, 219);
            this.compilationBox.Name = "compilationBox";
            this.compilationBox.Size = new System.Drawing.Size(189, 38);
            this.compilationBox.TabIndex = 12;
            this.compilationBox.Text = "Compilation Errors";
            this.compilationBox.UseVisualStyleBackColor = false;
            // 
            // indentationBox
            // 
            this.indentationBox.AutoSize = true;
            this.indentationBox.BackColor = System.Drawing.Color.Transparent;
            this.indentationBox.Font = new System.Drawing.Font("Dubai", 12F);
            this.indentationBox.Location = new System.Drawing.Point(68, 179);
            this.indentationBox.Name = "indentationBox";
            this.indentationBox.Size = new System.Drawing.Size(231, 38);
            this.indentationBox.TabIndex = 11;
            this.indentationBox.Text = "Indentation and Spacing";
            this.indentationBox.UseVisualStyleBackColor = false;
            // 
            // classBox
            // 
            this.classBox.AutoSize = true;
            this.classBox.BackColor = System.Drawing.Color.Transparent;
            this.classBox.Font = new System.Drawing.Font("Dubai", 12F);
            this.classBox.Location = new System.Drawing.Point(68, 136);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(250, 38);
            this.classBox.TabIndex = 10;
            this.classBox.Text = "Class Naming Conventions";
            this.classBox.UseVisualStyleBackColor = false;
            // 
            // variableBox
            // 
            this.variableBox.AutoSize = true;
            this.variableBox.BackColor = System.Drawing.Color.Transparent;
            this.variableBox.Font = new System.Drawing.Font("Dubai", 12F);
            this.variableBox.Location = new System.Drawing.Point(68, 91);
            this.variableBox.Name = "variableBox";
            this.variableBox.Size = new System.Drawing.Size(275, 38);
            this.variableBox.TabIndex = 9;
            this.variableBox.Text = "Variable Naming Conventions";
            this.variableBox.UseVisualStyleBackColor = false;
            // 
            // folder_url
            // 
            this.folder_url.Cursor = System.Windows.Forms.Cursors.Default;
            this.folder_url.Location = new System.Drawing.Point(144, 13);
            this.folder_url.Name = "folder_url";
            this.folder_url.Size = new System.Drawing.Size(125, 27);
            this.folder_url.TabIndex = 20;
            // 
            // saveFolder
            // 
            this.saveFolder.AutoSize = true;
            this.saveFolder.BackColor = System.Drawing.Color.Transparent;
            this.saveFolder.Font = new System.Drawing.Font("Dubai", 12F);
            this.saveFolder.Location = new System.Drawing.Point(3, 7);
            this.saveFolder.Name = "saveFolder";
            this.saveFolder.Size = new System.Drawing.Size(135, 34);
            this.saveFolder.TabIndex = 19;
            this.saveFolder.Text = "Save to Folder:";
            // 
            // stateText
            // 
            this.stateText.BackColor = System.Drawing.SystemColors.Control;
            this.stateText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stateText.Location = new System.Drawing.Point(394, 179);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(125, 20);
            this.stateText.TabIndex = 21;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(394, 213);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(385, 29);
            this.progressBar1.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.folder_url);
            this.panel1.Controls.Add(this.save_btn);
            this.panel1.Controls.Add(this.saveFolder);
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(391, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 51);
            this.panel1.TabIndex = 23;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Transparent;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.ForeColor = System.Drawing.Color.Transparent;
            this.save_btn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.save_btn.IconColor = System.Drawing.Color.Black;
            this.save_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.save_btn.IconSize = 40;
            this.save_btn.Location = new System.Drawing.Point(272, 4);
            this.save_btn.Name = "save_btn";
            this.save_btn.Rotation = 90D;
            this.save_btn.Size = new System.Drawing.Size(57, 44);
            this.save_btn.TabIndex = 25;
            this.save_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // executeBox
            // 
            this.executeBox.AutoSize = true;
            this.executeBox.BackColor = System.Drawing.Color.Transparent;
            this.executeBox.Font = new System.Drawing.Font("Dubai", 12F);
            this.executeBox.Location = new System.Drawing.Point(68, 392);
            this.executeBox.Name = "executeBox";
            this.executeBox.Size = new System.Drawing.Size(172, 38);
            this.executeBox.TabIndex = 25;
            this.executeBox.Text = "Running Execute";
            this.executeBox.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start_check_btn
            // 
            this.start_check_btn.BackColor = System.Drawing.Color.Transparent;
            this.start_check_btn.FlatAppearance.BorderSize = 0;
            this.start_check_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_check_btn.ForeColor = System.Drawing.Color.Transparent;
            this.start_check_btn.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.start_check_btn.IconColor = System.Drawing.Color.Black;
            this.start_check_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.start_check_btn.Location = new System.Drawing.Point(727, 378);
            this.start_check_btn.Name = "start_check_btn";
            this.start_check_btn.Size = new System.Drawing.Size(61, 54);
            this.start_check_btn.TabIndex = 24;
            this.start_check_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.start_check_btn.UseVisualStyleBackColor = false;
            this.start_check_btn.Click += new System.EventHandler(this.next_check_btn_Click);
            // 
            // Cp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.executeBox);
            this.Controls.Add(this.start_check_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.parameters);
            this.Controls.Add(this.similarityBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.originBox);
            this.Controls.Add(this.compilationBox);
            this.Controls.Add(this.indentationBox);
            this.Controls.Add(this.classBox);
            this.Controls.Add(this.variableBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cp";
            this.Text = "Cp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cp_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Cp_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label parameters;
        private System.Windows.Forms.CheckBox similarityBox;
        private System.Windows.Forms.CheckBox idBox;
        private System.Windows.Forms.CheckBox originBox;
        private System.Windows.Forms.CheckBox compilationBox;
        private System.Windows.Forms.CheckBox indentationBox;
        private System.Windows.Forms.CheckBox classBox;
        private System.Windows.Forms.CheckBox variableBox;
        private System.Windows.Forms.TextBox folder_url;
        private System.Windows.Forms.Label saveFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton start_check_btn;
        private FontAwesome.Sharp.IconButton save_btn;
        private System.Windows.Forms.CheckBox executeBox;
        private System.Windows.Forms.Timer timer1;
    }
}