using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_UnitTest_EricPastor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Geometria geo = new Geometria();
            switch (geo.figura(Convert.ToInt32(TB_opcion.Text)))
            {
                case "cuadrado":
                    MessageBox.Show("El resultado es: " + geo.areacuadrado(Convert.ToInt32(TB_num1.Text)));
                    break;
                case "Circulo":
                    MessageBox.Show("El resultado es: " + geo.areaCirculo(Convert.ToInt32(TB_num1.Text)));
                    break;
                case "Triangulo":
                    MessageBox.Show("El resultado es: " + geo.areatriangulo(Convert.ToInt32(TB_num1.Text),Convert.ToInt32(TB_num2.Text)));
                    break;
                case "Rectangulo":
                    MessageBox.Show("El resultado es: " + geo.arearectangulo(Convert.ToInt32(TB_num1.Text), Convert.ToInt32(TB_num2.Text)));
                    break;
                case "Pentagono":
                    MessageBox.Show("El resultado es: " + geo.areapentagono(Convert.ToInt32(TB_num1.Text),Convert.ToInt32(TB_num2.Text)));
                    break;
                case "Rombo":
                    MessageBox.Show("El resultado es: " + geo.arearombo(Convert.ToInt32(TB_num1.Text), Convert.ToInt32(TB_num2.Text)));
                    break;
                case "Romboide":
                    MessageBox.Show("El resultado es: " + geo.arearomboide(Convert.ToInt32(TB_num1.Text), Convert.ToInt32(TB_num2.Text)));
                    break;
                case "Trapecio":
                    MessageBox.Show("El resultado es: " + geo.areatrapecio(Convert.ToInt32(TB_num1.Text), Convert.ToInt32(TB_num2.Text), Convert.ToInt32(TB_num3.Text)));
                    break;
                default:
                    break;
            }
        }
    }
}
