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
            GB_T2_Formula1.Visible = true;
            GB_T2_Formula2.Visible = false;
            GB_T2_Formula3.Visible = false;
            GB_T2_Formula4.Visible = false;
            GB_T2_Formula5.Visible = false;
            GB_T2_Formula6.Visible = false;
            GB_T3_Formula1.Visible = true;
            GB_T3_Formula2.Visible = false;
            GB_T3_Formula3.Visible = false;
            GB_T3_Formula4.Visible = false;
            GB_T3_Formula5.Visible = false;
            GB_T3_Formula6.Visible = false;
            GB_T3_Formula7.Visible = false;


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
                // Verificar si el carácter presionado es un número o un punto decimal
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
        
public static double T_Tema_2(double K, double c, double Q, double h, double S, double d, double p)
        {
            double res1 = (d * K) / Q;
            double res2 = d * c;
            double res3 = (h * (S * S)) / (2 * Q);
            double res4 = (p * ((Q - S) * (Q - S))) /( 2 * Q);
            double res = res1 + res2 + res3 + res4;
         
            return res;
        }

        public static double Q_Tema_2(double d, double K, double h, double p)
        {
            return Math.Sqrt((2 * d * K) / h) * Math.Sqrt((p + h) / p);
        }

        public static double S_Tema_2(double d, double K, double h, double p)
        {
            return Math.Sqrt((2 * d * K) / h) * Math.Sqrt(p / (p + h));
        }

        public static double Q_Minus_S_Tema_2(double d, double K, double h, double p)
        {
            return Math.Sqrt((2 * d * K) / p) * Math.Sqrt(h / (p + h));
        }
        public static double t_Tema_2(double d, double K, double h, double p)
        {
            return Math.Sqrt((2 * K) / d * h) * Math.Sqrt((p + h) / p);
        }

        public static double Sd_sobre_Qd_Tema_2(double p, double h)
        {
            return p / (p + h);
        }

        public static double formula_1(double d, double K, double c, double Q, double h)
        {
           
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
            catch (Exception )
            {
                MaterialMessageBox.Show("te faltan datos \nRevisarle bien🤙",true);
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

        private void t2cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (t2cb.SelectedIndex)
            {
                case 0:

                    GB_T2_Formula1.Visible = true;
                    GB_T2_Formula2.Visible = false;
                    GB_T2_Formula3.Visible = false;
                    GB_T2_Formula4.Visible = false;
                    GB_T2_Formula5.Visible = false;
                    GB_T2_Formula6.Visible = false;
                   
                    break;
                case 1:
                    GB_T2_Formula1.Visible = false;
                    GB_T2_Formula2.Visible = true;
                    GB_T2_Formula3.Visible = false;
                    GB_T2_Formula4.Visible = false;
                    GB_T2_Formula5.Visible = false;
                    GB_T2_Formula6.Visible = false;
                   
                    break;
                case 2:
                    GB_T2_Formula1.Visible = false;
                    GB_T2_Formula2.Visible = false;
                    GB_T2_Formula3.Visible = true;
                    GB_T2_Formula4.Visible = false;
                    GB_T2_Formula5.Visible = false;
                    GB_T2_Formula6.Visible = false;
                    
                    break;
                case 3:
                    GB_T2_Formula1.Visible = false;
                    GB_T2_Formula2.Visible = false;
                    GB_T2_Formula3.Visible = false;
                    GB_T2_Formula4.Visible = true;
                    GB_T2_Formula5.Visible = false;
                    GB_T2_Formula6.Visible = false;
                 
                    break;
                case 4:
                    GB_T2_Formula1.Visible = false;
                    GB_T2_Formula2.Visible = false;
                    GB_T2_Formula3.Visible = false;
                    GB_T2_Formula4.Visible = false;
                    GB_T2_Formula5.Visible = true;
                    GB_T2_Formula6.Visible = false;
                 
                    break;
                case 5:
                    GB_T2_Formula1.Visible = false;
                    GB_T2_Formula2.Visible = false;
                    GB_T2_Formula3.Visible = false;
                    GB_T2_Formula4.Visible = false;
                    GB_T2_Formula5.Visible = false;
                    GB_T2_Formula6.Visible = true;
        
                    break;
               
                    
                default:
                    GB_T2_Formula1.Visible = false;
                    GB_T2_Formula2.Visible = false;
                    GB_T2_Formula3.Visible = false;
                    GB_T2_Formula4.Visible = false;
                    GB_T2_Formula5.Visible = false;
                    GB_T2_Formula6.Visible = false;
                

                    break;
            }
            TabTema2.Refresh();
        }

        private void btnCalcT2_Click(object sender, EventArgs e)
        {
            try
            {
                if (t2cb.SelectedIndex == 0)
                {
                    T2tbF1_T.Text = T_Tema_2(double.Parse(T2tbF1_K.Text), double.Parse(T2tbF1_c.Text), double.Parse(T2tbF1_Q.Text), double.Parse(T2tbF1_h.Text), double.Parse(T2tbF1_S.Text), double.Parse(T2tbF1_d.Text), double.Parse(T2tbF1_p.Text)).ToString();
                }
                if (t2cb.SelectedIndex == 1)
                {
                    T2tbF2_Q.Text = Q_Tema_2(double.Parse(T2tbF2_d.Text), double.Parse(T2tbF2_K.Text), double.Parse(T2tbF2_h.Text), double.Parse(T2tbF2_p.Text)).ToString();

                }
                if (t2cb.SelectedIndex == 2)
                {
                    T2tbF3_S.Text = S_Tema_2(double.Parse(T2tbF3_d.Text), double.Parse(T2tbF3_K.Text), double.Parse(T2tbF3_h.Text), double.Parse(T2tbF3_p.Text)).ToString();

                }
                if (t2cb.SelectedIndex == 3)
                {
                    T2tbF4_QS.Text =Q_Minus_S_Tema_2(double.Parse(T2tbF4_d.Text), double.Parse(T2tbF4_K.Text), double.Parse(T2tbF4_h.Text), double.Parse(T2tbF4_p.Text)).ToString();

                }
                if (t2cb.SelectedIndex == 4)
                {
                    T2tbF5_t.Text = t_Tema_2(double.Parse(T2tbF5_d.Text), double.Parse(T2tbF5_K.Text), double.Parse(T2tbF5_h.Text), double.Parse(T2tbF5_p.Text)).ToString();


                }
                if (t2cb.SelectedIndex == 5)
                {
                    T2tbF6_SDQD.Text = Sd_sobre_Qd_Tema_2(double.Parse(T2tbF6_p.Text), double.Parse(T2tbF6_h.Text)).ToString();
                    

                }
            
            }

            catch (Exception)
            {
                MaterialMessageBox.Show("te faltan datos \nRevisarle bien🤙", true);
            }

        }

        private void T2tbF1_d_TextChanged(object sender, EventArgs e)
        {
            T2tbF1_d_2.Text=T2tbF1_d.Text;
        }

        private void T2tbF1_Q_KeyUp(object sender, KeyEventArgs e)
        {
            T2tbF1_Q_2.Text=T2tbF1_Q.Text;
            T2tbF1_Q_3.Text=T2tbF1_Q.Text;
            T2tbF1_Q_4.Text=T2tbF1_Q.Text;
        }

        private void T2tbF1_h_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void T2tbF1_S_KeyUp(object sender, KeyEventArgs e)
        {
            T2tbF1_S_2.Text=T2tbF1_S.Text;
        }

        private void T2tbF2_h_KeyUp(object sender, KeyEventArgs e)
        {
            T2tbF2_h_2.Text=T2tbF2_h.Text;
        }

        private void T2tbF2_p_KeyUp(object sender, KeyEventArgs e)
        {
            T2tbF2_p_2.Text=T2tbF2_p.Text;
        }

        private void T2tbF3_h_KeyUp(object sender, KeyEventArgs e)
        {
            T2tbF3_h_2.Text=T2tbF3_h.Text;
        }

        private void T2tbF3_p_KeyUp(object sender, KeyEventArgs e)
        {
            T2tbF3_p_2.Text=T2tbF3_p.Text;
        }

        private void T2tbF4_p_KeyUp(object sender, KeyEventArgs e)
        {
            T2tbF4_p_2.Text=T2tbF4_p.Text;
        }

        private void T2tbF4_h_KeyUp(object sender, KeyEventArgs e)
        {
            T2tbF4_h_2.Text=T2tbF4_h.Text;
        }

        private void T2tbF6_p_KeyUp(object sender, KeyEventArgs e)
        {
            T2tbF6_p_2.Text=T2tbF6_p.Text;
        }

        private void T2tbF5_h_KeyUp(object sender, KeyEventArgs e)
        {
            T2tbF5_h_2.Text=T2tbF5_h.Text;
            T2tbF5_h_3.Text=T2tbF5_h.Text;
        }

        private void btnBorrarT2_Click(object sender, EventArgs e)
        {
            switch (t2cb.SelectedIndex)
            {
                case 0:

                    T2tbF1_c.Text = string.Empty;
                    T2tbF1_Q.Text = string.Empty;
                    T2tbF1_d.Text = string.Empty;
                    T2tbF1_K.Text = string.Empty;
                    T2tbF1_d_2.Text = string.Empty;
                    T2tbF1_c.Text = string.Empty;
                    T2tbF1_h.Text = string.Empty;
                    T2tbF1_S.Text = string.Empty;
                    T2tbF1_Q_2.Text = string.Empty;
                    T2tbF1_p.Text = string.Empty;
                    T2tbF1_Q_4.Text = string.Empty;
                    T2tbF1_Q_3.Text = string.Empty;
                    T2tbF1_S_2.Text = string.Empty;
                    T2tbF1_T.Text = string.Empty;
                    break;
                case 1:
                    T2tbF2_d.Text = string.Empty;
                    T2tbF2_K.Text = string.Empty;
                    T2tbF2_p.Text = string.Empty;
                    T2tbF2_p_2.Text = string.Empty;
                    T2tbF2_h.Text = string.Empty;
                    T2tbF2_h_2.Text = string.Empty;
                    break;
                case 2:
                    T2tbF3_S.Text = string.Empty;
                    T2tbF3_d.Text = string.Empty;
                    T2tbF3_K.Text = string.Empty;
                    T2tbF3_h.Text = string.Empty;
                    T2tbF3_h_2.Text = string.Empty;
                    T2tbF3_p.Text = string.Empty;
                    T2tbF3_p_2.Text = string.Empty;
                    break;
                case 3:
                    T2tbF4_QS.Text = string.Empty;
                    T2tbF4_d.Text = string.Empty;
                    T2tbF4_K.Text = string.Empty;
                    T2tbF4_h.Text = string.Empty;
                    T2tbF4_h_2.Text = string.Empty;
                    T2tbF4_p.Text = string.Empty;
                    T2tbF4_p_2.Text = string.Empty;
                    break;
                case 4:
                    
                    T2tbF5_K.Text = string.Empty;
                    T2tbF5_d.Text = string.Empty;
                    T2tbF5_t.Text = string.Empty;
                    T2tbF5_p.Text = string.Empty;
                    T2tbF5_h.Text = string.Empty;
                    T2tbF5_h_2.Text = string.Empty;
                    T2tbF5_h_3.Text = string.Empty;

                    break;
                case 5:
                    T2tbF6_SDQD.Text = string.Empty;
                    T2tbF6_p.Text = string.Empty;
                    T2tbF6_p_2.Text = string.Empty;
                    T2tbF6_h.Text = string.Empty;
                    break;
               
                    
                default:
                    //👌
                    break;
            }
        }

        private void t3cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (t3cb.SelectedIndex)
            {
                case 0:
                    GB_T3_Formula1.Visible = true;
                    GB_T3_Formula2.Visible = false;
                    GB_T3_Formula3.Visible = false;
                    GB_T3_Formula4.Visible = false;
                    GB_T3_Formula5.Visible = false;
                    GB_T3_Formula6.Visible = false;
                    GB_T3_Formula7.Visible = false;
                
                    break;
                case 1:
                    GB_T3_Formula1.Visible = false;
                    GB_T3_Formula2.Visible = true;
                    GB_T3_Formula3.Visible = false;
                    GB_T3_Formula4.Visible = false;
                    GB_T3_Formula5.Visible = false;
                    GB_T3_Formula6.Visible = false;
                    GB_T3_Formula7.Visible = false;
                   
                    break;
                case 2:
                    GB_T3_Formula1.Visible = false;
                    GB_T3_Formula2.Visible = false;
                    GB_T3_Formula3.Visible = true;
                    GB_T3_Formula4.Visible = false;
                    GB_T3_Formula5.Visible = false;
                    GB_T3_Formula6.Visible = false;
                    GB_T3_Formula7.Visible = false;
                 
                    break;
                case 3:
                    GB_T3_Formula1.Visible = false;
                    GB_T3_Formula2.Visible = false;
                    GB_T3_Formula3.Visible = false;
                    GB_T3_Formula4.Visible = true;
                    GB_T3_Formula5.Visible = false;
                    GB_T3_Formula6.Visible = false;
                    GB_T3_Formula7.Visible = false;
                   
                    break;
                case 4:
                    GB_Formula1.Visible = false;
                    GB_Formula2.Visible = false;
                    GB_Formula3.Visible = false;
                    GB_Formula4.Visible = false;
                    GB_Formula5.Visible = true;
                    GB_Formula6.Visible = false;
                    GB_Formula7.Visible = false;
                  
                    break;
                case 5:
                    GB_T3_Formula1.Visible = false;
                    GB_T3_Formula2.Visible = false;
                    GB_T3_Formula3.Visible = false;
                    GB_T3_Formula4.Visible = false;
                    GB_T3_Formula5.Visible = false;
                    GB_T3_Formula6.Visible = true;
                    GB_T3_Formula7.Visible = false;
                   
                    break;
                case 6:
                    GB_T3_Formula1.Visible = false;
                    GB_T3_Formula2.Visible = false;
                    GB_T3_Formula3.Visible = false;
                    GB_T3_Formula4.Visible = false;
                    GB_T3_Formula5.Visible = false;
                    GB_T3_Formula6.Visible = false;
                    GB_T3_Formula7.Visible = true;
               
                    break;
              
                default:
                    GB_T3_Formula1.Visible = false;
                    GB_T3_Formula2.Visible = false;
                    GB_T3_Formula3.Visible = false;
                    GB_T3_Formula4.Visible = false;
                    GB_T3_Formula5.Visible = false;
                    GB_T3_Formula6.Visible = false;
                    GB_T3_Formula7.Visible = false;
                 
                    break;
            }
        }

        private void TabTema2_Click(object sender, EventArgs e)
        {

        }
        public static double T3_Formula1(double R, double Cp, double Ch, double r, double p) {return Math.Sqrt(2 *R*Cp*Ch*(1-(r/p)));}
        public static double T3_Formula2(double R, double Cp, double Ch, double r, double p) { return Math.Sqrt(2 * R * Cp /(Ch * (1 - (r / p))));}
        public static double T3_Formula3(double Q, double p) { return Q / p; }
        public static double T3_Formula4(double R, double Q) { return R / Q; }
        public static double T3_Formula5(double I, double C) { return I * C; }
        public static double T3_Formula6(double R, double Dias) { return R/Dias; }
        public static double T3_Formula7(double P, double Dias) { return P/Dias; }

        private void materialFloatingActionButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (t3cb.SelectedIndex == 0)
                {
                    T3tbF1_TIC0.Text =T3_Formula1(double.Parse(T3tbF1_R.Text), double.Parse(T3tbF1_Cp.Text), double.Parse(T3tbF1_Ch.Text), double.Parse(T3tbF1_rMin.Text), double.Parse(T3tbF1_p.Text)).ToString();
                }
                if (t3cb.SelectedIndex == 1)
                {
                    T3tbF2_Q0.Text = T3_Formula2(double.Parse(T3tbF2_R.Text), double.Parse(T3tbF2_Cp.Text), double.Parse(T3tbF2_Ch.Text), double.Parse(T3tbF2_rMin.Text), double.Parse(T3tbF2_p.Text)).ToString();

                }
                if (t3cb.SelectedIndex == 2)
                {
                    T3tbF3_tp.Text = T3_Formula3(double.Parse(T3tbF3_Q.Text), double.Parse(T3tbF3_p.Text)).ToString();

                }
                if (t3cb.SelectedIndex == 3)
                {
                    T3tbF4_N1.Text = T3_Formula4(double.Parse(T3tbF4_R.Text), double.Parse(T3tbF4_Q.Text)).ToString();

                }
                if (t3cb.SelectedIndex == 4)
                {
                    T3tbF5_Ch.Text = T3_Formula5(double.Parse(T3tbF5_I.Text), double.Parse(T3tbF5_C.Text)).ToString();

                }
                if (t3cb.SelectedIndex == 5)
                {
                    T3tbF6_rMin.Text = T3_Formula6(double.Parse(T3tbF6_R.Text), double.Parse(T3tbF6_Dias.Text)).ToString();

                }
                if (t3cb.SelectedIndex == 6)
                {
                    T3tbF7_pMin.Text = formula_7(double.Parse(T3tbF7_P.Text), double.Parse(T3tbF7_Dias.Text)).ToString();

                }
              // Código que puede lanzar una excepción
            }
            catch (Exception)
            {
                MaterialMessageBox.Show("te faltan datos \nRevisarle bien🤙", true);
            }

        }

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
            switch (t3cb.SelectedIndex)
            {
                case 0:
                    T3tbF1_TIC0.Text = string.Empty; T3tbF1_R.Text = string.Empty; T3tbF1_Cp.Text = string.Empty; T3tbF1_Ch.Text = string.Empty; T3tbF1_rMin.Text = string.Empty; T3tbF1_p.Text = string.Empty;

                    break;
                case 1:
                    T3tbF2_Q0.Text = string.Empty; T3tbF2_R.Text = string.Empty; T3tbF2_Cp.Text = string.Empty; T3tbF2_Ch.Text = string.Empty; T3tbF2_rMin.Text = string.Empty; T3tbF2_p.Text = string.Empty;

                    break;
                case 2:
                    T3tbF3_tp.Text = string.Empty; T3tbF3_Q.Text = string.Empty; T3tbF3_p.Text = string.Empty;

                    break;
                case 3:
                    T3tbF4_N1.Text = string.Empty; T3tbF4_R.Text = string.Empty; T3tbF4_Q.Text = string.Empty;

                    break;
                case 4:
                    T3tbF5_Ch.Text = string.Empty; T3tbF5_I.Text = string.Empty; T3tbF5_C.Text = string.Empty;

                    break;
                case 5:
                    T3tbF6_rMin.Text = string.Empty; T3tbF6_R.Text = string.Empty; T3tbF6_Dias.Text = string.Empty;

                    break;
                case 6:
                    T3tbF7_pMin.Text = string.Empty; T3tbF7_P.Text = string.Empty; T3tbF7_Dias.Text = string.Empty;
                    break;
                default:
                    //👌
                    break;
            }
        }

        private void Tab_Control_Formulario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
