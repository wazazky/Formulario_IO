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
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.BlueGrey500, Accent.LightGreen200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static double Punto_de_Reorden(double DemandaDiaria , double TiempoEntrega) {
        return DemandaDiaria*TiempoEntrega;
        }
        public static Double Formula1(double d, double K, double c, double Q, double h)
        {
            double T;
            return T = ((d * K) / Q)+(d * c)+((h * Q) / 2);
        }
        public static Double Formula2(Double k, Double d, Double h)
        {
            return Math.Sqrt(((2 * (d * k)) / h));
        }
        public static double formula3(double l, double c)
        {
            return l * c;
        }

      

        public static float formula_5(float D, float Q)
        {
            return D / Q;
        }
        public static double formula_8(double L, double n, double t){
        return L-n* t;
        }

        private void TabTema3_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox16_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
