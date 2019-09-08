namespace AdminElectoral
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileSelection = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(36, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 260);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Image = global::AdminElectoral.Properties.Resources.Oracle;
            this.button2.Location = new System.Drawing.Point(308, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 156);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cargar datos a:";
            // 
            // button1
            // 
            this.button1.Image = global::AdminElectoral.Properties.Resources.MSQL;
            this.button1.Location = new System.Drawing.Point(59, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 156);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::AdminElectoral.Properties.Resources.Title;
            this.panel3.Location = new System.Drawing.Point(36, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 62);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::AdminElectoral.Properties.Resources.flag;
            this.panel2.Location = new System.Drawing.Point(448, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 54);
            this.panel2.TabIndex = 2;
            // 
            // fileSelection
            // 
            this.fileSelection.DefaultExt = "txt";
            this.fileSelection.FileName = "fileSelection";
            this.fileSelection.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.fileSelection.InitialDirectory = "C:\\";
            this.fileSelection.RestoreDirectory = true;
            this.fileSelection.Title = "Seleccione el archivo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 400);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Administrador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.OpenFileDialog fileSelection;
    }
}

