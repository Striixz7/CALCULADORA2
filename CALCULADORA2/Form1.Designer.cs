namespace CALCULADORA2
{
    partial class CALCULADORA2
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
            this.tbxScreen = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnN0 = new System.Windows.Forms.Button();
            this.btnN3 = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnN1 = new System.Windows.Forms.Button();
            this.btnN6 = new System.Windows.Forms.Button();
            this.btnN5 = new System.Windows.Forms.Button();
            this.btnN4 = new System.Windows.Forms.Button();
            this.btnN9 = new System.Windows.Forms.Button();
            this.btnN8 = new System.Windows.Forms.Button();
            this.btnN7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxScreen
            // 
            this.tbxScreen.Location = new System.Drawing.Point(112, 54);
            this.tbxScreen.Multiline = true;
            this.tbxScreen.Name = "tbxScreen";
            this.tbxScreen.Size = new System.Drawing.Size(344, 59);
            this.tbxScreen.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(392, 118);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(64, 46);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "C";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(392, 167);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(64, 49);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "<--";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(338, 332);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 49);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(392, 222);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(64, 104);
            this.btnIgual.TabIndex = 4;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(322, 167);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(64, 49);
            this.btnDividir.TabIndex = 8;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(322, 277);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(64, 49);
            this.btnMultiplicar.TabIndex = 7;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(322, 222);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(64, 49);
            this.btnRestar.TabIndex = 6;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(322, 118);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(64, 43);
            this.btnSumar.TabIndex = 5;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(252, 277);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(64, 49);
            this.btnPunto.TabIndex = 12;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnN0
            // 
            this.btnN0.Location = new System.Drawing.Point(112, 277);
            this.btnN0.Name = "btnN0";
            this.btnN0.Size = new System.Drawing.Size(134, 49);
            this.btnN0.TabIndex = 11;
            this.btnN0.Text = "0";
            this.btnN0.UseVisualStyleBackColor = true;
            this.btnN0.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnN3
            // 
            this.btnN3.Location = new System.Drawing.Point(252, 118);
            this.btnN3.Name = "btnN3";
            this.btnN3.Size = new System.Drawing.Size(64, 43);
            this.btnN3.TabIndex = 10;
            this.btnN3.Text = "3";
            this.btnN3.UseVisualStyleBackColor = true;
            this.btnN3.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnN2
            // 
            this.btnN2.Location = new System.Drawing.Point(182, 119);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(64, 42);
            this.btnN2.TabIndex = 9;
            this.btnN2.Text = "2";
            this.btnN2.UseVisualStyleBackColor = true;
            this.btnN2.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnN1
            // 
            this.btnN1.Location = new System.Drawing.Point(112, 118);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(64, 43);
            this.btnN1.TabIndex = 13;
            this.btnN1.Text = "1";
            this.btnN1.UseVisualStyleBackColor = true;
            this.btnN1.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnN6
            // 
            this.btnN6.Location = new System.Drawing.Point(252, 167);
            this.btnN6.Name = "btnN6";
            this.btnN6.Size = new System.Drawing.Size(64, 49);
            this.btnN6.TabIndex = 16;
            this.btnN6.Text = "6";
            this.btnN6.UseVisualStyleBackColor = true;
            this.btnN6.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnN5
            // 
            this.btnN5.Location = new System.Drawing.Point(182, 167);
            this.btnN5.Name = "btnN5";
            this.btnN5.Size = new System.Drawing.Size(64, 49);
            this.btnN5.TabIndex = 15;
            this.btnN5.Text = "5";
            this.btnN5.UseVisualStyleBackColor = true;
            this.btnN5.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnN4
            // 
            this.btnN4.Location = new System.Drawing.Point(112, 167);
            this.btnN4.Name = "btnN4";
            this.btnN4.Size = new System.Drawing.Size(64, 49);
            this.btnN4.TabIndex = 14;
            this.btnN4.Text = "4";
            this.btnN4.UseVisualStyleBackColor = true;
            this.btnN4.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnN9
            // 
            this.btnN9.Location = new System.Drawing.Point(252, 222);
            this.btnN9.Name = "btnN9";
            this.btnN9.Size = new System.Drawing.Size(64, 49);
            this.btnN9.TabIndex = 19;
            this.btnN9.Text = "9";
            this.btnN9.UseVisualStyleBackColor = true;
            this.btnN9.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnN8
            // 
            this.btnN8.Location = new System.Drawing.Point(182, 222);
            this.btnN8.Name = "btnN8";
            this.btnN8.Size = new System.Drawing.Size(64, 49);
            this.btnN8.TabIndex = 18;
            this.btnN8.Text = "8";
            this.btnN8.UseVisualStyleBackColor = true;
            this.btnN8.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnN7
            // 
            this.btnN7.Location = new System.Drawing.Point(112, 222);
            this.btnN7.Name = "btnN7";
            this.btnN7.Size = new System.Drawing.Size(64, 49);
            this.btnN7.TabIndex = 17;
            this.btnN7.Text = "7";
            this.btnN7.UseVisualStyleBackColor = true;
            this.btnN7.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // CALCULADORA2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 494);
            this.Controls.Add(this.btnN9);
            this.Controls.Add(this.btnN8);
            this.Controls.Add(this.btnN7);
            this.Controls.Add(this.btnN6);
            this.Controls.Add(this.btnN5);
            this.Controls.Add(this.btnN4);
            this.Controls.Add(this.btnN1);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnN0);
            this.Controls.Add(this.btnN3);
            this.Controls.Add(this.btnN2);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.tbxScreen);
            this.Name = "CALCULADORA2";
            this.Text = "CALCULADORA2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxScreen;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnN0;
        private System.Windows.Forms.Button btnN3;
        private System.Windows.Forms.Button btnN2;
        private System.Windows.Forms.Button btnN1;
        private System.Windows.Forms.Button btnN6;
        private System.Windows.Forms.Button btnN5;
        private System.Windows.Forms.Button btnN4;
        private System.Windows.Forms.Button btnN9;
        private System.Windows.Forms.Button btnN8;
        private System.Windows.Forms.Button btnN7;
    }
}
