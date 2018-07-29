namespace gestionDispositivos.Components.Devices
{
    partial class frm_device_management
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
            this.lbl_serial_number = new System.Windows.Forms.Label();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.lbl_port = new System.Windows.Forms.Label();
            this.txt_serial_number = new System.Windows.Forms.TextBox();
            this.txt_brand = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_serial_number
            // 
            this.lbl_serial_number.AutoSize = true;
            this.lbl_serial_number.Location = new System.Drawing.Point(12, 16);
            this.lbl_serial_number.Name = "lbl_serial_number";
            this.lbl_serial_number.Size = new System.Drawing.Size(106, 16);
            this.lbl_serial_number.TabIndex = 0;
            this.lbl_serial_number.Text = "Serial Number: ";
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Location = new System.Drawing.Point(63, 45);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(55, 16);
            this.lbl_brand.TabIndex = 1;
            this.lbl_brand.Text = "Brand: ";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(67, 74);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(51, 16);
            this.lbl_model.TabIndex = 2;
            this.lbl_model.Text = "Model:";
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(88, 103);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(30, 16);
            this.lbl_ip.TabIndex = 3;
            this.lbl_ip.Text = "IP: ";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(73, 129);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(45, 16);
            this.lbl_port.TabIndex = 4;
            this.lbl_port.Text = "Port: ";
            // 
            // txt_serial_number
            // 
            this.txt_serial_number.Location = new System.Drawing.Point(124, 13);
            this.txt_serial_number.MaxLength = 50;
            this.txt_serial_number.Name = "txt_serial_number";
            this.txt_serial_number.Size = new System.Drawing.Size(249, 23);
            this.txt_serial_number.TabIndex = 5;
            this.txt_serial_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_brand
            // 
            this.txt_brand.Location = new System.Drawing.Point(124, 42);
            this.txt_brand.MaxLength = 50;
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.Size = new System.Drawing.Size(249, 23);
            this.txt_brand.TabIndex = 6;
            this.txt_brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(124, 71);
            this.txt_model.MaxLength = 50;
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(249, 23);
            this.txt_model.TabIndex = 7;
            this.txt_model.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(124, 100);
            this.txt_ip.MaxLength = 20;
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(249, 23);
            this.txt_ip.TabIndex = 8;
            this.txt_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(124, 129);
            this.txt_port.MaxLength = 4;
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(249, 23);
            this.txt_port.TabIndex = 9;
            this.txt_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_port_KeyPress);
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.Location = new System.Drawing.Point(299, 165);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "Confirm";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(218, 165);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frm_device_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 200);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_brand);
            this.Controls.Add(this.txt_serial_number);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.lbl_ip);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.lbl_brand);
            this.Controls.Add(this.lbl_serial_number);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_device_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_serial_number;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Label lbl_port;
        public System.Windows.Forms.TextBox txt_serial_number;
        public System.Windows.Forms.TextBox txt_brand;
        public System.Windows.Forms.TextBox txt_model;
        public System.Windows.Forms.TextBox txt_ip;
        public System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}