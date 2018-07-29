using Microsoft.VisualStudio.TestTools.UnitTesting;
using gestionDispositivos.Components.Devices;
using gestionDispositivos.Class;
using gestionDispositivos.Backend;
using System.Collections.Generic;
using gestionDispositivos.Backend.Business.Bussiness.Model;
using Backend.Business.Bussiness.Controller;

namespace devicesManagementTest
{
    [TestClass]
    public class devicesTest
    {
        private frm_device_management _deviceManagement;
        private frm_devices _devices;
        private validateDevice _validate;

        private string _ip;
        private string _brand;
        private string _serialNumber;
        private string _model;
        private string _port;
        

        public devicesTest()
        {
            _devices = new frm_devices();
            _validate = new validateDevice();

            _ip = "192.168.1.1";
            _brand = "brand";
            _serialNumber = utils.RandomString(15);
            _model = "model";
            _port = "1142";
        }
            
        
        [TestMethod]
        public void gatewayShouldbeAdded()
        {
            _deviceManagement = frm_device_management.openGateway();
            _deviceManagement.txt_brand.Text = _brand;
            _deviceManagement.txt_ip.Text = _ip;
            _deviceManagement.txt_model.Text = _model;
            _deviceManagement.txt_serial_number.Text = _serialNumber;
            _deviceManagement.txt_port.Text = _port;

            _deviceManagement.addGateway();

        }

        [TestMethod]
        public void lightMeterShouldBeAdded()
        {
            _deviceManagement = frm_device_management.openLightMeter();
            _deviceManagement.txt_brand.Text = _brand;            
            _deviceManagement.txt_model.Text = _model;
            _deviceManagement.txt_serial_number.Text = _serialNumber;

            _deviceManagement.addLightMeter();
        }

        [TestMethod]
        public void watertMeterShouldBeAdded()
        {
            _deviceManagement = frm_device_management.openWaterMeter();
            _deviceManagement.txt_brand.Text = _brand;            
            _deviceManagement.txt_model.Text = _model;
            _deviceManagement.txt_serial_number.Text = _serialNumber;

            _deviceManagement.addWaterMeter();
        }
        [TestMethod]
        public void waterMeterListShouldNotBeNul() {

            waterMeterController ctrl = new waterMeterController();
            List<water_meter> result = ctrl.getItems();

            Assert.IsNotNull(result);

        }    

        [TestMethod]
        public void lightMeterListShouldNotBeNul()
        {
            lightMeterController ctrl = new lightMeterController();
            List<light_meter> result = ctrl.getItems();

            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void gatewayListShouldNotBeNul()
        {
            gatewayController ctrl = new gatewayController();
            List<gateway> result = ctrl.getItems();

            Assert.IsNotNull(result);
        }



    }
}
