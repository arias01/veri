using Veriphone;
namespace Verifon
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dispositivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Veriphone.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldevice_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldevice_ubicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldevice_ip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dispositivosTableAdapter = new Veriphone.DataSet1TableAdapters.dispositivosTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dispositivosBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(1, 76);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(562, 211);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dispositivosBindingSource
            // 
            this.dispositivosBindingSource.DataMember = "dispositivos";
            this.dispositivosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldevice_name,
            this.coldevice_ubicacion,
            this.coldevice_ip});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 47;
            // 
            // coldevice_name
            // 
            this.coldevice_name.Caption = "NOMBRE";
            this.coldevice_name.FieldName = "device_name";
            this.coldevice_name.Name = "coldevice_name";
            this.coldevice_name.Visible = true;
            this.coldevice_name.VisibleIndex = 1;
            this.coldevice_name.Width = 165;
            // 
            // coldevice_ubicacion
            // 
            this.coldevice_ubicacion.Caption = "UBICACION";
            this.coldevice_ubicacion.FieldName = "device_ubicacion";
            this.coldevice_ubicacion.Name = "coldevice_ubicacion";
            this.coldevice_ubicacion.Visible = true;
            this.coldevice_ubicacion.VisibleIndex = 2;
            this.coldevice_ubicacion.Width = 165;
            // 
            // coldevice_ip
            // 
            this.coldevice_ip.Caption = "IP";
            this.coldevice_ip.FieldName = "device_ip";
            this.coldevice_ip.Name = "coldevice_ip";
            this.coldevice_ip.Visible = true;
            this.coldevice_ip.VisibleIndex = 3;
            this.coldevice_ip.Width = 167;
            // 
            // dispositivosTableAdapter
            // 
            this.dispositivosTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 58);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Salvar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(93, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 58);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Eliminar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 288);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dispositivosBindingSource;
        private Veriphone.DataSet1TableAdapters.dispositivosTableAdapter dispositivosTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldevice_name;
        private DevExpress.XtraGrid.Columns.GridColumn coldevice_ubicacion;
        private DevExpress.XtraGrid.Columns.GridColumn coldevice_ip;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}