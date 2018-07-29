using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionDispositivos.Backend.Business.Bussiness.Model;
using Backend.Business.Bussiness.Controller;

namespace gestionDispositivos.API.water_meterAPI
{
    class waterMeterAPI
    {
        private waterMeterController controller = new waterMeterController();

        /// <summary>
        /// Add new water_meter.
        /// </summary>
        /// <param name="wM">water_meter: Water meter added.</param>
        /// <returns>
        /// bool: True if water_meter is added succesfully.
        /// </returns>
        public bool AddWaterMeter(water_meter wM)
        {
            return controller.addItem(wM);
        }


        /// <summary>
        /// Get all water meter.
        /// </summary>
        /// <returns>
        /// List<light_meter>: List of all water meters.
        /// </returns>
        public List<water_meter> GetWaterMeters()
        {
            return controller.getItems();
        }
        
    }
}
