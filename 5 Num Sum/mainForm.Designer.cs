namespace _5_Num_Sum
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataEntryBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsBox = new System.Windows.Forms.GroupBox();
            this.sdLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.varLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.meanLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.thirdQLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstQLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.medianLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.resultsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the 5 Num Sum Program!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Use the box below to enter a data set.  Seperate values with commas.";
            // 
            // dataEntryBox
            // 
            this.dataEntryBox.Location = new System.Drawing.Point(12, 88);
            this.dataEntryBox.Name = "dataEntryBox";
            this.dataEntryBox.Size = new System.Drawing.Size(423, 124);
            this.dataEntryBox.TabIndex = 2;
            this.dataEntryBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "White Space will be ignored.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readFromFileToolStripMenuItem,
            this.saveResultsToolStripMenuItem,
            this.clearDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // readFromFileToolStripMenuItem
            // 
            this.readFromFileToolStripMenuItem.Name = "readFromFileToolStripMenuItem";
            this.readFromFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.readFromFileToolStripMenuItem.Text = "Read From File";
            this.readFromFileToolStripMenuItem.Click += new System.EventHandler(this.readFromFileToolStripMenuItem_Click);
            // 
            // saveResultsToolStripMenuItem
            // 
            this.saveResultsToolStripMenuItem.Name = "saveResultsToolStripMenuItem";
            this.saveResultsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveResultsToolStripMenuItem.Text = "Save Results";
            this.saveResultsToolStripMenuItem.Click += new System.EventHandler(this.saveResultsToolStripMenuItem_Click);
            // 
            // clearDataToolStripMenuItem
            // 
            this.clearDataToolStripMenuItem.Name = "clearDataToolStripMenuItem";
            this.clearDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearDataToolStripMenuItem.Text = "Clear Data";
            this.clearDataToolStripMenuItem.Click += new System.EventHandler(this.clearDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.aboutPageToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howToUseToolStripMenuItem.Text = "How to use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // aboutPageToolStripMenuItem
            // 
            this.aboutPageToolStripMenuItem.Name = "aboutPageToolStripMenuItem";
            this.aboutPageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutPageToolStripMenuItem.Text = "About Page";
            this.aboutPageToolStripMenuItem.Click += new System.EventHandler(this.aboutPageToolStripMenuItem_Click);
            // 
            // resultsBox
            // 
            this.resultsBox.BackColor = System.Drawing.Color.White;
            this.resultsBox.Controls.Add(this.sdLabel);
            this.resultsBox.Controls.Add(this.label11);
            this.resultsBox.Controls.Add(this.varLabel);
            this.resultsBox.Controls.Add(this.label10);
            this.resultsBox.Controls.Add(this.meanLabel);
            this.resultsBox.Controls.Add(this.label7);
            this.resultsBox.Controls.Add(this.minLabel);
            this.resultsBox.Controls.Add(this.label9);
            this.resultsBox.Controls.Add(this.maxLabel);
            this.resultsBox.Controls.Add(this.label8);
            this.resultsBox.Controls.Add(this.thirdQLabel);
            this.resultsBox.Controls.Add(this.label6);
            this.resultsBox.Controls.Add(this.firstQLabel);
            this.resultsBox.Controls.Add(this.label5);
            this.resultsBox.Controls.Add(this.medianLabel);
            this.resultsBox.Controls.Add(this.label4);
            this.resultsBox.ForeColor = System.Drawing.Color.Black;
            this.resultsBox.Location = new System.Drawing.Point(18, 230);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(259, 268);
            this.resultsBox.TabIndex = 5;
            this.resultsBox.TabStop = false;
            this.resultsBox.Text = "Results";
            // 
            // sdLabel
            // 
            this.sdLabel.AutoSize = true;
            this.sdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sdLabel.Location = new System.Drawing.Point(147, 238);
            this.sdLabel.MinimumSize = new System.Drawing.Size(100, 2);
            this.sdLabel.Name = "sdLabel";
            this.sdLabel.Size = new System.Drawing.Size(100, 20);
            this.sdLabel.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Standard Deviation:";
            // 
            // varLabel
            // 
            this.varLabel.AutoSize = true;
            this.varLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.varLabel.Location = new System.Drawing.Point(127, 213);
            this.varLabel.MinimumSize = new System.Drawing.Size(100, 2);
            this.varLabel.Name = "varLabel";
            this.varLabel.Size = new System.Drawing.Size(100, 20);
            this.varLabel.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Sample Variance:";
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.meanLabel.Location = new System.Drawing.Point(63, 187);
            this.meanLabel.MinimumSize = new System.Drawing.Size(100, 2);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(100, 20);
            this.meanLabel.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mean:";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.minLabel.Location = new System.Drawing.Point(86, 161);
            this.minLabel.MinimumSize = new System.Drawing.Size(100, 2);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(100, 20);
            this.minLabel.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Minimum:";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.maxLabel.Location = new System.Drawing.Point(89, 133);
            this.maxLabel.MinimumSize = new System.Drawing.Size(100, 2);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(100, 20);
            this.maxLabel.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Maximum:";
            // 
            // thirdQLabel
            // 
            this.thirdQLabel.AutoSize = true;
            this.thirdQLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thirdQLabel.Location = new System.Drawing.Point(101, 98);
            this.thirdQLabel.MinimumSize = new System.Drawing.Size(100, 2);
            this.thirdQLabel.Name = "thirdQLabel";
            this.thirdQLabel.Size = new System.Drawing.Size(100, 20);
            this.thirdQLabel.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "3rd Quartile:";
            // 
            // firstQLabel
            // 
            this.firstQLabel.AutoSize = true;
            this.firstQLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstQLabel.Location = new System.Drawing.Point(98, 62);
            this.firstQLabel.MinimumSize = new System.Drawing.Size(100, 2);
            this.firstQLabel.Name = "firstQLabel";
            this.firstQLabel.Size = new System.Drawing.Size(100, 20);
            this.firstQLabel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "1st Quartile:";
            // 
            // medianLabel
            // 
            this.medianLabel.AutoSize = true;
            this.medianLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.medianLabel.Location = new System.Drawing.Point(75, 30);
            this.medianLabel.MinimumSize = new System.Drawing.Size(100, 2);
            this.medianLabel.Name = "medianLabel";
            this.medianLabel.Size = new System.Drawing.Size(100, 20);
            this.medianLabel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Median:";
            // 
            // calButton
            // 
            this.calButton.BackColor = System.Drawing.Color.White;
            this.calButton.ForeColor = System.Drawing.Color.Black;
            this.calButton.Location = new System.Drawing.Point(331, 230);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(97, 40);
            this.calButton.TabIndex = 6;
            this.calButton.Text = "Calculate";
            this.calButton.UseVisualStyleBackColor = false;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(331, 341);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 40);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(331, 285);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(97, 40);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save Results";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(331, 397);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(97, 40);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(447, 510);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataEntryBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "5 Num Sum";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.resultsBox.ResumeLayout(false);
            this.resultsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox dataEntryBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutPageToolStripMenuItem;
        private System.Windows.Forms.GroupBox resultsBox;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label thirdQLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label firstQLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label medianLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem saveResultsToolStripMenuItem;
        private System.Windows.Forms.Label sdLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label varLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exitButton;
    }
}

