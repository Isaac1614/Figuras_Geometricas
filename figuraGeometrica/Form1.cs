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
            pictureBox1.Image = (figuraGeometrica.Properties.Resources.predeterminado);
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
            infoText.Clear();
            radioButtonCirculo.Checked = false;
            radioButtonCuadrado.Checked = false;
            radioButtonCubo.Checked = false;
            radioButtonEsfera.Checked = false;
            radioButtonPoligonoI.Checked = false;
            radioButtonPoligonoR.Checked = false;
            radioButtonPrisma.Checked = false;
            radioButtonRectangulo.Checked = false;
            radioButtonTriangulo.Checked = false;
        }

        private void buttonDibujar_Click(object sender, EventArgs e)
        {
            if (radioButtonCirculo.Checked)
            {
                pictureBox1.Image = (figuraGeometrica.Properties.Resources.circulo);
                //pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            }
            else if (radioButtonCuadrado.Checked)
            {
                pictureBox1.Image = (figuraGeometrica.Properties.Resources.cuadrado);
            }
            else if (radioButtonCubo.Checked)
            {
                pictureBox1.Image = (figuraGeometrica.Properties.Resources.cubo);
            }
            else if (radioButtonEsfera.Checked)
            {
                pictureBox1.Image = (figuraGeometrica.Properties.Resources.esfera);
            }
            else if (radioButtonPoligonoI.Checked)
            {
                pictureBox1.Image = (figuraGeometrica.Properties.Resources.trapecio);
            }
            else if (radioButtonPoligonoR.Checked)
            {
                pictureBox1.Image = (figuraGeometrica.Properties.Resources.poligonoregular);
            }
            else if (radioButtonPrisma.Checked)
            {
                pictureBox1.Image = (figuraGeometrica.Properties.Resources.prisma);
            }
            else if (radioButtonRectangulo.Checked)
            {
                pictureBox1.Image = (figuraGeometrica.Properties.Resources.rectangulo);
            }
            else if (radioButtonTriangulo.Checked)
            {
                pictureBox1.Image = (figuraGeometrica.Properties.Resources.triangulo);
            }
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            try //EXCEPCIÓN
            {
                string fileName = @"C:\Users\arsek\source\repos\Isaac1614\Figuras_Geometricas\figuraGeometrica\Datos\info.txt";
                // esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = File.AppendText(fileName);
                //  writer.WriteLine("Este es un dato nuevo desde guardar");
                writer.WriteLine("Datos: " + textBox1.Text);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar Datos en el Archivo", "ERROR 404",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*SaveFileDialog exportar = new SaveFileDialog();
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
            }*/
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (radioButtonCirculo.Checked)
            {
                infoText.Text = "Figura seleccionada: Circulo, " + "\n" + "Sus datos son:" + "\n" + "Longitud del lado: " + textBox1.Text;
            }
            else if (radioButtonCuadrado.Checked)
            {
                infoText.Text = "Figura seleccionada: Cuadrado, " + "\n" + "Sus datos son:" + "\n" + "Longitud del lado: "+ textBox1.Text;
            }
            else if (radioButtonCubo.Checked)
            {
                infoText.Text = "Figura seleccionada: Cubo, " + "\n" + "Sus datos son:" + "\n" + "Longitud del lado: " + textBox1.Text;
            }
            else if (radioButtonEsfera.Checked)
            {
                infoText.Text = "Figura seleccionada: Esfera, " + "\n" + "Sus datos son:" + "\n" + "Longitud del lado: " + textBox1.Text;
            }
            else if (radioButtonPoligonoI.Checked)
            {
                infoText.Text = "Figura seleccionada: Poligono Irregular, " + "\n" + "Sus datos son:" + "\n" + "Longitud del lado: " + textBox1.Text;
            }
            else if (radioButtonPoligonoR.Checked)
            {
                infoText.Text = "Figura seleccionada: Poligono Regular, " + "\n" + "Sus datos son:" + "\n" + "Longitud del lado: " + textBox1.Text;
            }
            else if (radioButtonPrisma.Checked)
            {
                infoText.Text = "Figura seleccionada: Prisma, " + "\n" + "Sus datos son:" + "\n" + "Longitud del lado: " + textBox1.Text;
            }
            else if (radioButtonRectangulo.Checked)
            {
                infoText.Text = "Figura seleccionada: Rectangulo, " + "\n" + "Sus datos son:" + "\n" + "Longitud del lado: " + textBox1.Text;
            }
            else if (radioButtonTriangulo.Checked)
            {
                infoText.Text = "Figura seleccionada: Triangulo, " + "\n" + "Sus datos son:" + "\n" + "Longitud del lado: " + textBox1.Text;
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos guardados "+ textBox1.Text,"Guardar",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (radioButtonCirculo.Checked)
            {
                float rad1 = float.Parse(textBox1.Text);
                Circulo circulo = new Circulo(rad1);
                infoText.Text = infoText.Text + "\n" + "Area = "+ circulo.area() + "\n" + "Perimetro = "+circulo.perimetro() + "\n" + "Volumen, no se calcula en figuras planas " + "\n";
            }
            else if (radioButtonCuadrado.Checked)
            {
                float lad1 = float.Parse(textBox1.Text);
                Cuadrado cuadrado = new Cuadrado(lad1);
                infoText.Text = infoText.Text + "\n" + "Area = " + cuadrado.area()  + "\n" + "Perimetro = "+ cuadrado.perimetro() + "\n" + "Volumen, no se calcula en figuras planas " + "\n";
            }
            else if (radioButtonCubo.Checked)
            {
                float lad1 = float.Parse(textBox1.Text);
                Cubo cubo = new Cubo(lad1);
                infoText.Text = infoText.Text + "\n" + "Area = "+ cubo.area() + "\n" + "Perimetro = "+ cubo.perimetro() + "\n" + "Volumen = "+ cubo.volumen() + "\n";
            }
            else if (radioButtonEsfera.Checked)
            {
                float rad1 = float.Parse(textBox1.Text);
                Esfera esfera = new Esfera(rad1);
                infoText.Text = infoText.Text+ "\n" + "Area = " +esfera.area()+ "\n" + "Perimetro = Noaplica " + "\n" + "Volumen= "+ esfera.volumen() + "\n";
            }
            else if (radioButtonPoligonoI.Checked)
            {
                infoText.Text = infoText.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas " + "\n";
            }
            else if (radioButtonPoligonoR.Checked)
            {
                infoText.Text = infoText.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas " + "\n";
            }
            else if (radioButtonPrisma.Checked)
            {
                float lad1= float.Parse(textBox1.Text);
                float lad2 = float.Parse(textBox1.Text);
                float lad3 = float.Parse(textBox1.Text);
                Prisma prisma = new Prisma(lad1,lad2,lad3);
                infoText.Text = infoText.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen= " + "\n";
            }
            else if (radioButtonRectangulo.Checked)
            {
                float alt1 = float.Parse(textBox1.Text);
                float bas1 = float.Parse(textBox1.Text);
                Rectangulo rectangulo = new Rectangulo(bas1,alt1);
                infoText.Text = infoText.Text + "\n" + "Area = " + "\n"+ rectangulo.area() + "Perimetro = "+ rectangulo.perimetro() + "\n" + "Volumen, no se calcula en figuras planas " + "\n";
            }
            else if (radioButtonTriangulo.Checked)
            {
                float alt1 = float.Parse(textBox1.Text);
                float bas1 = float.Parse(textBox1.Text);
                Triangulo triangulo = new Triangulo(bas1, alt1);
                infoText.Text = infoText.Text + "\n" + "Area = "+ triangulo.area() + "\n" + "Perimetro = "+triangulo.perimetro() + "\n" + "Volumen, no se calcula en figuras planas " + "\n";
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
