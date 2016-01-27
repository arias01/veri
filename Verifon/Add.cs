using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifon
{
    public partial class Add : Form
    {
        Principal principal = new Principal();
        public Add()
        {
            InitializeComponent();
            
        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.dispositivos' Puede moverla o quitarla según sea necesario.
            this.dispositivosTableAdapter.Fill(this.dataSet1.dispositivos);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.dispositivosBindingSource.EndEdit();
            this.dispositivosTableAdapter.Update(dataSet1.dispositivos);
            MessageBox.Show("Salvado");
            this.dispositivosTableAdapter.Fill(this.dataSet1.dispositivos);
            principal.dispositivosTableAdapter.Fill(dataSet1.dispositivos);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridView1.Columns[0]));
            this.dispositivosTableAdapter.Delete(id);
            MessageBox.Show("Eliminado Correctamente");
            this.dispositivosTableAdapter.Fill(dataSet1.dispositivos);
            
        }
    }
}
