using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParaFacilitar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string openForDevs = "https://www.4devs.com.br/gerador_de_placa_automoveis";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = openForDevs,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir o link: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string openForDevs = "https://www.4devs.com.br/gerador_de_cpf";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = openForDevs,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir o link: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string openForDevs = "https://www.4devs.com.br/gerador_de_cnpj";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = openForDevs,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir o link: " + ex.Message);
            }
        }
    }
}
