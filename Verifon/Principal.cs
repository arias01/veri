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
using System.Net.Mail;
using System.Configuration;
using System.Web;

namespace Verifon
{
    public partial class Principal : Form
    {
        public Boolean reintentar = true; // recargar para comprabar y enviar
        public Boolean comprobar = true; // comprabar antes de hacer el proceso de envio
        
        public Principal()
        {
            InitializeComponent();
        }
        SmtpClient server = new SmtpClient("smtp.live.com");

        private void Principal_Load(object sender, EventArgs e)
        {
            //barEditItem7.EditValue.ToString();
          // string a =  ConfigurationSettings.AppSettings["intervalo"];
          // MessageBox.Show(a);
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.correos' Puede moverla o quitarla según sea necesario.
            //this.correosTableAdapter.Fill(this.dataSet11.correos);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.dispositivos' Puede moverla o quitarla según sea necesario.
            this.dispositivosTableAdapter.Fill(this.dataSet1.dispositivos);
            
        }
        public void mail_emergencia(StringBuilder body) {
            try
            {


                //DataTable correos = dataSet1.correos;
                //this.correosTableAdapter.Fill(dataSet1.correos);
                MailMessage mnsj = new MailMessage();

                mnsj.Subject = "SERVIDOR CENTRAL 1";
                mnsj.To.Clear();

                //foreach (DataRow rows in correos.Rows)
                //{

                //    string emails = Convert.ToString(rows[1]);
                //    mnsj.To.Add(new MailAddress(emails));
                //    MessageBox.Show(emails);
                //}

                //   mnsj.To.Add(new MailAddress("albert_arias01@hotmail.com"));
                //   mnsj.To.Add(new MailAddress("dacotas16@gmail.com"));
                ////   mnsj.To.Add(new MailAddress("ycruz@supermercadocentral.com.do"));
                //   mnsj.To.Add(new MailAddress("kelvinr005@hotmail.com"));
                mnsj.To.Add(new MailAddress("albert_arias01@hotmail.com"));
                mnsj.From = new MailAddress("albert_arias01@hotmail.com", "Albert Arias");

                /* Si deseamos Adjuntar algún archivo*/
                //mnsj.Attachments.Add(new Attachment("C:\\archivo.pdf"));

                mnsj.Body = Convert.ToString(body);

                /* Enviar */
                MandarCorreo(mnsj);
                // Enviado = true;

               // MessageBox.Show("El Mail se ha Enviado Correctamente", "Listo!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            //Task fill = new Task();
            try
            {
                this.dispositivosTableAdapter.Fill(this.dataSet1.dispositivos);
            }
            catch(Exception x) 
            {
                StringBuilder mensaje = new StringBuilder();
                //mensaje.AppendLine(Convert.ToString(x));
                string env = "Chequear la conexion del Servidor Supermercado Central 1";
                mensaje.AppendLine(env);
                mail_emergencia(mensaje);
                return;
            }
         
            Ping ping = new Ping();
            int val = 1;
            int filas = gridView1.RowCount;
            int comp;
            int intervalo = Convert.ToInt32( ConfigurationSettings.AppSettings["intervalo"]) ;
            int intervalo2 = Convert.ToInt32(ConfigurationSettings.AppSettings["intervalo2"]);
            int bar_valor = 100 / filas;
            progressBar1.Maximum = 100;
            var buffer = new byte[32];
            //MessageBox.Show(Convert.ToString(gridView1.RowCount));
            //MessageBox.Show(Convert.ToString(gridView1.GetRowCellValue(1,gridView1.Columns[2])));
            while (val <= filas) {
                progressBar1.Value = progressBar1.Value + bar_valor;
                 string ip = Convert.ToString(gridView1.GetRowCellValue(val -1, gridView1.Columns[3]));
                 //ping.Send(ip, intervalo, buffer);
                 if (ping.Send(ip, intervalo2, buffer).Status == IPStatus.Success)
                 {

                     gridView1.SetRowCellValue(val-1, gridView1.Columns[4], "CONECTADO");
                     
                    
                 }
                 else {
                     if (ping.Send(ip, intervalo2, buffer).Status != IPStatus.Success)
                     {
                         if (ping.Send(ip, intervalo2, buffer).Status != IPStatus.Success)
                         {
                             gridView1.SetRowCellValue(val - 1, gridView1.Columns[4], "DESCONECTADO");
                         }
                         else
                         {
                             gridView1.SetRowCellValue(val - 1, gridView1.Columns[4], "CONECTADO");
                         }
                     }
                     else 
                     {
                         gridView1.SetRowCellValue(val - 1, gridView1.Columns[4], "CONECTADO");
                     }
                    // gridView1.SetColumnError(gridView1.Columns[4], "DESCONECTADO");
                    
                     
                 }

                 

                 val = val + 1;
            }

            progressBar1.Value = 0;

        }

        private void Switch_CheckedChanged_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //backgroundWorker1.RunWorkerAsync();
            iniciar_timer1();
        }
        public void iniciar_timer1() {

            if (Switch.Checked == true)
            {
                //Task tarea = new Task(timer1.Start);
                timer1.Start();
                //tarea.Start();
            }
            else
            {
                timer1.Stop();
                //timer2.Stop();
                //barToggleSwitchItem1.Checked = false;

            }
        
        
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add agregar = new Add();
            agregar.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Task tarea1 = new Task( barButtonItem1.PerformClick);
            barButtonItem1.PerformClick();
            //tarea1.Start();
        }

