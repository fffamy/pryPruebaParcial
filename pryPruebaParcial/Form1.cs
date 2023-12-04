using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPruebaParcial
{
    public partial class Frm1 : Form
    {
        Random obj = new Random();
        Int32 x = 0;
        Int32 y = 0;
        Int32 ContadorAciertos = 0;
        Int32 ContadorErrores = 0;
        Int32 AcumuladorPuntos = 0;

        public Frm1()
        {
            InitializeComponent();
        }

        private void Frm1_Load(object sender, EventArgs e)
        {
            BtnMayor.Visible = false;
            BtnIgual.Visible = false;
            BtnMenor.Visible = false;
            PctResultados.Image = pryPruebaParcial.Properties.Resources.Coco;
            LblBienvenida.Visible = true;
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            PctResultados.Image = null;
            LblAciertos.Text = null;
            LblErrores.Text = null;
            LblPuntuacion.Text = null;
            LblBienvenida.Visible = false;
            BtnMayor.Visible = true;
            BtnIgual.Visible = true;
            BtnMenor.Visible = true;
            BtnJugar.Visible = false;

            x = obj.Next(1, 11);
            y = obj.Next(1, 11);

            switch (x)
            {
                case 1:
                    PctNum1.Image = pryPruebaParcial.Properties.Resources._0;
                    break;
                case 2:
                    PctNum1.Image = pryPruebaParcial.Properties.Resources._1;
                    break;
                case 3:
                    PctNum1.Image = pryPruebaParcial.Properties.Resources._2;
                    break;
                case 4:
                    PctNum1.Image = pryPruebaParcial.Properties.Resources._3;
                    break;
                case 5:
                    PctNum1.Image = pryPruebaParcial.Properties.Resources._4;
                    break;
                case 6:
                    PctNum1.Image = pryPruebaParcial.Properties.Resources._5;
                    break;
                case 7:
                    PctNum1.Image = pryPruebaParcial.Properties.Resources._6;
                    break;
                case 8:
                    PctNum1.Image = pryPruebaParcial.Properties.Resources._7;
                    break;
                case 9:
                    PctNum1.Image = pryPruebaParcial.Properties.Resources._8;
                    break;
                case 10:
                    PctNum1.Image = pryPruebaParcial.Properties.Resources._9;
                    break;
            }

            switch (y)
            {
                case 1:
                    PctNum2.Image = pryPruebaParcial.Properties.Resources._0;
                    break;
                case 2:
                    PctNum2.Image = pryPruebaParcial.Properties.Resources._1;
                    break;
                case 3:
                    PctNum2.Image = pryPruebaParcial.Properties.Resources._2;
                    break;
                case 4:
                    PctNum2.Image = pryPruebaParcial.Properties.Resources._3;
                    break;
                case 5:
                    PctNum2.Image = pryPruebaParcial.Properties.Resources._4;
                    break;
                case 6:
                    PctNum2.Image = pryPruebaParcial.Properties.Resources._5;
                    break;
                case 7:
                    PctNum2.Image = pryPruebaParcial.Properties.Resources._6;
                    break;
                case 8:
                    PctNum2.Image = pryPruebaParcial.Properties.Resources._7;
                    break;
                case 9:
                    PctNum2.Image = pryPruebaParcial.Properties.Resources._8;
                    break;
                case 10:
                    PctNum2.Image = pryPruebaParcial.Properties.Resources._9;
                    break;
            }
        }

        private void BtnMayor_Click(object sender, EventArgs e)
        {
            BtnJugar.Visible = true;
            BtnMayor.Visible = false;
            BtnIgual.Visible = false;
            BtnMenor.Visible = false;

            if (x > y)
            {
                PctResultados.Image = pryPruebaParcial.Properties.Resources.Bien;
                ContadorAciertos++;
                AcumuladorPuntos = AcumuladorPuntos + 2;
            }
            else
            {
                PctResultados.Image = pryPruebaParcial.Properties.Resources.Mal;
                ContadorErrores++;
                AcumuladorPuntos = AcumuladorPuntos - 1;
            }

            LblAciertos.Text = "Total de aciertos: " + ContadorAciertos.ToString();
            LblErrores.Text = "Total de errores: " + ContadorErrores.ToString();
            LblPuntuacion.Text = "Puntuacion total: " + AcumuladorPuntos.ToString();

            if (AcumuladorPuntos > 10)
            {
                PctResultados.Image = pryPruebaParcial.Properties.Resources.CocoFeliz;
                MessageBox.Show("Ganaste!");
                LblAciertos.Text = "La cantidad de aciertos fue: " + ContadorAciertos;
                LblErrores.Text = "La cantidad de errores fue: " + ContadorErrores;
                LblPuntuacion.Text = "La puntuacion total fue: " + AcumuladorPuntos;
                AcumuladorPuntos = 0;
                ContadorAciertos = 0;
                ContadorErrores = 0;
                BtnMayor.Visible = false;
                BtnIgual.Visible = false;
                BtnMenor.Visible = false;
                PctNum1.Image = null;
                PctNum2.Image = null;
            }
            if (AcumuladorPuntos < 0)
            {
                PctResultados.Image = pryPruebaParcial.Properties.Resources.CocoTriste;
                MessageBox.Show("Perdiste! :(");
                LblAciertos.Text = "La cantidad de aciertos fue: " + ContadorAciertos;
                LblErrores.Text = "La cantidad de errores fue: " + ContadorErrores;
                LblPuntuacion.Text = "La puntuacion total fue: 0";
                AcumuladorPuntos = 0;
                ContadorAciertos = 0;
                ContadorErrores = 0;
                BtnMayor.Visible = false;
                BtnIgual.Visible = false;
                BtnMenor.Visible = false;
                PctNum1.Image = null;
                PctNum2.Image = null;
            }
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            BtnJugar.Visible = true;
            BtnMayor.Visible = false;
            BtnIgual.Visible = false;
            BtnMenor.Visible = false;

            if (x == y)
            {
                PctResultados.Image = pryPruebaParcial.Properties.Resources.Bien;
                ContadorAciertos++;
                AcumuladorPuntos = AcumuladorPuntos + 2;
            }
            else
            {
                PctResultados.Image = pryPruebaParcial.Properties.Resources.Mal;
                ContadorErrores++;
                AcumuladorPuntos = AcumuladorPuntos - 1;
            }

            LblAciertos.Text = "Total de aciertos: " + ContadorAciertos.ToString();
            LblErrores.Text = "Total de errores: " + ContadorErrores.ToString();
            LblPuntuacion.Text = "Puntuacion total: " + AcumuladorPuntos.ToString();

            if (AcumuladorPuntos > 10)
            {
                PctResultados.Image = pryPruebaParcial.Properties.Resources.CocoFeliz;
                MessageBox.Show("Ganaste!");
                LblAciertos.Text = "La cantidad de aciertos fue: " + ContadorAciertos;
                LblErrores.Text = "La cantidad de errores fue: " + ContadorErrores;
                LblPuntuacion.Text = "La puntuacion total fue: " + AcumuladorPuntos;
                AcumuladorPuntos = 0;
                ContadorAciertos = 0;
                ContadorErrores = 0;
                BtnMayor.Visible = false;
                BtnIgual.Visible = false;
                BtnMenor.Visible = false;
                PctNum1.Image = null;
                PctNum2.Image = null;
            }
            if (AcumuladorPuntos < 0)
            {
                PctResultados.Image = pryPruebaParcial.Properties.Resources.CocoTriste;
                MessageBox.Show("Perdiste! :(");
                LblAciertos.Text = "La cantidad de aciertos fue: " + ContadorAciertos;
                LblErrores.Text = "La cantidad de errores fue: " + ContadorErrores;
                LblPuntuacion.Text = "La puntuacion total fue: 0";
                AcumuladorPuntos = 0;
                ContadorAciertos = 0;
                ContadorErrores = 0;
                BtnMayor.Visible = false;
                BtnIgual.Visible = false;
                BtnMenor.Visible = false;
                PctNum1.Image = null;
                PctNum2.Image = null;
            }
        }

        private void BtnMenor_Click(object sender, EventArgs e)
        {
            BtnJugar.Visible = true;
            BtnMayor.Visible = false;
            BtnIgual.Visible = false;
            BtnMenor.Visible = false;

            if (x < y)
            {
                PctResultados.Image = pryPruebaParcial.Properties.Resources.Bien;
                ContadorAciertos++;
                AcumuladorPuntos = AcumuladorPuntos + 2;
            }
            else
            {
                PctResultados.Image = pryPruebaParcial.Properties.Resources.Mal;
                ContadorErrores++;
                AcumuladorPuntos = AcumuladorPuntos - 1;
            }

            LblAciertos.Text = "Total de aciertos: " + ContadorAciertos.ToString();
            LblErrores.Text = "Total de errores: " + ContadorErrores.ToString();
            LblPuntuacion.Text = "Puntuacion total: " + AcumuladorPuntos.ToString();

            if (AcumuladorPuntos > 10)
            {
                PctResultados.Image = pryPruebaParcial.Properties.Resources.CocoFeliz;
                MessageBox.Show("Ganaste!");
                LblAciertos.Text = "La cantidad de aciertos fue: " + ContadorAciertos;
                LblErrores.Text = "La cantidad de errores fue: " + ContadorErrores;
                LblPuntuacion.Text = "La puntuacion total fue: " + AcumuladorPuntos;
                AcumuladorPuntos = 0;
                ContadorAciertos = 0;
                ContadorErrores = 0;
                BtnMayor.Visible = false;
                BtnIgual.Visible = false;
                BtnMenor.Visible = false;
                PctNum1.Image = null;
                PctNum2.Image = null;
            }
            if (AcumuladorPuntos < 0)
            {
                PctResultados.Image = pryPruebaParcial.Properties.Resources.CocoTriste;
                MessageBox.Show("Perdiste! :(");
                LblAciertos.Text = "La cantidad de aciertos fue: " + ContadorAciertos;
                LblErrores.Text = "La cantidad de errores fue: " + ContadorErrores;
                LblPuntuacion.Text = "La puntuacion total fue: 0";
                AcumuladorPuntos = 0;
                ContadorAciertos = 0;
                ContadorErrores = 0;
                BtnMayor.Visible = false;
                BtnIgual.Visible = false;
                BtnMenor.Visible = false;
                PctNum1.Image = null;
                PctNum2.Image = null;
            }
        }
    }
}
