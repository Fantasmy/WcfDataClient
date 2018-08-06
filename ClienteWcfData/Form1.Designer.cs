namespace ClienteWcfData
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAlumno = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHttp = new System.Windows.Forms.Button();
            this.btnTcp = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumno
            // 
            this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumno.Location = new System.Drawing.Point(84, 56);
            this.dgvAlumno.Name = "dgvAlumno";
            this.dgvAlumno.RowTemplate.Height = 28;
            this.dgvAlumno.Size = new System.Drawing.Size(632, 241);
            this.dgvAlumno.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(142, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnHttp
            // 
            this.btnHttp.Location = new System.Drawing.Point(277, 333);
            this.btnHttp.Name = "btnHttp";
            this.btnHttp.Size = new System.Drawing.Size(75, 34);
            this.btnHttp.TabIndex = 2;
            this.btnHttp.Text = "Http";
            this.btnHttp.UseVisualStyleBackColor = true;
            this.btnHttp.Click += new System.EventHandler(this.btnHttp_Click);
            // 
            // btnTcp
            // 
            this.btnTcp.Location = new System.Drawing.Point(418, 333);
            this.btnTcp.Name = "btnTcp";
            this.btnTcp.Size = new System.Drawing.Size(75, 34);
            this.btnTcp.TabIndex = 3;
            this.btnTcp.Text = "Tcp";
            this.btnTcp.UseVisualStyleBackColor = true;
            this.btnTcp.Click += new System.EventHandler(this.btnTcp_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(563, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTcp);
            this.Controls.Add(this.btnHttp);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumno;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHttp;
        private System.Windows.Forms.Button btnTcp;
        private System.Windows.Forms.Button btnUpdate;
    }
}

