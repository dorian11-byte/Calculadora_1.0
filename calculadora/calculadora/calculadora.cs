using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    
    public partial class calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public calculadora()
        {
            InitializeComponent();
        }

        CLASES.clsSuma obj = new CLASES.clsSuma();
        CLASES.clsResta obj2 = new CLASES.clsResta();
        CLASES.clsMultiplicacion obj3 = new CLASES.clsMultiplicacion();
        CLASES.clsDivision obj4 = new CLASES.clsDivision();
        CLASES.clsPorcentaje obj5 = new CLASES.clsPorcentaje();
        private void Button1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void Btnpunto_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";
        }

        private void Btnsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Btnresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Btnmulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Btndiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Btnporcen_Click(object sender, EventArgs e)
        {
            operador = "%";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxScreen.Text);

            double sum;
            double res;
            double multi;
            double div;
            double porce;
            switch(operador)
            {
                case "+":
                    sum = obj.Sumar((primero), (segundo));
                    tbxScreen.Text = sum.ToString();
                    break;

                case "-":
                    res = obj2.Restar((primero), (segundo));
                    tbxScreen.Text = res.ToString();
                    break;

                case "*":
                    multi = obj3.Multiplicar((primero), (segundo));
                    tbxScreen.Text = multi.ToString();
                    break;

                case "/":
                    div = obj4.Dividir((primero), (segundo));
                    tbxScreen.Text = div.ToString();
                    break;

                case "%":
                    porce = obj5.Porcentaje((primero), (segundo));
                    tbxScreen.Text = porce.ToString();
                    break; 


            }
        }

        private void Btnborrar_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }

        private void Btnborra_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }

        private void DimGray(object sender, KeyPressEventArgs e)
        {

        }
    }
}
