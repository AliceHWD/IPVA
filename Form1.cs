using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculador_IPVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[,] porcentagem = new int[,] {
                { 2, 1, 1 }, //0
                { 3, 3, 3 }, //1
                { 3, 3, 2 },
                { 3, 3, 2 },
                { 3, 3, 3 },
                { 3, 3, 2 },
                { 4, 1, 2 }, //DF
                { 2, 2, 1 },
                { 4, 3, 3 },
                { 3, 3, 1 },
                { 3, 3, 1 }, 
                { 3, 4, 2 },
                { 4, 3, 2 },
                { 3, 3, 1 },
                { 3, 3, 3 },
                { 4, 4, 4 },
                { 3, 3, 3 },
                { 3, 3, 2 },
                { 4, 3, 2 },
                { 3, 3, 2 },
                { 3, 3, 2 },
                { 3, 3, 2 },
                { 3, 2, 2 },
                { 2, 2, 1 },
                { 4, 2, 2 },
                { 3, 3, 2 },
                { 2, 3, 2 }
            };

            double valorCarro = double.Parse(txtPreco.Text);

            //Concional da coluna
            int j = 0;
            if (rdbCarroPasseio.Checked)
            { j = 0; }

            else if (rdbCaminhonete.Checked)
            { j = 1; }
            
            else
            { j = 2; }

            //Define o index com base no valor selecionado
            int i = 0;
            i = cmbEstados.SelectedIndex;

            //Calculo
            double total = valorCarro * porcentagem[i, j]/100; 

            lblResultado.Text = total.ToString();

        }
    }
}
