using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog exportar = new SaveFileDialog();
            exportar.Filter = "Documento de texto|*.txt";
            exportar.Title = "Guardar";
            exportar.FileName = "Sin título 1";
            var resultado = exportar.ShowDialog();
            if (resultado==DialogResult.OK)
            {
                StreamWriter escribir = new StreamWriter(exportar.FileName);
                foreach (object line in infoText.Lines)
                {
                    escribir.WriteLine(line);
                }
                escribir.Close();
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (radioButtonCirculo.Checked)
            {
                infoText.Text = "El círculo es una figura geométrica que se realiza trazando una curva que está siempre a la misma distancia de un punto que llamamos centro";
            }
            else
            {
                if (radioButtonCuadrado.Checked)
                {
                    infoText.Text = "El cuadrado es una figura geométrica que pertenece a los paralelogramos porque tiene 4 lados. Los 4 lados miden lo mismo y son paralelos dos a dos. ¿Esto que quiere decir? Que tiene 2 lados paralelos entre sí, y los otros 2 también son paralelos entre sí.";
                }
                else
                {
                    if (radioButtonCubo.Checked)
                    {
                        infoText.Text = "En la geometría, un cubo es un cuerpo formado por seis caras que son cuadradas. La particularidad de estos cuerpos es que todas las caras son congruentes, están dispuestas de forma paralela y de a pares, y tienen cuatro lados.";
                    }
                    else
                    {
                        if (radioButtonEsfera.Checked)
                        {
                            infoText.Text = "En geometría, una superficie esférica es una superficie de revolución formada por el conjunto de todos los puntos del espacio que equidistan de un punto llamado centro. ";
                        }
                        else
                        {
                            if (radioButtonPoligonoI.Checked)
                            {
                                infoText.Text = "Un polígono irregular es aquella figura geométrica que no cumple con la condición de regularidad. Es decir, no se cumple que todos sus lados tengan la misma longitud ni tampoco sus ángulos interiores comparten la misma medida.";
                            }
                            else
                            {
                                if (radioButtonPoligonoR.Checked)
                                {
                                    infoText.Text = "Polígono regular: Aquellos que tienen todos sus lados de igual longitud y todos sus ángulos internos iguales, es decir, son simultáneamente equiláteros y equiangulares.";
                                }
                                else
                                {
                                    if (radioButtonPrisma.Checked)
                                    {
                                        infoText.Text = "Cuerpo limitado por dos polígonos planos, paralelos e iguales, que se llaman bases, y por tantos paralelogramos cuantos lados tengan dichas bases, las cuales, según su forma, dan nombre al prisma: triangular, pentagonal, etcétera.";
                                    }
                                    else
                                    {
                                        if (radioButtonRectangulo.Checked)
                                        {
                                            infoText.Text = "El rectángulo es un cuadrilátero, específicamente un paralelogramo, que tiene dos pares de lados de igual longitud. A su vez, todos los ángulos interiores son rectos, es decir, miden 90º.";
                                        }
                                        else
                                        {
                                            if (radioButtonTriangulo.Checked)
                                            {
                                                infoText.Text = "El triángulo es un polígono conformado por tres lados, así como por tres vértices y tres ángulos interiores.";
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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos guardados","Guardar",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
