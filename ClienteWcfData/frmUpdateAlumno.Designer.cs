namespace ClienteWcfData
{
    partial class frmUpdateAlumno
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
            this.txtBoxNameUpdate = new System.Windows.Forms.TextBox();
            this.txtBoxSurnameUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxNameUpdate
            // 
            this.txtBoxNameUpdate.Location = new System.Drawing.Point(334, 128);
            this.txtBoxNameUpdate.Name = "txtBoxNameUpdate";
            this.txtBoxNameUpdate.Size = new System.Drawing.Size(187, 26);
            this.txtBoxNameUpdate.TabIndex = 0;
            // 
            // txtBoxSurnameUpdate
            // 
            this.txtBoxSurnameUpdate.Location = new System.Drawing.Point(334, 206);
            this.txtBoxSurnameUpdate.Name = "txtBoxSurnameUpdate";
            this.txtBoxSurnameUpdate.Size = new System.Drawing.Size(187, 26);
            this.txtBoxSurnameUpdate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Update Form";
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.Location = new System.Drawing.Point(547, 280);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnSaveUpdate.TabIndex = 5;
            this.btnSaveUpdate.Text = "Save";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            // 
            // frmUpdateAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxSurnameUpdate);
            this.Controls.Add(this.txtBoxNameUpdate);
            this.Name = "frmUpdateAlumno";
            this.Text = "frmUpdateAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNameUpdate;
        private System.Windows.Forms.TextBox txtBoxSurnameUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveUpdate;
    }
}