using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string textoenpantalla = "";
        Double NumeroUno;
        Double NumeroDos;
        String Operacion;
        private void Btnuno_Click(object sender, EventArgs e)
        {
            string uno = "1";

            txtPantalla.Text = txtPantalla.Text + "1";
        }

        private void Btndos_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "2";
        }

        private void Btntres_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "3";
        }

        private void Btncuadro_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "4";
        }

      
        private void Btncinco_Click(object sender, EventArgs e)
        {
           txtPantalla.Text = txtPantalla.Text + "5";
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "6";
        }

        private void Btnsiete_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void Btnocho_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void Btnnueve_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "9";
        }

        private void Btncero_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }

        private void Btnpuntodecimal_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + ".";
        }

        private void Btnigual_Click(object sender, EventArgs e)
        {
            //NumeroDos = Convert.ToDouble(txtPantalla.Text);
            switch (Operacion)
            {
                case "+":
                    NumeroDos = Convert.ToDouble(txtPantalla.Text);
                    txtPantalla.Text = Convert.ToString(NumeroUno + NumeroDos);
                    break;
                case "-":
                    NumeroDos = Convert.ToDouble(txtPantalla.Text);
                    txtPantalla.Text = Convert.ToString(NumeroUno - NumeroDos);
                    break;
                case "x":
                    NumeroDos = Convert.ToDouble(txtPantalla.Text);
                    txtPantalla.Text = Convert.ToString(NumeroUno * NumeroDos);
                    break;
                case "÷":
                    NumeroDos = Convert.ToDouble(txtPantalla.Text);
                    txtPantalla.Text = Convert.ToString(NumeroUno / NumeroDos);
                    break;
                case "Sin":
                    txtPantalla.Text = Convert.ToString(Math.Sin(NumeroUno));
                    break;
                case "Cos":
                    txtPantalla.Text = Convert.ToString(Math.Cos(NumeroUno));
                    break;
                case "Tan":
                    txtPantalla.Text = Convert.ToString(Math.Tanh(NumeroUno));
                    break;
                case "Raiz":
                    txtPantalla.Text = Convert.ToString(Math.Sqrt(NumeroUno));
                    break;
                case "ln":
                    txtPantalla.Text = Convert.ToString(Math.Log(NumeroUno));
                    break;
                case "log":
                    txtPantalla.Text = Convert.ToString(Math.Log10(NumeroUno));
                    break;
                case "!":
                    byte num, i;
                    long result = 1;

                    num = Convert.ToByte(NumeroUno);
                    for (i = 2; i <= num; i++)
                    {
                        result = result * i;
                    }
                    txtPantalla.Text = Convert.ToString(result);
                    break;
            }
        }

        private void btnMulpliacion_Click(object sender, EventArgs e)
        {
            NumeroUno = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = txtPantalla.Text + "x";
            Operacion = "x";
            txtPantalla.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            NumeroUno = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = txtPantalla.Text + "/";
            Operacion = "÷";
            txtPantalla.Clear();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            NumeroUno = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = txtPantalla.Text + "+";
            txtPantalla.Clear();
        }

        private void butnResta_Click(object sender, EventArgs e)
        {
            NumeroUno = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = txtPantalla.Text + "-";
            Operacion = "-";
            txtPantalla.Clear();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text.Remove(txtPantalla.Text.Length - 1);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSeno_Click(object sender, EventArgs e)
        {
            NumeroUno = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = "Sin("+ txtPantalla.Text+")";
            Operacion = "Sin";
            txtPantalla.Clear();
            txtPantalla.Text = "Sin(" + NumeroUno + ")";

        }

        private void BtnCoseno_Click(object sender, EventArgs e)
        {
            NumeroUno = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = txtPantalla.Text + "Cos";
            Operacion = "Cos";
            txtPantalla.Clear();
            txtPantalla.Text = "Cos(" + NumeroUno + ")";

        }

        private void BtnTangente_Click(object sender, EventArgs e)
        {
            NumeroUno = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = txtPantalla.Text + "Tan";
            Operacion = "Tan";
            txtPantalla.Clear();
            txtPantalla.Text = "Tan(" + NumeroUno + ")";

        }

        private void BtnRaiz_Click(object sender, EventArgs e)
        {
            NumeroUno = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = txtPantalla.Text + "Raiz";
            Operacion = "Raiz";
            txtPantalla.Clear();
            txtPantalla.Text = "√" + NumeroUno + "";

        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            NumeroUno = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = txtPantalla.Text + "log";
            Operacion = "log";
            txtPantalla.Clear();
            txtPantalla.Text = "Log(" + NumeroUno + ")";

        }

        private void BtnLogaritmonatural_Click(object sender, EventArgs e)
        {
            NumeroUno = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = txtPantalla.Text + "ln";
            Operacion = "ln";
            txtPantalla.Clear();
            txtPantalla.Text = "ln(" + NumeroUno + ")";


        }

        private void BtnFactorial_Click(object sender, EventArgs e)
        {
            NumeroUno = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = txtPantalla.Text + "!";
            Operacion = "!";
            txtPantalla.Clear();
            txtPantalla.Text = "!" + NumeroUno + "";



        }
    }
}
