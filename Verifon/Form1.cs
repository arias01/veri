using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Configuration;

namespace Verifon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ConfigurationSettings.AppSettings.Set("intervalo", "30");
            //    ConfigurationSettings.AppSettings.
            //}
            //catch { }
            //correosTableAdapter.FillBy(dataSet1.correos);
          //  DataRow row =  dataSet1.correos.Rows[1].co;
           
           
        //    var emails = correosTableAdapter.FillBy(dataSet1.correos);
           // MessageBox.Show(Convert.ToString(emails));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.correos' Puede moverla o quitarla según sea necesario.
        //    this.correosTableAdapter.Fill(this.dataSet1.correos);

        }
    


    }
}
