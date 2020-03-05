using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace DesligarAgendado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAgendar_Click(object sender, EventArgs e)
        {
            txtDaAgen.Text = txtData.Text;
            txtHoraAgen.Text = txtHora.Text;
            
        }

        public void desligar() {
            System.Diagnostics.ProcessStartInfo oinfo = new
                  System.Diagnostics.ProcessStartInfo("cmd");
            System.Diagnostics.Process oproc = new System.Diagnostics.Process();
            oinfo.UseShellExecute = false;
            oinfo.RedirectStandardInput = true;
            oinfo.RedirectStandardOutput = true;
            oinfo.WorkingDirectory = @"C:\Windows\System32\";
            oproc.StartInfo = oinfo;
            oproc.Start();

            oproc.StandardInput.WriteLine("shutdown.exe -s -t 10");

            oproc.StandardInput.Close();

            MessageBox.Show(oproc.StandardOutput.ReadToEnd());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtRelogio.Text = DateTime.Now.ToLongTimeString();
            validaDataHora();
        }


        public void validaDataHora() {
            
            string Date = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToLongTimeString();
            if (txtDaAgen.Text == Date && txtHoraAgen.Text == hora) {

            //    MessageBox.Show("Deu Certo");

                desligar();
            }
          

          
        
        }

        private void txtHoraAgen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDaAgen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRelogio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtHora_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
