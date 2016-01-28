/*
 * (c) 2016 Giuseppe Cramarossa
 * This work is licensed under the Creative Commons Attribution-ShareAlike 4.0 International License. 
 * To view a copy of this license, visit http://creativecommons.org/licenses/by-sa/4.0/.
 */

namespace CPP_Online_Compiler_Monitor
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.websiteName = new System.Windows.Forms.TextBox();
            this.objPath = new System.Windows.Forms.TextBox();
            this.clamAVPath = new System.Windows.Forms.TextBox();
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.exePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mingwPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.EICARVirusGenerator = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 187);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.48583F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.51417F));
            this.tableLayoutPanel1.Controls.Add(this.websiteName, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.objPath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.clamAVPath, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.sourcePath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.exePath, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mingwPath, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(247, 162);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // websiteName
            // 
            this.websiteName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.websiteName.Location = new System.Drawing.Point(102, 133);
            this.websiteName.Name = "websiteName";
            this.websiteName.Size = new System.Drawing.Size(142, 20);
            this.websiteName.TabIndex = 11;
            this.websiteName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.websiteName.Leave += new System.EventHandler(this.UpdateWebsite);
            // 
            // objPath
            // 
            this.objPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objPath.Location = new System.Drawing.Point(102, 55);
            this.objPath.Name = "objPath";
            this.objPath.Size = new System.Drawing.Size(142, 20);
            this.objPath.TabIndex = 10;
            this.objPath.Click += new System.EventHandler(this.pathClicker);
            // 
            // clamAVPath
            // 
            this.clamAVPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clamAVPath.Location = new System.Drawing.Point(102, 107);
            this.clamAVPath.Name = "clamAVPath";
            this.clamAVPath.Size = new System.Drawing.Size(142, 20);
            this.clamAVPath.TabIndex = 9;
            this.clamAVPath.Click += new System.EventHandler(this.pathClicker);
            // 
            // sourcePath
            // 
            this.sourcePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourcePath.Location = new System.Drawing.Point(102, 29);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.Size = new System.Drawing.Size(142, 20);
            this.sourcePath.TabIndex = 8;
            this.sourcePath.Click += new System.EventHandler(this.pathClicker);
            // 
            // exePath
            // 
            this.exePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exePath.Location = new System.Drawing.Point(102, 81);
            this.exePath.Name = "exePath";
            this.exePath.Size = new System.Drawing.Size(142, 20);
            this.exePath.TabIndex = 7;
            this.exePath.Click += new System.EventHandler(this.pathClicker);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Website";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "ClamAV Path";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "EXE Path";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "MinGW bin Path";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source Path";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "OBJ Path";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mingwPath
            // 
            this.mingwPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mingwPath.Location = new System.Drawing.Point(102, 3);
            this.mingwPath.Name = "mingwPath";
            this.mingwPath.Size = new System.Drawing.Size(142, 20);
            this.mingwPath.TabIndex = 6;
            this.mingwPath.Click += new System.EventHandler(this.pathClicker);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Program";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EICARVirusGenerator
            // 
            this.EICARVirusGenerator.AutoSize = true;
            this.EICARVirusGenerator.Location = new System.Drawing.Point(19, 207);
            this.EICARVirusGenerator.Name = "EICARVirusGenerator";
            this.EICARVirusGenerator.Size = new System.Drawing.Size(142, 17);
            this.EICARVirusGenerator.TabIndex = 3;
            this.EICARVirusGenerator.Text = "Create EICAR Test Virus";
            this.EICARVirusGenerator.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.EICARVirusGenerator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox websiteName;
        private System.Windows.Forms.TextBox objPath;
        private System.Windows.Forms.TextBox clamAVPath;
        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.TextBox exePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mingwPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox EICARVirusGenerator;
    }
}

