using System.Collections.Generic;
using gestionDispositivos.Backend.Business.Bussiness.Model;
using Backend.Business.Bussiness.Controller;

namespace gestionDispositivos.API.gatewayAPI
{
    class getewayAPI 
    {
        private gatewayController controller = new gatewayController();


        /// <summary>
        /// Add new gateway.
        /// </summary>
        /// <param name="gW">gateway: Gateway added.</param>
        /// <returns>
        /// bool: True if gateway is added succesfully.
        /// </returns>
        public bool AddGateway(gateway gW)
        {
            return controller.addItem(gW);
        }

        /// <summary>
        /// Get all gateways.
        /// </summary>
        /// <returns>
        /// List<gateway>: List of all gateways.
        /// </returns>
        public List<gateway> GetGateways()
        {
            return controller.getItems();
        }
      
    }
}
