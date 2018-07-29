using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionDispositivos.Backend.Business.Bussiness.Model;

namespace Backend.Business.Bussiness.Controller
{
    public class waterMeterController : IApiModel<water_meter>
    {
        public bool addItem(water_meter waterMeter) 
        {
            try
            {
                using(var context = new devicesEntities())
                {
                    if (!existsWaterMeter(waterMeter.serial_number)){
                        context.water_meter.Add(waterMeter);
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

        public List<water_meter> getItems()
        {
            try
            {
                using (var context = new devicesEntities())
                {
                   return context.water_meter.ToList<water_meter>();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private bool existsWaterMeter(string serialNumber) {
            List<water_meter> waterMeterList = getItems();
            return ((from wM in waterMeterList where wM.serial_number.Equals(serialNumber) select wM).Count() == 1);
        }
    }
}
