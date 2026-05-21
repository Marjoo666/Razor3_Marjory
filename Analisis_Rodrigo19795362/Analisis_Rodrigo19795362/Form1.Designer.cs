namespace Analisis_Rodrigo19795362
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú Principal - Control de Almacén y Personal";
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnProductos.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductos.Location = new System.Drawing.Point(148, 65);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(255, 63);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Mantenimiento de Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEmpleados.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEmpleados.Location = new System.Drawing.Point(148, 139);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(255, 63);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "Mantenimiento de Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalir.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(148, 212);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(255, 63);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir del Sistema";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 314);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnSalir;
    }
}