using System;
using gestionDispositivos.Class;
using System.Windows.Forms;
using gestionDispositivos.API.gatewayAPI;
using gestionDispositivos.API.water_meterAPI;
using gestionDispositivos.API.light_meterAPI;
using gestionDispositivos.Backend.Business.Bussiness.Model;

namespace gestionDispositivos.Components.Devices
{
    public partial class frm_device_management : Form
    {
        private bool isGateway = false;
        private bool isLightMeter = false;
        private bool isWaterMeter = false;       

        public frm_device_management()
        {
            InitializeComponent();            
        }


        /// <summary>
        /// Open Gateway Control Panel
        /// </summary>
        /// <returns>
        /// frm_device_management: Management form.
        /// </returns>
        public static frm_device_management openGateway()
        {
            frm_device_management management = new frm_device_management();
            management.isGateway = true;
            management.setFormText("Gateway Control");            
            management.showFields();
            return management;
        }


        /// <summary>
        /// Open Light meter Control Panel
        /// </summary>
        /// <returns>
        /// frm_device_management: Management form.
        /// </returns>
        public static frm_device_management openLightMeter()
        {
            frm_device_management management = new frm_device_management();
            management.isLightMeter = true;
            management.setFormText("Light Meter Control");
            management.hideFields();
            return management;
        }
        /// <summary>
        /// Open Water meter Control Panel
        /// </summary>
        /// <returns>
        /// frm_device_management: Management form.
        /// </returns>
        public static frm_device_management openWaterMeter()
        {
            frm_device_management management = new frm_device_management();
            management.isWaterMeter = true;
            management.setFormText("Water Meter Control");
            management.hideFields();
            return management;
        }


        /// <summary>
        /// Hide ip and port field.
        /// </summary>
        private void hideFields()
        {
            txt_port.Visible = false;
            txt_ip.Visible = false;
            lbl_port.Visible = false;
            lbl_ip.Visible = false;
        }
        /// <summary>
        /// Show ip and port field.
        /// </summary>
        private void showFields()
        {
            txt_port.Visible = true;
            txt_ip.Visible = true;
            lbl_port.Visible = true;
            lbl_ip.Visible = true;
        }

        /// <summary>
        /// Set text to this form
        /// </summary>
        /// <param name="tittle">String: Title name</param>
        private void setFormText(string title)
        {
            this.Text = title;
        }


        /// <summary>
        /// Add selected device depending of its type
        /// </summary>
        private void addDevice()
        {
            if (isGateway)
            {
                addGateway();
            }
            else if (isLightMeter)
            {
                addLightMeter();
            }
            else if (isWaterMeter)
            {
                addWaterMeter();
            }
        }
        
        /// <summary>
        /// Create new gateway with form values.
        /// </summary>
        /// <returns>
        /// gateway: formed by ip, port, model, brand and serial number.
        /// </returns>
        private gateway setGateway()
        {           
            gateway newGateway = new gateway();
            newGateway.ip = txt_ip.Text;
            newGateway.port = txt_port.Text;
            newGateway.model = txt_model.Text;
            newGateway.brand = txt_brand.Text;
            newGateway.serial_number = txt_serial_number.Text;
            return newGateway;
        }
        /// <summary>
        /// Create new light_meter with form values.
        /// </summary>
        /// <returns>
        /// light_meter: formed by serial number, model and brand. 
        /// </returns>
        private light_meter setLightMeter()
        {
            light_meter newLightMeter = new light_meter();            
            newLightMeter.model = txt_model.Text;
            newLightMeter.brand = txt_brand.Text;
            newLightMeter.serial_number = txt_serial_number.Text;
            return newLightMeter;
        }

        /// <summary>
        /// Create new water_meter with form values.
        /// </summary>
        /// <returns>
        /// water_meter:formed by serial number, model and brand.
        /// </returns>
        private water_meter setWaterMeter()
        {
            water_meter newWaterMeter = new water_meter();
            newWaterMeter.model = txt_model.Text;
            newWaterMeter.brand = txt_brand.Text;
            newWaterMeter.serial_number = txt_serial_number.Text;
            return newWaterMeter;
        }

        /// <summary>
        /// Add new gateway from validated form values. 
        /// </summary>
        public void addGateway()
        {
            try
            {
                if (isRightFormat())
                {
                    getewayAPI api = new getewayAPI();
                    gateway gW = setGateway();
                    if (!api.AddGateway(gW)) validateDevice.throwValidateException("Gateway already exists");
                    closeRightForm();
                }
            }
            catch (ArgumentException a)
            {
                MessageBox.Show(a.Message, "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }

        /// <summary>
        /// Add new Light meter from validated form values.
        /// </summary>
        public void addLightMeter()
        {
            try
            {
                if (isRightFormat())
                {
                    ligthMeterAPI api = new ligthMeterAPI();
                    light_meter lM = setLightMeter();
                    if (!api.addLightMeter(lM)) validateDevice.throwValidateException("Light meter already exists");
                    closeRightForm();
                }
            } catch (ArgumentException a) {
                MessageBox.Show(a.Message, "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        /// <summary>
        /// Add new Water meter from validated form values.
        /// </summary>
        public void addWaterMeter()
        {
            try {
                if (isRightFormat())
                {
                    waterMeterAPI api = new waterMeterAPI();
                    water_meter wM = setWaterMeter();
                    if (!api.AddWaterMeter(wM)) validateDevice.throwValidateException("Water Meter already exists");
                    closeRightForm();
                }
            } catch (ArgumentException a) {
                MessageBox.Show(a.Message, "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }


        /// <summary>
        /// Validate form values.
        /// </summary>
        /// <returns></returns>
        private bool isRightFormat() {

            bool rightResult = true;
            try
            {
                if (validateDevice.isEmpty(txt_serial_number.Text))
                {

                    validateDevice.throwValidateException("Serial number can not be empty.");
                }

                if (validateDevice.isTooLong(txt_serial_number.Text, 50))
                {

                    validateDevice.throwValidateException("Serial number is too long.");
                }

                if (validateDevice.isTooLong(txt_brand.Text, 100))
                {

                    validateDevice.throwValidateException("Brand name is too long.");
                }

                if (validateDevice.isTooLong(txt_model.Text, 100))
                {

                    validateDevice.throwValidateException("Model name is too long.");
                }


                if (isGateway)
                {
                    if (validateDevice.isEmpty(txt_ip.Text))
                    {
                        validateDevice.throwValidateException("IP can not be empty.");
                    }

                    if (!validateDevice.isRightFormatIpV4(txt_ip.Text))
                    {
                        validateDevice.throwValidateException("Wrong IP. Please, insert a right IP");
                    }

                    if (validateDevice.isTooLong(txt_ip.Text, 20))
                    {
                        validateDevice.throwValidateException("IP is too long.");
                    }

                    if (validateDevice.isNegativeOrZero(txt_port.Text))
                    {
                        validateDevice.throwValidateException("Port value can not be negative.");
                    }

                    if (validateDevice.isTooLong(txt_port.Text, 4))
                    {
                        validateDevice.throwValidateException("Port value is too long.");
                    }                    
                }

            }
            catch (ArgumentException a)
            {
                rightResult = false;
                MessageBox.Show(a.Message, "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
            return rightResult;
        }


        /// <summary>
        /// Close the form correctly
        /// </summary>
        private void closeRightForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        /**********EVENTS*********/

        private void txt_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
            {
                e.Handled = true;
            }            
        }


        private void btn_ok_Click(object sender, EventArgs e)
        {
            addDevice();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }


   

    
}
