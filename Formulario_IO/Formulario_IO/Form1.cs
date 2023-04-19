using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formulario_IO
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.BlueGrey500, Accent.Green700, TextShade.WHITE);
            iniT1();
          
        }
        public void iniT1()
        {
            GB_Formula1.Visible = true;
            GB_Formula2.Visible = false;
            GB_Formula3.Visible = false;
            GB_Formula4.Visible = false;
            GB_Formula5.Visible = false;
            GB_Formula6.Visible = false;
            GB_Formula7.Visible = false;
            GB_Formula8.Visible = false;

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (T1cb.SelectedIndex)
            {
                case 0:
                    GB_Formula1.Visible = true;
                    GB_Formula2.Visible = false;
                    GB_Formula3.Visible = false;
                    GB_Formula4.Visible = false;
                    GB_Formula5.Visible = false;
                    GB_Formula6.Visible = false;
                    GB_Formula7.Visible = false;
                    GB_Formula8.Visible = false;
                    break;
                case 1:
                    GB_Formula1.Visible = false;
                    GB_Formula2.Visible = true;
                    GB_Formula3.Visible = false;
                    GB_Formula4.Visible = false;
                    GB_Formula5.Visible = false;
                    GB_Formula6.Visible = false;
                    GB_Formula7.Visible = false;
                    GB_Formula8.Visible = false;
                    break;
                case 2:
                    GB_Formula1.Visible = false;
                    GB_Formula2.Visible = false;
                    GB_Formula3.Visible = true;
                    GB_Formula4.Visible = false;
                    GB_Formula5.Visible = false;
                    GB_Formula6.Visible = false;
                    GB_Formula7.Visible = false;
                    GB_Formula8.Visible = false;
                    break;
                case 3:
                    GB_Formula1.Visible = false;
                    GB_Formula2.Visible = false;
                    GB_Formula3.Visible = false;
                    GB_Formula4.Visible = true;
                    GB_Formula5.Visible = false;
                    GB_Formula6.Visible = false;
                    GB_Formula7.Visible = false;
                    GB_Formula8.Visible = false;
                    break;
                case 4:
                    GB_Formula1.Visible = false;
                    GB_Formula2.Visible = false;
                    GB_Formula3.Visible = false;
                    GB_Formula4.Visible = false;
                    GB_Formula5.Visible = true;
                    GB_Formula6.Visible = false;
                    GB_Formula7.Visible = false;
                    GB_Formula8.Visible = false;
                    break;
                case 5:
                    GB_Formula1.Visible = false;
                    GB_Formula2.Visible = false;
                    GB_Formula3.Visible = false;
                    GB_Formula4.Visible = false;
                    GB_Formula5.Visible = false;
                    GB_Formula6.Visible = true;
                    GB_Formula7.Visible = false;
                    GB_Formula8.Visible = false;
                    break;
                case 6:
                    GB_Formula1.Visible = false;
                    GB_Formula2.Visible = false;
                    GB_Formula3.Visible = false;
                    GB_Formula4.Visible = false;
                    GB_Formula5.Visible = false;
                    GB_Formula6.Visible = false;
                    GB_Formula7.Visible = true;
                    GB_Formula8.Visible = false;
                    break;
                case 7:
                    GB_Formula1.Visible = false;
                    GB_Formula2.Visible = false;
                    GB_Formula3.Visible = false;
                    GB_Formula4.Visible = false;
                    GB_Formula5.Visible = false;
                    GB_Formula6.Visible = false;
                    GB_Formula7.Visible = false;
                    GB_Formula8.Visible = true;
                    break;
                default:
                    GB_Formula1.Visible = false;
                    GB_Formula2.Visible = false;
                    GB_Formula3.Visible = false;
                    GB_Formula4.Visible = false;
                    GB_Formula5.Visible = false;
                    GB_Formula6.Visible = false;
                    GB_Formula7.Visible = false;
                    GB_Formula8.Visible = false;
                    break;
            }
        }


        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Verificar si el objeto TextBox se ha inicializado correctamente
            if (sender != null && sender is MaterialTextBox)
            {
                // Verificar si el caracter presionado es un número o un punto decimal
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                // Permitir solo un punto decimal
                if (e.KeyChar == '.' && (sender as MaterialTextBox).Text.IndexOf('.') >= 1)
                {
                    e.Handled = true;
                }
            }
        }


        public static double formula_1(double d, double K, double c, double Q, double h)
        {
           // Console.WriteLine(((d * K) / Q) + (d * c) + ((h * Q) / 2));
            return ((d * K) / Q) + (d * c) + ((h * Q) / 2);
        }
        public static double formula_2(double k, double d, double h)
        {
            return Math.Sqrt(((2 * (d * k)) / h));
        }
        public static double formula_3(double l, double c)
        {
            return l * c;
        }
        public static double formula_4(double k, double d, double h)
        {

            return Math.Sqrt(((2 * k) / (d * h)));
        }
        public static double formula_5(double D, double Q)
        {
            return D / Q;
        }
        public static double formula_6(double L, double D)
        {
            return L * D;
        }
        public static double formula_7(double Le, double D)
        {
            return Le * D;
        }
        public static double formula_8(double L, double n, double t)
        {
            return L - n * t;
        }

        public void materialFloatingActionButton9_Click(object sender, EventArgs e)
        {
            try
            {
                if (T1cb.SelectedIndex == 0)
                {
                    T1tbF1_T.Text = formula_1(double.Parse(T1tbF1_d.Text), double.Parse(T1tbF1_K.Text), double.Parse(T1tbF1_c.Text), double.Parse(T1tbF1_Q1.Text), double.Parse(T1tbF1_h.Text)).ToString();
                }
                if (T1cb.SelectedIndex == 1)
                {
                    T1tbF2_Q.Text = formula_2(double.Parse(T1tbF2_d.Text), double.Parse(T1tbF2_K.Text), double.Parse(T1tbF2_h.Text)).ToString();

                }
                if (T1cb.SelectedIndex == 2)
                {
                    T1tbF3_h.Text = formula_3(double.Parse(T1tbF3_l.Text), double.Parse(T1tbF3_c.Text)).ToString();

                }
                if (T1cb.SelectedIndex == 3)
                {
                    T1tbF4_t.Text = formula_4(double.Parse(T1tbF4_K.Text), double.Parse(T1tbF4_d.Text), double.Parse(T1tbF4_h.Text)).ToString();

                }
                if (T1cb.SelectedIndex == 4)
                {
                    T1tbF5_N.Text = formula_5(double.Parse(T1tbF5_D.Text), double.Parse(T1tbF5_Q.Text)).ToString();

                }
                if (T1cb.SelectedIndex == 5)
                {
                    T1tbF6_PdR.Text = formula_6(double.Parse(T1tbF6_L.Text), double.Parse(T1tbF6_D.Text)).ToString();

                }
                if (T1cb.SelectedIndex == 6)
                {
                    T1tbF7_pdr.Text = formula_7(double.Parse(T1tbF7_Le.Text), double.Parse(T1tbF7_D.Text)).ToString();

                }
                if (T1cb.SelectedIndex == 7)
                {
                    T1tbF8_pdr.Text = formula_8(double.Parse(T1tbF8_L.Text), double.Parse(T1tbF8_n.Text), double.Parse(T1tbF8_t.Text)).ToString();

                } // Código que puede lanzar una excepción
            }
            catch (Exception excepcionA)
            {
                MaterialMessageBox.Show("te faltan datos \nRevisale bien🤙",true);
            }
            
        
        }

        private void T1tbF1_d_KeyUp(object sender, KeyEventArgs e)
        {
            T1tbF1_d2.Text = T1tbF1_d.Text;
        }

        private void T1tbF1_Q1_KeyUp(object sender, KeyEventArgs e)
        {
            T1tbF1_Q2.Text = T1tbF1_Q1.Text;


        }

        private void materialFloatingActionButton5_Click(object sender, EventArgs e)
        {
            switch (T1cb.SelectedIndex)
            {
                case 0:

                    T1tbF1_T.Text = string.Empty; 
                    T1tbF1_d.Text = string.Empty;
                    T1tbF1_d2.Text = string.Empty;
                    T1tbF1_K.Text = string.Empty;
                    T1tbF1_c.Text = string.Empty;
                    T1tbF1_Q1.Text = string.Empty;
                    T1tbF1_Q2.Text = string.Empty;
                    T1tbF1_h.Text = string.Empty;
                    break;
                case 1:
                    T1tbF2_Q.Text = string.Empty; 
                    T1tbF2_d.Text = string.Empty;
                    T1tbF2_K.Text = string.Empty;
                    T1tbF2_h.Text = string.Empty;
                    break;
                case 2:
                    T1tbF3_h.Text = string.Empty;
                    T1tbF3_l.Text = string.Empty;
                    T1tbF3_c.Text = string.Empty;
                    break;
                case 3:
                    T1tbF4_t.Text = string.Empty; 
                    T1tbF4_K.Text = string.Empty;
                    T1tbF4_d.Text = string.Empty; 
                    T1tbF4_h.Text = string.Empty;
                    break;
                case 4:
                    T1tbF5_N.Text = string.Empty;
                    T1tbF5_D.Text = string.Empty;
                    T1tbF5_Q.Text = string.Empty;
                    break;
                case 5:
                    T1tbF6_PdR.Text = string.Empty;
                    T1tbF6_L.Text = string.Empty;
                    T1tbF6_D.Text = string.Empty;
                    break;
                case 6:
                    T1tbF7_pdr.Text = string.Empty; 
                    T1tbF7_Le.Text = string.Empty; 
                    T1tbF7_D.Text = string.Empty;
                    break;
                case 7:
                    T1tbF8_pdr.Text = string.Empty;
                    T1tbF8_L.Text = string.Empty; 
                    T1tbF8_n.Text = string.Empty;
                    T1tbF8_t.Text = string.Empty;

                    break;
                default:
                    //👌
                    break;
            }
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            T1tbF1_T.Text = formula_1(double.Parse(T1tbF1_d.Text), double.Parse(T1tbF1_K.Text), double.Parse(T1tbF1_c.Text), double.Parse(T1tbF1_Q1.Text), double.Parse(T1tbF1_h.Text)).ToString();
        }
    }
}
