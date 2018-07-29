namespace gestionDispositivos.Components.Devices
{
    partial class frm_devices
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
            this.pnl_tittle = new System.Windows.Forms.Panel();
            this.lbl_devices = new System.Windows.Forms.Label();
            this.tlp_devices = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_gateway = new System.Windows.Forms.DataGridView();
            this.serial_number_gw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand_gw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model_gw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ptb_gateway_meter = new System.Windows.Forms.PictureBox();
            this.lbl_gateway_tittle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_water_meter = new System.Windows.Forms.DataGridView();
            this.serial_number_wm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand_wm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model_wm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ptb_add_water_meter = new System.Windows.Forms.PictureBox();
            this.lbl_meter_water_tittle = new System.Windows.Forms.Label();
            this.pnl_light_meter_tittle = new System.Windows.Forms.Panel();
            this.dgv_light_meter = new System.Windows.Forms.DataGridView();
            this.serial_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_light_meter_tittle2 = new System.Windows.Forms.Panel();
            this.ptb_add_light_meter = new System.Windows.Forms.PictureBox();
            this.lbl_meter_light_tittle = new System.Windows.Forms.Label();
            this.bindLightMeter = new System.Windows.Forms.BindingSource(this.components);
            this.bindWaterMeter = new System.Windows.Forms.BindingSource(this.components);
            this.bindGateway = new System.Windows.Forms.BindingSource(this.components);
            this.pnl_tittle.SuspendLayout();
            this.tlp_devices.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gateway)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_gateway_meter)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_water_meter)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add_water_meter)).BeginInit();
            this.pnl_light_meter_tittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_light_meter)).BeginInit();
            this.pnl_light_meter_tittle2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add_light_meter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindLightMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindWaterMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindGateway)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_tittle
            // 
            this.pnl_tittle.BackColor = System.Drawing.Color.White;
            this.pnl_tittle.Controls.Add(this.lbl_devices);
            this.pnl_tittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_tittle.Location = new System.Drawing.Point(0, 0);
            this.pnl_tittle.Name = "pnl_tittle";
            this.pnl_tittle.Size = new System.Drawing.Size(1063, 66);
            this.pnl_tittle.TabIndex = 0;
            // 
            // lbl_devices
            // 
            this.lbl_devices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_devices.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_devices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_devices.Location = new System.Drawing.Point(0, 0);
            this.lbl_devices.Name = "lbl_devices";
            this.lbl_devices.Size = new System.Drawing.Size(1063, 66);
            this.lbl_devices.TabIndex = 0;
            this.lbl_devices.Text = "DEVICES CONTROL PANEL";
            this.lbl_devices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_devices
            // 
            this.tlp_devices.BackColor = System.Drawing.Color.White;
            this.tlp_devices.ColumnCount = 1;
            this.tlp_devices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_devices.Controls.Add(this.panel2, 0, 2);
            this.tlp_devices.Controls.Add(this.panel1, 0, 1);
            this.tlp_devices.Controls.Add(this.pnl_light_meter_tittle, 0, 0);
            this.tlp_devices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_devices.Location = new System.Drawing.Point(0, 66);
            this.tlp_devices.Name = "tlp_devices";
            this.tlp_devices.RowCount = 3;
            this.tlp_devices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_devices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_devices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_devices.Size = new System.Drawing.Size(1063, 672);
            this.tlp_devices.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_gateway);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 218);
            this.panel2.TabIndex = 2;
            // 
            // dgv_gateway
            // 
            this.dgv_gateway.AllowUserToAddRows = false;
            this.dgv_gateway.AllowUserToDeleteRows = false;
            this.dgv_gateway.AllowUserToResizeRows = false;
            this.dgv_gateway.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gateway.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial_number_gw,
            this.brand_gw,
            this.model_gw,
            this.ip,
            this.port});
            this.dgv_gateway.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_gateway.Location = new System.Drawing.Point(0, 25);
            this.dgv_gateway.Name = "dgv_gateway";
            this.dgv_gateway.ReadOnly = true;
            this.dgv_gateway.Size = new System.Drawing.Size(1057, 193);
            this.dgv_gateway.TabIndex = 5;
            // 
            // serial_number_gw
            // 
            this.serial_number_gw.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serial_number_gw.DataPropertyName = "serial_number";
            this.serial_number_gw.HeaderText = "Serial Number";
            this.serial_number_gw.Name = "serial_number_gw";
            this.serial_number_gw.ReadOnly = true;
            // 
            // brand_gw
            // 
            this.brand_gw.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brand_gw.DataPropertyName = "brand";
            this.brand_gw.HeaderText = "Brand";
            this.brand_gw.Name = "brand_gw";
            this.brand_gw.ReadOnly = true;
            // 
            // model_gw
            // 
            this.model_gw.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.model_gw.DataPropertyName = "model";
            this.model_gw.HeaderText = "Model";
            this.model_gw.Name = "model_gw";
            this.model_gw.ReadOnly = true;
            // 
            // ip
            // 
            this.ip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ip.DataPropertyName = "ip";
            this.ip.HeaderText = "IP";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            // 
            // port
            // 
            this.port.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.port.DataPropertyName = "port";
            this.port.HeaderText = "Port";
            this.port.Name = "port";
            this.port.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.ptb_gateway_meter);
            this.panel4.Controls.Add(this.lbl_gateway_tittle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1057, 25);
            this.panel4.TabIndex = 4;
            // 
            // ptb_gateway_meter
            // 
            this.ptb_gateway_meter.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptb_gateway_meter.Image = global::gestionDispositivos.Properties.Resources.add;
            this.ptb_gateway_meter.Location = new System.Drawing.Point(1032, 0);
            this.ptb_gateway_meter.Name = "ptb_gateway_meter";
            this.ptb_gateway_meter.Size = new System.Drawing.Size(25, 25);
            this.ptb_gateway_meter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_gateway_meter.TabIndex = 2;
            this.ptb_gateway_meter.TabStop = false;
            this.ptb_gateway_meter.Click += new System.EventHandler(this.ptb_gateway_meter_Click);
            // 
            // lbl_gateway_tittle
            // 
            this.lbl_gateway_tittle.AutoSize = true;
            this.lbl_gateway_tittle.Location = new System.Drawing.Point(3, 6);
            this.lbl_gateway_tittle.Name = "lbl_gateway_tittle";
            this.lbl_gateway_tittle.Size = new System.Drawing.Size(65, 16);
            this.lbl_gateway_tittle.TabIndex = 3;
            this.lbl_gateway_tittle.Text = "Gateway";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_water_meter);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 218);
            this.panel1.TabIndex = 1;
            // 
            // dgv_water_meter
            // 
            this.dgv_water_meter.AllowUserToAddRows = false;
            this.dgv_water_meter.AllowUserToDeleteRows = false;
            this.dgv_water_meter.AllowUserToResizeRows = false;
            this.dgv_water_meter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_water_meter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial_number_wm,
            this.brand_wm,
            this.model_wm});
            this.dgv_water_meter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_water_meter.Location = new System.Drawing.Point(0, 25);
            this.dgv_water_meter.Name = "dgv_water_meter";
            this.dgv_water_meter.ReadOnly = true;
            this.dgv_water_meter.Size = new System.Drawing.Size(1057, 193);
            this.dgv_water_meter.TabIndex = 4;
            // 
            // serial_number_wm
            // 
            this.serial_number_wm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serial_number_wm.DataPropertyName = "serial_number";
            this.serial_number_wm.HeaderText = "Serial Number";
            this.serial_number_wm.Name = "serial_number_wm";
            this.serial_number_wm.ReadOnly = true;
            // 
            // brand_wm
            // 
            this.brand_wm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brand_wm.DataPropertyName = "brand";
            this.brand_wm.HeaderText = "Brand";
            this.brand_wm.Name = "brand_wm";
            this.brand_wm.ReadOnly = true;
            // 
            // model_wm
            // 
            this.model_wm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.model_wm.DataPropertyName = "model";
            this.model_wm.HeaderText = "Model";
            this.model_wm.Name = "model_wm";
            this.model_wm.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ptb_add_water_meter);
            this.panel3.Controls.Add(this.lbl_meter_water_tittle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1057, 25);
            this.panel3.TabIndex = 3;
            // 
            // ptb_add_water_meter
            // 
            this.ptb_add_water_meter.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptb_add_water_meter.Image = global::gestionDispositivos.Properties.Resources.add;
            this.ptb_add_water_meter.Location = new System.Drawing.Point(1032, 0);
            this.ptb_add_water_meter.Name = "ptb_add_water_meter";
            this.ptb_add_water_meter.Size = new System.Drawing.Size(25, 25);
            this.ptb_add_water_meter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_add_water_meter.TabIndex = 1;
            this.ptb_add_water_meter.TabStop = false;
            this.ptb_add_water_meter.Click += new System.EventHandler(this.ptb_add_water_meter_Click);
            // 
            // lbl_meter_water_tittle
            // 
            this.lbl_meter_water_tittle.AutoSize = true;
            this.lbl_meter_water_tittle.Location = new System.Drawing.Point(3, 6);
            this.lbl_meter_water_tittle.Name = "lbl_meter_water_tittle";
            this.lbl_meter_water_tittle.Size = new System.Drawing.Size(92, 16);
            this.lbl_meter_water_tittle.TabIndex = 2;
            this.lbl_meter_water_tittle.Text = "Water Meter";
            // 
            // pnl_light_meter_tittle
            // 
            this.pnl_light_meter_tittle.Controls.Add(this.dgv_light_meter);
            this.pnl_light_meter_tittle.Controls.Add(this.pnl_light_meter_tittle2);
            this.pnl_light_meter_tittle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_light_meter_tittle.Location = new System.Drawing.Point(3, 3);
            this.pnl_light_meter_tittle.Name = "pnl_light_meter_tittle";
            this.pnl_light_meter_tittle.Size = new System.Drawing.Size(1057, 218);
            this.pnl_light_meter_tittle.TabIndex = 0;
            // 
            // dgv_light_meter
            // 
            this.dgv_light_meter.AllowUserToAddRows = false;
            this.dgv_light_meter.AllowUserToDeleteRows = false;
            this.dgv_light_meter.AllowUserToResizeRows = false;
            this.dgv_light_meter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_light_meter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial_number,
            this.brand,
            this.model});
            this.dgv_light_meter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_light_meter.Location = new System.Drawing.Point(0, 25);
            this.dgv_light_meter.Name = "dgv_light_meter";
            this.dgv_light_meter.ReadOnly = true;
            this.dgv_light_meter.Size = new System.Drawing.Size(1057, 193);
            this.dgv_light_meter.TabIndex = 3;
            // 
            // serial_number
            // 
            this.serial_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serial_number.DataPropertyName = "serial_number";
            this.serial_number.HeaderText = "Serial Number";
            this.serial_number.Name = "serial_number";
            this.serial_number.ReadOnly = true;
            // 
            // brand
            // 
            this.brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "Brand";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            // 
            // model
            // 
            this.model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // pnl_light_meter_tittle2
            // 
            this.pnl_light_meter_tittle2.BackColor = System.Drawing.Color.White;
            this.pnl_light_meter_tittle2.Controls.Add(this.ptb_add_light_meter);
            this.pnl_light_meter_tittle2.Controls.Add(this.lbl_meter_light_tittle);
            this.pnl_light_meter_tittle2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_light_meter_tittle2.Location = new System.Drawing.Point(0, 0);
            this.pnl_light_meter_tittle2.Name = "pnl_light_meter_tittle2";
            this.pnl_light_meter_tittle2.Size = new System.Drawing.Size(1057, 25);
            this.pnl_light_meter_tittle2.TabIndex = 2;
            // 
            // ptb_add_light_meter
            // 
            this.ptb_add_light_meter.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptb_add_light_meter.Image = global::gestionDispositivos.Properties.Resources.add;
            this.ptb_add_light_meter.Location = new System.Drawing.Point(1032, 0);
            this.ptb_add_light_meter.Name = "ptb_add_light_meter";
            this.ptb_add_light_meter.Size = new System.Drawing.Size(25, 25);
            this.ptb_add_light_meter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_add_light_meter.TabIndex = 0;
            this.ptb_add_light_meter.TabStop = false;
            this.ptb_add_light_meter.Click += new System.EventHandler(this.ptb_add_light_meter_Click);
            // 
            // lbl_meter_light_tittle
            // 
            this.lbl_meter_light_tittle.AutoSize = true;
            this.lbl_meter_light_tittle.Location = new System.Drawing.Point(3, 6);
            this.lbl_meter_light_tittle.Name = "lbl_meter_light_tittle";
            this.lbl_meter_light_tittle.Size = new System.Drawing.Size(83, 16);
            this.lbl_meter_light_tittle.TabIndex = 1;
            this.lbl_meter_light_tittle.Text = "Light Meter";
            // 
            // frm_devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 738);
            this.Controls.Add(this.tlp_devices);
            this.Controls.Add(this.pnl_tittle);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_devices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DCP";
            this.Load += new System.EventHandler(this.frm_devices_Load);
            this.pnl_tittle.ResumeLayout(false);
            this.tlp_devices.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gateway)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_gateway_meter)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_water_meter)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add_water_meter)).EndInit();
            this.pnl_light_meter_tittle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_light_meter)).EndInit();
            this.pnl_light_meter_tittle2.ResumeLayout(false);
            this.pnl_light_meter_tittle2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add_light_meter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindLightMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindWaterMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindGateway)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_tittle;
        private System.Windows.Forms.Label lbl_devices;
        private System.Windows.Forms.TableLayoutPanel tlp_devices;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_gateway_tittle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_meter_water_tittle;
        private System.Windows.Forms.Panel pnl_light_meter_tittle;
        private System.Windows.Forms.Label lbl_meter_light_tittle;
        private System.Windows.Forms.DataGridView dgv_gateway;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_number_gw;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_gw;
        private System.Windows.Forms.DataGridViewTextBoxColumn model_gw;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn port;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_water_meter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_number_wm;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_wm;
        private System.Windows.Forms.DataGridViewTextBoxColumn model_wm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_light_meter;
        private System.Windows.Forms.Panel pnl_light_meter_tittle2;
        private System.Windows.Forms.PictureBox ptb_gateway_meter;
        private System.Windows.Forms.PictureBox ptb_add_water_meter;
        private System.Windows.Forms.PictureBox ptb_add_light_meter;
        private System.Windows.Forms.BindingSource bindLightMeter;
        private System.Windows.Forms.BindingSource bindWaterMeter;
        private System.Windows.Forms.BindingSource bindGateway;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
    }
    
}