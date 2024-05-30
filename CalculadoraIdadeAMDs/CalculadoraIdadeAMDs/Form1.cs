using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIdadeAMDs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int anoAtual, anoNasc, idd, iddM, iddD;
        private void tBoxAnoAtual_TextChanged(object sender, EventArgs e)
        {
            if (tBoxAnoAtual.Text != null && tBoxAnoAtual.Text != "")
            {
                anoAtual = int.Parse(tBoxAnoAtual.Text);
            }
        }

        private void tBoxAnoNasc_TextChanged(object sender, EventArgs e)
        {
            if (tBoxAnoNasc.Text != null && tBoxAnoNasc.Text != "")
            {
                anoNasc = int.Parse(tBoxAnoNasc.Text);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculador();
        }

        private void Calculador()
        {
            idd = anoAtual - anoNasc;
            iddM = idd * 12;
            iddD = iddM * 365;
            tBoxSuaIdd.Text = idd.ToString();
            tBoxSuaIddMeses.Text = iddM.ToString();
            tBoxSuaIddDias.Text = iddD.ToString();
        }
        private void limpar()
        {
            tBoxSuaIdd.Text = "";
            tBoxSuaIddMeses.Text = "";
            tBoxSuaIddDias.Text = "";
            tBoxName.Text = "";
            tBoxAnoAtual.Clear();
        }
    }
}
