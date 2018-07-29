using System;
using System.Windows.Forms;
using gestionDispositivos.API.gatewayAPI;
using gestionDispositivos.API.light_meterAPI;
using gestionDispositivos.API.water_meterAPI;

namespace gestionDispositivos.Components.Devices
{
    public partial class frm_devices : Form
    {
        
        public frm_devices()
        {
            InitializeComponent();
            initializeForm();
        }

        /// <summary>
        /// Configure datagrid in the form.
        /// </summary>
        private void initializeForm()
        {
            dgv_gateway.AutoGenerateColumns = false;
            dgv_light_meter.AutoGenerateColumns = false;
            dgv_water_meter.AutoGenerateColumns = false;
        }


        /// <summary>
        /// Show all devices added in the datagrid.
        /// </summary>
        private void showDevices()
        {
            showLightMeter();
            showWaterMeter();
            showGateway();
        }


        /// <summary>
        /// Show light meters in the datagrid.
        /// </summary>
        private void showLightMeter()
        {
            ligthMeterAPI lightMeterQuery = new ligthMeterAPI();
            bindLightMeter.DataSource = lightMeterQuery.getLightMeters();
            dgv_light_meter.DataSource = bindLightMeter;
        }

        /// <summary>
        /// Show water meters in the datagrid.
        /// </summary>
        private void showWaterMeter()
        {
            waterMeterAPI waterMeterQuery = new waterMeterAPI();
            bindWaterMeter.DataSource = waterMeterQuery.GetWaterMeters();
            dgv_water_meter.DataSource = bindWaterMeter;
        }

        /// <summary>
        /// Show gateway in the datagrid.
        /// </summary>
        private void showGateway()
        {
            getewayAPI gatewayQuery = new getewayAPI();
            bindGateway.DataSource = gatewayQuery.GetGateways();
            dgv_gateway.DataSource = bindGateway;
        }

        /**************EVENTS******************/

        private void frm_devices_Load(object sender, EventArgs e)
        {
            showDevices();
        }

        private void ptb_add_light_meter_Click(object sender, EventArgs e)
        {

            frm_device_management management = frm_device_management.openLightMeter();
            management.ShowDialog();

            if (management.DialogResult == DialogResult.OK)
            {
                showLightMeter();
            }

        }

        private void ptb_add_water_meter_Click(object sender, EventArgs e)
        {
            frm_device_management management = frm_device_management.openWaterMeter();
            management.ShowDialog();

            if (management.DialogResult == DialogResult.OK)
            {
                showWaterMeter();
            }

        }

        private void ptb_gateway_meter_Click(object sender, EventArgs e)
        {
            frm_device_management management = frm_device_management.openGateway();
            management.ShowDialog();

            if (management.DialogResult == DialogResult.OK)
            {
                showGateway();
            }

        }

        

    }
    
}
