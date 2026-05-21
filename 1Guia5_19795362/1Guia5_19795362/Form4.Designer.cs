namespace _1Guia5_19795362
{
    partial class Form4
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
            this.txtIdLibroL = new System.Windows.Forms.TextBox();
            this.txtNombreLibroL = new System.Windows.Forms.TextBox();
            this.btnIngresarL = new System.Windows.Forms.Button();
            this.btnEliminarL = new System.Windows.Forms.Button();
            this.btnLimpiarL = new System.Windows.Forms.Button();
            this.btnVolverL = new System.Windows.Forms.Button();
            this.LIBROS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NombreLibro";
            // 
            // txtIdLibroL
            // 
            this.txtIdLibroL.Location = new System.Drawing.Point(222, 115);
            this.txtIdLibroL.Name = "txtIdLibroL";
            this.txtIdLibroL.Size = new System.Drawing.Size(100, 20);
            this.txtIdLibroL.TabIndex = 2;
            // 
            // txtNombreLibroL
            // 
            this.txtNombreLibroL.Location = new System.Drawing.Point(222, 167);
            this.txtNombreLibroL.Name = "txtNombreLibroL";
            this.txtNombreLibroL.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLibroL.TabIndex = 3;
            // 
            // btnIngresarL
            // 
            this.btnIngresarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarL.Location = new System.Drawing.Point(42, 228);
            this.btnIngresarL.Name = "btnIngresarL";
            this.btnIngresarL.Size = new System.Drawing.Size(100, 30);
            this.btnIngresarL.TabIndex = 4;
            this.btnIngresarL.Text = "Ingresar";
            this.btnIngresarL.UseVisualStyleBackColor = true;
            this.btnIngresarL.Click += new System.EventHandler(this.btnIngresarL_Click);
            // 
            // btnEliminarL
            // 
            this.btnEliminarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarL.Location = new System.Drawing.Point(140, 228);
            this.btnEliminarL.Name = "btnEliminarL";
            this.btnEliminarL.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarL.TabIndex = 5;
            this.btnEliminarL.Text = "Eliminar";
            this.btnEliminarL.UseVisualStyleBackColor = true;
            this.btnEliminarL.Click += new System.EventHandler(this.btnEliminarL_Click);
            // 
            // btnLimpiarL
            // 
            this.btnLimpiarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarL.Location = new System.Drawing.Point(237, 228);
            this.btnLimpiarL.Name = "btnLimpiarL";
            this.btnLimpiarL.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiarL.TabIndex = 6;
            this.btnLimpiarL.Text = "Limpiar";
            this.btnLimpiarL.UseVisualStyleBackColor = true;
            this.btnLimpiarL.Click += new System.EventHandler(this.btnLimpiarL_Click);
            // 
            // btnVolverL
            // 
            this.btnVolverL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverL.Location = new System.Drawing.Point(334, 228);
            this.btnVolverL.Name = "btnVolverL";
            this.btnVolverL.Size = new System.Drawing.Size(100, 30);
            this.btnVolverL.TabIndex = 7;
            this.btnVolverL.Text = "Volver";
            this.btnVolverL.UseVisualStyleBackColor = true;
            this.btnVolverL.Click += new System.EventHandler(this.btnVolverL_Click);
            // 
            // LIBROS
            // 
            this.LIBROS.AutoSize = true;
            this.LIBROS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIBROS.Location = new System.Drawing.Point(174, 55);
            this.LIBROS.Name = "LIBROS";
            this.LIBROS.Size = new System.Drawing.Size(82, 24);
            this.LIBROS.TabIndex = 8;
            this.LIBROS.Text = "LIBROS";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 325);
            this.Controls.Add(this.LIBROS);
            this.Controls.Add(this.btnVolverL);
            this.Controls.Add(this.btnLimpiarL);
            this.Controls.Add(this.btnEliminarL);
            this.Controls.Add(this.btnIngresarL);
            this.Controls.Add(this.txtNombreLibroL);
            this.Controls.Add(this.txtIdLibroL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdLibroL;
        private System.Windows.Forms.TextBox txtNombreLibroL;
        private System.Windows.Forms.Button btnIngresarL;
        private System.Windows.Forms.Button btnEliminarL;
        private System.Windows.Forms.Button btnLimpiarL;
        private System.Windows.Forms.Button btnVolverL;
        private System.Windows.Forms.Label LIBROS;
    }
}