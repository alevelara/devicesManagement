using System;
using System.Collections.Generic;
using gestionDispositivos.Backend.Business.Bussiness.Model;
using Backend.Business.Bussiness.Controller;

namespace gestionDispositivos.API.light_meterAPI
{
    class ligthMeterAPI
    {
        private lightMeterController controller = new lightMeterController();

        /// <summary>
        /// Add new light_meter.
        /// </summary>
        /// <param name="lM">light_meter: Light meter added.</param>
        /// <returns>
        /// bool: True if light_meter is added succesfully.
        /// </returns>
        public bool addLightMeter(light_meter lM)
        {
            return controller.addItem(lM);
        }

        /// <summary>
        /// Get all Light Meter.
        /// </summary>
        /// <returns>
        /// List<light_meter>: List of all Light Meters.
        /// </returns>
        public List<light_meter> getLightMeters()
        {
            return controller.getItems();
        }        
    }
}
