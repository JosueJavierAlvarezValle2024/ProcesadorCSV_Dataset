namespace ProcesadorCSV_Dataset
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
            dgvDatos = new DataGridView();
            btnCargarCSV = new Button();
            lblEstadisticas = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(12, 22);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(1033, 481);
            dgvDatos.TabIndex = 0;
            // 
            // btnCargarCSV
            // 
            btnCargarCSV.Location = new Point(36, 535);
            btnCargarCSV.Name = "btnCargarCSV";
            btnCargarCSV.Size = new Size(215, 47);
            btnCargarCSV.TabIndex = 1;
            btnCargarCSV.Text = "Cargar Dataset CSV";
            btnCargarCSV.UseVisualStyleBackColor = true;
            btnCargarCSV.Click += btnCargarCSV_Click;
            // 
            // lblEstadisticas
            // 
            lblEstadisticas.AutoSize = true;
            lblEstadisticas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadisticas.Location = new Point(464, 536);
            lblEstadisticas.Name = "lblEstadisticas";
            lblEstadisticas.Size = new Size(186, 28);
            lblEstadisticas.TabIndex = 2;
            lblEstadisticas.Text = "Esperando Datos...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumBlue;
            ClientSize = new Size(1057, 629);
            Controls.Add(lblEstadisticas);
            Controls.Add(btnCargarCSV);
            Controls.Add(dgvDatos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private Button btnCargarCSV;
        private Label lblEstadisticas;
    }
}