        private void barEditItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // MessageBox.Show("");
        }

        private void barEditItem4_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            //MessageBox.Show("");
        }

        private void barEditItem4_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //MessageBox.Show("");
        }

        private void barEditItem4_HiddenEditor(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // MessageBox.Show("");
        }

        private void barEditItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                enviar();
            }
            catch { 
            int a = 0;
            }

        }

        public void enviar() {
            if (comprobar == true)
            {
                barButtonItem1.PerformClick();
                comprobar = false;
                timer4.Enabled = true;
                timer4.Start();
                return;
            }
            else {
                comprobar = true;
                
            }
            int filas = gridView1.RowCount;
            int val = 1;
            Boolean validar = false;
            
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine("EL O LOS SIGUIENTES DISPOSITIVOS ESTAN DESCONECTADO");
            while (val <= filas) { 
                   string valor = Convert.ToString(  gridView1.GetRowCellValue(val -1 , gridView1.Columns[4]));
                   string ubi = Convert.ToString(  gridView1.GetRowCellValue(val -1, gridView1.Columns[2]));
                   string ip = Convert.ToString(  gridView1.GetRowCellValue(val -1, gridView1.Columns[3]));
                if ( valor == "DESCONECTADO" ){

                    if (reintentar == true)
                    {
                        barButtonItem1.PerformClick();
                        //    reintentar = false;
                        timer3.Enabled = true;
                        timer3.Start();
                        return;
                    }
                    else
                    {

                        mensaje.AppendLine("");
                        mensaje.AppendLine("EL DISPOSITIVO DE " + ubi + " ESTA DESCONECTADO EN LA IP " + ip);
                        validar = true;
                    }
                }

                val++;
            
            }

            if (validar == true)
            {
                mail(mensaje);

            }
            reintentar = true;


        //  MessageBox.Show(Convert.ToString(  gridView1.GetRowCellValue(1, gridView1.Columns[5])));
        
        
        }

        private void barEditItem5_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barToggleSwitchItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barToggleSwitchItem1.Checked == true /*&& Switch.Checked == true*/)
            {
                timer2.Enabled = true;
                timer2.Start();

            }
            else
            {
                timer2.Stop();
                timer2.Enabled = false;
                barToggleSwitchItem1.Checked = false;

            }
            
           // MessageBox.Show(Convert.ToString(gridView1.GetRowCellValue(1, gridView1.Columns[4])));
        }


        public void mail(StringBuilder body) {


            try
            {


                DataTable correos = dataSet1.correos;
                this.correosTableAdapter.Fill(dataSet1.correos);
                MailMessage mnsj = new MailMessage();

                mnsj.Subject = "VERIPHONE DEL CENTRAL 1";
                mnsj.To.Clear();

                foreach (DataRow rows in correos.Rows) {

                    string emails = Convert.ToString(rows[1]);
                    mnsj.To.Add(new MailAddress(emails));
                   // MessageBox.Show(emails);
                }

             //   mnsj.To.Add(new MailAddress("albert_arias01@hotmail.com"));
             //   mnsj.To.Add(new MailAddress("dacotas16@gmail.com"));
             ////   mnsj.To.Add(new MailAddress("ycruz@supermercadocentral.com.do"));
             //   mnsj.To.Add(new MailAddress("kelvinr005@hotmail.com"));
               mnsj.From = new MailAddress("albert_arias01@hotmail.com", "Albert Arias");

                /* Si deseamos Adjuntar algún archivo*/
                //mnsj.Attachments.Add(new Attachment("C:\\archivo.pdf"));

                mnsj.Body = Convert.ToString(body);

                /* Enviar */
                MandarCorreo(mnsj);
                // Enviado = true;

                //MessageBox.Show("El Mail se ha Enviado Correctamente", "Listo!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void MandarCorreo(MailMessage mensaje)
        {
            server.Port = 587;
            server.UseDefaultCredentials = false;
            server.Credentials = new System.Net.NetworkCredential("albert_arias01@hotmail.com", "199515No669");
            server.EnableSsl = true;
            server.Send(mensaje);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            reintentar = false;
            enviar();
            timer3.Stop();
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            comprobar = false;
            enviar();
            timer4.Stop();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipText = "La aplicacion estara abierta.";
            notifyIcon1.BalloonTipTitle = "IMPORTANTE:";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(5000);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;

            notifyIcon1.Visible = false;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Visible = true;

            notifyIcon1.Visible = false;
        }

        private void barEditItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

 

        
    }
}
