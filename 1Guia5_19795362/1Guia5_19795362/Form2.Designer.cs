namespace _1Guia5_19795362
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnIngresarC = new System.Windows.Forms.Button();
            this.btnLimpiarC = new System.Windows.Forms.Button();
            this.btnVolverC = new System.Windows.Forms.Button();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(144, 113);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(193, 20);
            this.txtCliente.TabIndex = 2;
            // 
            // btnIngresarC
            // 
            this.btnIngresarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarC.Location = new System.Drawing.Point(41, 194);
            this.btnIngresarC.Name = "btnIngresarC";
            this.btnIngresarC.Size = new System.Drawing.Size(100, 30);
            this.btnIngresarC.TabIndex = 3;
            this.btnIngresarC.Text = "Ingresar";
            this.btnIngresarC.UseVisualStyleBackColor = true;
            this.btnIngresarC.Click += new System.EventHandler(this.btnIngresarC_Click);
            // 
            // btnLimpiarC
            // 
            this.btnLimpiarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarC.Location = new System.Drawing.Point(163, 194);
            this.btnLimpiarC.Name = "btnLimpiarC";
            this.btnLimpiarC.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiarC.TabIndex = 4;
            this.btnLimpiarC.Text = "Limpiar";
            this.btnLimpiarC.UseVisualStyleBackColor = true;
            this.btnLimpiarC.Click += new System.EventHandler(this.btnLimpiarC_Click);
            // 
            // btnVolverC
            // 
            this.btnVolverC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverC.Location = new System.Drawing.Point(284, 194);
            this.btnVolverC.Name = "btnVolverC";
            this.btnVolverC.Size = new System.Drawing.Size(100, 30);
            this.btnVolverC.TabIndex = 5;
            this.btnVolverC.Text = "Volver";
            this.btnVolverC.UseVisualStyleBackColor = true;
            this.btnVolverC.Click += new System.EventHandler(this.btnVolverC_Click);
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarC.Location = new System.Drawing.Point(163, 235);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarC.TabIndex = 6;
            this.btnEliminarC.Text = "Eliminar";
            this.btnEliminarC.UseVisualStyleBackColor = true;
            this.btnEliminarC.Click += new System.EventHandler(this.btnEliminarC_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 360);
            this.Controls.Add(this.btnEliminarC);
            this.Controls.Add(this.btnVolverC);
            this.Controls.Add(this.btnLimpiarC);
            this.Controls.Add(this.btnIngresarC);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnIngresarC;
        private System.Windows.Forms.Button btnLimpiarC;
        private System.Windows.Forms.Button btnVolverC;
        private System.Windows.Forms.Button btnEliminarC;
    }
}