namespace R29_ACT1
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
            this.BotonTriangulo = new System.Windows.Forms.Button();
            this.BotonEscuadra = new System.Windows.Forms.Button();
            this.BotonEscuadra2 = new System.Windows.Forms.Button();
            this.BotonPiramideInvertida = new System.Windows.Forms.Button();
            this.BotonPiramide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonTriangulo
            // 
            this.BotonTriangulo.Location = new System.Drawing.Point(89, 64);
            this.BotonTriangulo.Name = "BotonTriangulo";
            this.BotonTriangulo.Size = new System.Drawing.Size(124, 41);
            this.BotonTriangulo.TabIndex = 0;
            this.BotonTriangulo.Text = "Triangulo";
            this.BotonTriangulo.UseVisualStyleBackColor = true;
            this.BotonTriangulo.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // BotonEscuadra
            // 
            this.BotonEscuadra.Location = new System.Drawing.Point(238, 65);
            this.BotonEscuadra.Name = "BotonEscuadra";
            this.BotonEscuadra.Size = new System.Drawing.Size(124, 40);
            this.BotonEscuadra.TabIndex = 1;
            this.BotonEscuadra.Text = "Escuadra";
            this.BotonEscuadra.UseVisualStyleBackColor = true;
            this.BotonEscuadra.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // BotonEscuadra2
            // 
            this.BotonEscuadra2.Location = new System.Drawing.Point(294, 154);
            this.BotonEscuadra2.Name = "BotonEscuadra2";
            this.BotonEscuadra2.Size = new System.Drawing.Size(124, 40);
            this.BotonEscuadra2.TabIndex = 2;
            this.BotonEscuadra2.Text = "Escuadra 2";
            this.BotonEscuadra2.UseVisualStyleBackColor = true;
            this.BotonEscuadra2.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // BotonPiramideInvertida
            // 
            this.BotonPiramideInvertida.Location = new System.Drawing.Point(533, 65);
            this.BotonPiramideInvertida.Name = "BotonPiramideInvertida";
            this.BotonPiramideInvertida.Size = new System.Drawing.Size(124, 40);
            this.BotonPiramideInvertida.TabIndex = 3;
            this.BotonPiramideInvertida.Text = "Pirámide Invertida";
            this.BotonPiramideInvertida.UseVisualStyleBackColor = true;
            this.BotonPiramideInvertida.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // BotonPiramide
            // 
            this.BotonPiramide.Location = new System.Drawing.Point(380, 65);
            this.BotonPiramide.Name = "BotonPiramide";
            this.BotonPiramide.Size = new System.Drawing.Size(124, 40);
            this.BotonPiramide.TabIndex = 4;
            this.BotonPiramide.Text = "Piramide";
            this.BotonPiramide.UseVisualStyleBackColor = true;
            this.BotonPiramide.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonPiramide);
            this.Controls.Add(this.BotonPiramideInvertida);
            this.Controls.Add(this.BotonEscuadra2);
            this.Controls.Add(this.BotonEscuadra);
            this.Controls.Add(this.BotonTriangulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonTriangulo;
        private System.Windows.Forms.Button BotonEscuadra;
        private System.Windows.Forms.Button BotonEscuadra2;
        private System.Windows.Forms.Button BotonPiramideInvertida;
        private System.Windows.Forms.Button BotonPiramide;
    }
}

