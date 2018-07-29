using System;
using System.Collections.Generic;
using System.Linq;
using gestionDispositivos.Backend.Business.Bussiness.Model;

namespace Backend.Business.Bussiness.Controller
{
    public class lightMeterController : IApiModel<light_meter>
    {
        public bool addItem(light_meter lightMeter)
        {
            try
            {
                using (var context = new devicesEntities())
                {
                    if (!existsLightMeter(lightMeter.serial_number)) {
                        context.light_meter.Add(lightMeter);
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                    
                }
            }
            catch (Exception) 
            {
                return false;
            }
        }


        public List<light_meter> getItems()
        {
            try
            {
                using (var context = new devicesEntities())
                {                    
                    return context.light_meter.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private bool existsLightMeter(string serialNumber)
        {
            List<light_meter> LightMeterList = getItems();
            return ((from lM in LightMeterList where lM.serial_number.Equals(serialNumber) select lM).Count() == 1);
        }
    }
}
