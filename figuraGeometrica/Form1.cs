﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figuraGeometrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonCuadrado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\arsek\\Source\\Repos\\Isaac1614\\Figuras_Geometricas\\figuraGeometrica\\imagenes\\predeterminado.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
        }

        private void radioButtonTriangulo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonRectangulo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPoligonoR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPoligonoI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCirculo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCubo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPrisma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonEsfera_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonDibujar_Click(object sender, EventArgs e)
        {
            if (radioButtonCirculo.Checked)
            {
                string rutaImagen = "C:\\Users\\arsek\\Source\\Repos\\Isaac1614\\Figuras_Geometricas\\figuraGeometrica\\imagenes\\circulo.jpg";
                pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            }
            else
            {
                if (radioButtonCuadrado.Checked)
                {
                    string rutaImagen = "C:\\Users\\arsek\\Source\\Repos\\Isaac1614\\Figuras_Geometricas\\figuraGeometrica\\imagenes\\cuadrado.jpg";
                    pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
                }
                else
                {
                    if (radioButtonCubo.Checked)
                    {
                        string rutaImagen = "C:\\Users\\arsek\\Source\\Repos\\Isaac1614\\Figuras_Geometricas\\figuraGeometrica\\imagenes\\cubo.jpg";
                        pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
                    }
                    else
                    {
                        if (radioButtonEsfera.Checked)
                        {
                            string rutaImagen = "C:\\Users\\arsek\\Source\\Repos\\Isaac1614\\Figuras_Geometricas\\figuraGeometrica\\imagenes\\esfera.png";
                            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
                        }
                        else
                        {
                            if (radioButtonPoligonoI.Checked)
                            {
                                string rutaImagen = "C:\\Users\\arsek\\Source\\Repos\\Isaac1614\\Figuras_Geometricas\\figuraGeometrica\\imagenes\\trapecio.png";
                                pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
                            }
                            else
                            {
                                if (radioButtonPoligonoR.Checked)
                                {
                                    string rutaImagen = "C:\\Users\\arsek\\Source\\Repos\\Isaac1614\\Figuras_Geometricas\\figuraGeometrica\\imagenes\\poligonoregular.png";
                                    pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
                                }
                                else
                                {
                                    if (radioButtonPrisma.Checked)
                                    {
                                        string rutaImagen = "C:\\Users\\arsek\\Source\\Repos\\Isaac1614\\Figuras_Geometricas\\figuraGeometrica\\imagenes\\prisma.png";
                                        pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
                                    }
                                    else
                                    {
                                        if (radioButtonRectangulo.Checked)
                                        {
                                            string rutaImagen = "C:\\Users\\arsek\\Source\\Repos\\Isaac1614\\Figuras_Geometricas\\figuraGeometrica\\imagenes\\rectangulo.jpg";
                                            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
                                        }
                                        else
                                        {
                                            if (radioButtonTriangulo.Checked)
                                            {
                                                string rutaImagen = "C:\\Users\\arsek\\Source\\Repos\\Isaac1614\\Figuras_Geometricas\\figuraGeometrica\\imagenes\\triangulo.jpg";
                                                pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
