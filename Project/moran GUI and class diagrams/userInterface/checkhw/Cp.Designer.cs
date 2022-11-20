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
            this.start_check_btn = new System.Windows.Forms.Button();
            this.parameters = new System.Windows.Forms.Label();
            this.similarityBox = new System.Windows.Forms.CheckBox();
            this.idBox = new System.Windows.Forms.CheckBox();
            this.originBox = new System.Windows.Forms.CheckBox();
            this.compilationBox = new System.Windows.Forms.CheckBox();
            this.indentationBox = new System.Windows.Forms.CheckBox();
            this.classBox = new System.Windows.Forms.CheckBox();
            this.variableBox = new System.Windows.Forms.CheckBox();
            this.folderName = new System.Windows.Forms.TextBox();
            this.saveFolder = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.stateText = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_check_btn
            // 
            this.start_check_btn.Location = new System.Drawing.Point(680, 371);
            this.start_check_btn.Name = "start_check_btn";
            this.start_check_btn.Size = new System.Drawing.Size(96, 53);
            this.start_check_btn.TabIndex = 17;
            this.start_check_btn.Text = "Start";
            this.start_check_btn.UseVisualStyleBackColor = true;
            this.start_check_btn.Click += new System.EventHandler(this.next_check_btn_Click);
            // 
            // parameters
            // 
            this.parameters.AutoSize = true;
            this.parameters.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parameters.Location = new System.Drawing.Point(67, 37);
            this.parameters.Name = "parameters";
            this.parameters.Size = new System.Drawing.Size(295, 39);
            this.parameters.TabIndex = 16;
            this.parameters.Text = "Choose Parameters to Check:";
            // 
            // similarityBox
            // 
            this.similarityBox.AutoSize = true;
            this.similarityBox.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.similarityBox.Location = new System.Drawing.Point(68, 349);
            this.similarityBox.Name = "similarityBox";
            this.similarityBox.Size = new System.Drawing.Size(278, 38);
            this.similarityBox.TabIndex = 15;
            this.similarityBox.Text = "Similarity to Expected Output";
            this.similarityBox.UseVisualStyleBackColor = true;
            // 
            // idBox
            // 
            this.idBox.AutoSize = true;
            this.idBox.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idBox.Location = new System.Drawing.Point(68, 303);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(216, 38);
            this.idBox.TabIndex = 14;
            this.idBox.Text = "Contains ID and Name";
            this.idBox.UseVisualStyleBackColor = true;
            // 
            // originBox
            // 
            this.originBox.AutoSize = true;
            this.originBox.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.originBox.Location = new System.Drawing.Point(68, 260);
            this.originBox.Name = "originBox";
            this.originBox.Size = new System.Drawing.Size(210, 38);
            this.originBox.TabIndex = 13;
            this.originBox.Text = "Originality Validation";
            this.originBox.UseVisualStyleBackColor = true;
            // 
            // compilationBox
            // 
            this.compilationBox.AutoSize = true;
            this.compilationBox.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.compilationBox.Location = new System.Drawing.Point(68, 219);
            this.compilationBox.Name = "compilationBox";
            this.compilationBox.Size = new System.Drawing.Size(189, 38);
            this.compilationBox.TabIndex = 12;
            this.compilationBox.Text = "Compilation Errors";
            this.compilationBox.UseVisualStyleBackColor = true;
            // 
            // indentationBox
            // 
            this.indentationBox.AutoSize = true;
            this.indentationBox.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.indentationBox.Location = new System.Drawing.Point(68, 179);
            this.indentationBox.Name = "indentationBox";
            this.indentationBox.Size = new System.Drawing.Size(231, 38);
            this.indentationBox.TabIndex = 11;
            this.indentationBox.Text = "Indentation and Spacing";
            this.indentationBox.UseVisualStyleBackColor = true;
            // 
            // classBox
            // 
            this.classBox.AutoSize = true;
            this.classBox.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classBox.Location = new System.Drawing.Point(68, 136);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(250, 38);
            this.classBox.TabIndex = 10;
            this.classBox.Text = "Class Naming Conventions";
            this.classBox.UseVisualStyleBackColor = true;
            // 
            // variableBox
            // 
            this.variableBox.AutoSize = true;
            this.variableBox.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.variableBox.Location = new System.Drawing.Point(68, 91);
            this.variableBox.Name = "variableBox";
            this.variableBox.Size = new System.Drawing.Size(275, 38);
            this.variableBox.TabIndex = 9;
            this.variableBox.Text = "Variable Naming Conventions";
            this.variableBox.UseVisualStyleBackColor = true;
            // 
            // folderName
            // 
            this.folderName.Location = new System.Drawing.Point(144, 6);
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(125, 27);
            this.folderName.TabIndex = 20;
            // 
            // saveFolder
            // 
            this.saveFolder.AutoSize = true;
            this.saveFolder.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveFolder.Location = new System.Drawing.Point(3, 3);
            this.saveFolder.Name = "saveFolder";
            this.saveFolder.Size = new System.Drawing.Size(135, 34);
            this.saveFolder.TabIndex = 19;
            this.saveFolder.Text = "Save to Folder:";
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(290, 6);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(94, 29);
            this.Save_btn.TabIndex = 18;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // stateText
            // 
            this.stateText.BackColor = System.Drawing.Color.LightSeaGreen;
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
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.folderName);
            this.panel1.Controls.Add(this.Save_btn);
            this.panel1.Controls.Add(this.saveFolder);
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(391, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 41);
            this.panel1.TabIndex = 23;
            // 
            // Cp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.start_check_btn);
            this.Controls.Add(this.parameters);
            this.Controls.Add(this.similarityBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.originBox);
            this.Controls.Add(this.compilationBox);
            this.Controls.Add(this.indentationBox);
            this.Controls.Add(this.classBox);
            this.Controls.Add(this.variableBox);
            this.Name = "Cp";
            this.Text = "Cp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_check_btn;
        private System.Windows.Forms.Label parameters;
        private System.Windows.Forms.CheckBox similarityBox;
        private System.Windows.Forms.CheckBox idBox;
        private System.Windows.Forms.CheckBox originBox;
        private System.Windows.Forms.CheckBox compilationBox;
        private System.Windows.Forms.CheckBox indentationBox;
        private System.Windows.Forms.CheckBox classBox;
        private System.Windows.Forms.CheckBox variableBox;
        private System.Windows.Forms.TextBox folderName;
        private System.Windows.Forms.Label saveFolder;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
    }
}