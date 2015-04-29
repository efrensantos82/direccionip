namespace direcciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btndireccion = new System.Windows.Forms.Button();
            this.txtdireccion = new System.Windows.Forms.MaskedTextBox();
            this.txtdireccion1 = new System.Windows.Forms.MaskedTextBox();
            this.txtdireccion2 = new System.Windows.Forms.MaskedTextBox();
            this.txtdireccion3 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Direccion IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = ".";
            // 
            // btndireccion
            // 
            this.btndireccion.Font = new System.Drawing.Font("Century", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndireccion.Location = new System.Drawing.Point(171, 130);
            this.btndireccion.Name = "btndireccion";
            this.btndireccion.Size = new System.Drawing.Size(121, 45);
            this.btndireccion.TabIndex = 8;
            this.btndireccion.Text = "Obtener Clase de Direccion";
            this.btndireccion.UseVisualStyleBackColor = true;
            this.btndireccion.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(130, 52);
            this.txtdireccion.Mask = "999";
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(58, 27);
            this.txtdireccion.TabIndex = 9;
            // 
            // txtdireccion1
            // 
            this.txtdireccion1.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion1.Location = new System.Drawing.Point(214, 52);
            this.txtdireccion1.Mask = "999";
            this.txtdireccion1.Name = "txtdireccion1";
            this.txtdireccion1.Size = new System.Drawing.Size(58, 27);
            this.txtdireccion1.TabIndex = 10;
            // 
            // txtdireccion2
            // 
            this.txtdireccion2.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion2.Location = new System.Drawing.Point(298, 52);
            this.txtdireccion2.Mask = "999";
            this.txtdireccion2.Name = "txtdireccion2";
            this.txtdireccion2.Size = new System.Drawing.Size(58, 27);
            this.txtdireccion2.TabIndex = 11;
            // 
            // txtdireccion3
            // 
            this.txtdireccion3.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion3.Location = new System.Drawing.Point(382, 52);
            this.txtdireccion3.Mask = "999";
            this.txtdireccion3.Name = "txtdireccion3";
            this.txtdireccion3.Size = new System.Drawing.Size(58, 27);
            this.txtdireccion3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 223);
            this.Controls.Add(this.txtdireccion3);
            this.Controls.Add(this.txtdireccion2);
            this.Controls.Add(this.txtdireccion1);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.btndireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndireccion;
        private System.Windows.Forms.MaskedTextBox txtdireccion;
        private System.Windows.Forms.MaskedTextBox txtdireccion1;
        private System.Windows.Forms.MaskedTextBox txtdireccion2;
        private System.Windows.Forms.MaskedTextBox txtdireccion3;
    }
}

