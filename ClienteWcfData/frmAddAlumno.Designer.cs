namespace ClienteWcfData
{
    partial class frmAddAlumno
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
            this.txtBoxNameAdd = new System.Windows.Forms.TextBox();
            this.txtBoxSurnameAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxEmailAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxNameAdd
            // 
            this.txtBoxNameAdd.Location = new System.Drawing.Point(307, 149);
            this.txtBoxNameAdd.Name = "txtBoxNameAdd";
            this.txtBoxNameAdd.Size = new System.Drawing.Size(201, 26);
            this.txtBoxNameAdd.TabIndex = 0;
            // 
            // txtBoxSurnameAdd
            // 
            this.txtBoxSurnameAdd.Location = new System.Drawing.Point(307, 195);
            this.txtBoxSurnameAdd.Name = "txtBoxSurnameAdd";
            this.txtBoxSurnameAdd.Size = new System.Drawing.Size(201, 26);
            this.txtBoxSurnameAdd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "Add Form";
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.Location = new System.Drawing.Point(531, 297);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.Size = new System.Drawing.Size(75, 29);
            this.btnSaveAdd.TabIndex = 6;
            this.btnSaveAdd.Text = "Save";
            this.btnSaveAdd.UseVisualStyleBackColor = true;
            this.btnSaveAdd.Click += new System.EventHandler(this.btnSaveAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "email";
            // 
            // txtBoxEmailAdd
            // 
            this.txtBoxEmailAdd.Location = new System.Drawing.Point(307, 244);
            this.txtBoxEmailAdd.Name = "txtBoxEmailAdd";
            this.txtBoxEmailAdd.Size = new System.Drawing.Size(201, 26);
            this.txtBoxEmailAdd.TabIndex = 7;
            // 
            // frmAddAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxEmailAdd);
            this.Controls.Add(this.btnSaveAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxSurnameAdd);
            this.Controls.Add(this.txtBoxNameAdd);
            this.Name = "frmAddAlumno";
            this.Text = "frmAddAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNameAdd;
        private System.Windows.Forms.TextBox txtBoxSurnameAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxEmailAdd;
    }
}