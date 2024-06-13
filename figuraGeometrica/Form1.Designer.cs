
namespace figuraGeometrica
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoText = new System.Windows.Forms.RichTextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.radioButtonEsfera = new System.Windows.Forms.RadioButton();
            this.radioButtonPrisma = new System.Windows.Forms.RadioButton();
            this.radioButtonCubo = new System.Windows.Forms.RadioButton();
            this.radioButtonCirculo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.buttonDibujar = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonPoligonoI = new System.Windows.Forms.RadioButton();
            this.radioButtonPoligonoR = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangulo = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangulo = new System.Windows.Forms.RadioButton();
            this.radioButtonCuadrado = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.infoText);
            this.groupBox1.Controls.Add(this.buttonCalcular);
            this.groupBox1.Controls.Add(this.buttonLimpiar);
            this.groupBox1.Controls.Add(this.radioButtonEsfera);
            this.groupBox1.Controls.Add(this.radioButtonPrisma);
            this.groupBox1.Controls.Add(this.radioButtonCubo);
            this.groupBox1.Controls.Add(this.radioButtonCirculo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonExportar);
            this.groupBox1.Controls.Add(this.buttonDibujar);
            this.groupBox1.Controls.Add(this.buttonInfo);
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButtonPoligonoI);
            this.groupBox1.Controls.Add(this.radioButtonPoligonoR);
            this.groupBox1.Controls.Add(this.radioButtonRectangulo);
            this.groupBox1.Controls.Add(this.radioButtonTriangulo);
            this.groupBox1.Controls.Add(this.radioButtonCuadrado);
            this.groupBox1.Location = new System.Drawing.Point(70, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 465);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ingrese un lado, radio de la figura";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(175, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 226);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // infoText
            // 
            this.infoText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText.Location = new System.Drawing.Point(443, 67);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(231, 226);
            this.infoText.TabIndex = 16;
            this.infoText.Text = "";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalcular.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCalcular.FlatAppearance.BorderSize = 2;
            this.buttonCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(593, 387);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(108, 55);
            this.buttonCalcular.TabIndex = 15;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonLimpiar.FlatAppearance.BorderSize = 2;
            this.buttonLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(479, 387);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(108, 56);
            this.buttonLimpiar.TabIndex = 14;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // radioButtonEsfera
            // 
            this.radioButtonEsfera.AutoSize = true;
            this.radioButtonEsfera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonEsfera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEsfera.Location = new System.Drawing.Point(31, 144);
            this.radioButtonEsfera.Name = "radioButtonEsfera";
            this.radioButtonEsfera.Size = new System.Drawing.Size(65, 20);
            this.radioButtonEsfera.TabIndex = 13;
            this.radioButtonEsfera.Text = "Esfera";
            this.radioButtonEsfera.UseVisualStyleBackColor = true;
            this.radioButtonEsfera.CheckedChanged += new System.EventHandler(this.radioButtonEsfera_CheckedChanged);
            // 
            // radioButtonPrisma
            // 
            this.radioButtonPrisma.AutoSize = true;
            this.radioButtonPrisma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonPrisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrisma.Location = new System.Drawing.Point(29, 222);
            this.radioButtonPrisma.Name = "radioButtonPrisma";
            this.radioButtonPrisma.Size = new System.Drawing.Size(68, 20);
            this.radioButtonPrisma.TabIndex = 12;
            this.radioButtonPrisma.Text = "Prisma";
            this.radioButtonPrisma.UseVisualStyleBackColor = true;
            this.radioButtonPrisma.CheckedChanged += new System.EventHandler(this.radioButtonPrisma_CheckedChanged);
            // 
            // radioButtonCubo
            // 
            this.radioButtonCubo.AutoSize = true;
            this.radioButtonCubo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCubo.Location = new System.Drawing.Point(31, 118);
            this.radioButtonCubo.Name = "radioButtonCubo";
            this.radioButtonCubo.Size = new System.Drawing.Size(58, 20);
            this.radioButtonCubo.TabIndex = 11;
            this.radioButtonCubo.Text = "Cubo";
            this.radioButtonCubo.UseVisualStyleBackColor = true;
            this.radioButtonCubo.CheckedChanged += new System.EventHandler(this.radioButtonCubo_CheckedChanged);
            // 
            // radioButtonCirculo
            // 
            this.radioButtonCirculo.AutoSize = true;
            this.radioButtonCirculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCirculo.Location = new System.Drawing.Point(31, 66);
            this.radioButtonCirculo.Name = "radioButtonCirculo";
            this.radioButtonCirculo.Size = new System.Drawing.Size(67, 20);
            this.radioButtonCirculo.TabIndex = 10;
            this.radioButtonCirculo.Text = "Círculo";
            this.radioButtonCirculo.UseVisualStyleBackColor = true;
            this.radioButtonCirculo.CheckedChanged += new System.EventHandler(this.radioButtonCirculo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(131, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Constructor de figuras geometricas";
            // 
            // buttonExportar
            // 
            this.buttonExportar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExportar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonExportar.FlatAppearance.BorderSize = 2;
            this.buttonExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportar.Location = new System.Drawing.Point(365, 387);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(108, 57);
            this.buttonExportar.TabIndex = 9;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = false;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // buttonDibujar
            // 
            this.buttonDibujar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDibujar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDibujar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDibujar.FlatAppearance.BorderSize = 2;
            this.buttonDibujar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDibujar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDibujar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDibujar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDibujar.Location = new System.Drawing.Point(251, 387);
            this.buttonDibujar.Name = "buttonDibujar";
            this.buttonDibujar.Size = new System.Drawing.Size(108, 57);
            this.buttonDibujar.TabIndex = 8;
            this.buttonDibujar.Text = "Dibujar";
            this.buttonDibujar.UseVisualStyleBackColor = false;
            this.buttonDibujar.Click += new System.EventHandler(this.buttonDibujar_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonInfo.FlatAppearance.BorderSize = 2;
            this.buttonInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.Location = new System.Drawing.Point(137, 387);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(108, 57);
            this.buttonInfo.TabIndex = 7;
            this.buttonInfo.Text = "Información";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonGuardar.FlatAppearance.BorderSize = 2;
            this.buttonGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(23, 387);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(108, 57);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(424, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 29);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // radioButtonPoligonoI
            // 
            this.radioButtonPoligonoI.AutoSize = true;
            this.radioButtonPoligonoI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonPoligonoI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPoligonoI.Location = new System.Drawing.Point(29, 170);
            this.radioButtonPoligonoI.Name = "radioButtonPoligonoI";
            this.radioButtonPoligonoI.Size = new System.Drawing.Size(132, 20);
            this.radioButtonPoligonoI.TabIndex = 4;
            this.radioButtonPoligonoI.Text = "Poligono irregular";
            this.radioButtonPoligonoI.UseVisualStyleBackColor = true;
            this.radioButtonPoligonoI.CheckedChanged += new System.EventHandler(this.radioButtonPoligonoI_CheckedChanged);
            // 
            // radioButtonPoligonoR
            // 
            this.radioButtonPoligonoR.AutoSize = true;
            this.radioButtonPoligonoR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonPoligonoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPoligonoR.Location = new System.Drawing.Point(29, 196);
            this.radioButtonPoligonoR.Name = "radioButtonPoligonoR";
            this.radioButtonPoligonoR.Size = new System.Drawing.Size(125, 20);
            this.radioButtonPoligonoR.TabIndex = 3;
            this.radioButtonPoligonoR.Text = "Poligono regular";
            this.radioButtonPoligonoR.UseVisualStyleBackColor = true;
            this.radioButtonPoligonoR.CheckedChanged += new System.EventHandler(this.radioButtonPoligonoR_CheckedChanged);
            // 
            // radioButtonRectangulo
            // 
            this.radioButtonRectangulo.AutoSize = true;
            this.radioButtonRectangulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonRectangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRectangulo.Location = new System.Drawing.Point(29, 246);
            this.radioButtonRectangulo.Name = "radioButtonRectangulo";
            this.radioButtonRectangulo.Size = new System.Drawing.Size(95, 20);
            this.radioButtonRectangulo.TabIndex = 2;
            this.radioButtonRectangulo.Text = "Rectángulo";
            this.radioButtonRectangulo.UseVisualStyleBackColor = true;
            this.radioButtonRectangulo.CheckedChanged += new System.EventHandler(this.radioButtonRectangulo_CheckedChanged);
            // 
            // radioButtonTriangulo
            // 
            this.radioButtonTriangulo.AutoSize = true;
            this.radioButtonTriangulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTriangulo.Location = new System.Drawing.Point(29, 273);
            this.radioButtonTriangulo.Name = "radioButtonTriangulo";
            this.radioButtonTriangulo.Size = new System.Drawing.Size(83, 20);
            this.radioButtonTriangulo.TabIndex = 1;
            this.radioButtonTriangulo.Text = "Triángulo";
            this.radioButtonTriangulo.UseVisualStyleBackColor = true;
            this.radioButtonTriangulo.CheckedChanged += new System.EventHandler(this.radioButtonTriangulo_CheckedChanged);
            // 
            // radioButtonCuadrado
            // 
            this.radioButtonCuadrado.AutoSize = true;
            this.radioButtonCuadrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCuadrado.Location = new System.Drawing.Point(30, 92);
            this.radioButtonCuadrado.Name = "radioButtonCuadrado";
            this.radioButtonCuadrado.Size = new System.Drawing.Size(86, 20);
            this.radioButtonCuadrado.TabIndex = 0;
            this.radioButtonCuadrado.Text = "Cuadrado";
            this.radioButtonCuadrado.UseVisualStyleBackColor = true;
            this.radioButtonCuadrado.CheckedChanged += new System.EventHandler(this.radioButtonCuadrado_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::figuraGeometrica.Properties.Resources.fondo_hd1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 598);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figuras Geometricas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox infoText;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.RadioButton radioButtonEsfera;
        private System.Windows.Forms.RadioButton radioButtonPrisma;
        private System.Windows.Forms.RadioButton radioButtonCubo;
        private System.Windows.Forms.RadioButton radioButtonCirculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.Button buttonDibujar;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonPoligonoI;
        private System.Windows.Forms.RadioButton radioButtonPoligonoR;
        private System.Windows.Forms.RadioButton radioButtonRectangulo;
        private System.Windows.Forms.RadioButton radioButtonTriangulo;
        private System.Windows.Forms.RadioButton radioButtonCuadrado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

