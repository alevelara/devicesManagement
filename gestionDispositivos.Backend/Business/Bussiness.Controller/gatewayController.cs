using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionDispositivos.Backend.Business.Bussiness.Model;

namespace Backend.Business.Bussiness.Controller
{
    public class gatewayController : IApiModel<gateway>
    {
        public bool addItem(gateway gateway)
        {
            try
            {
                using (var context = new devicesEntities())
                {
                    if (!existsGateway(gateway.serial_number)) {
                        context.gateway.Add(gateway);
                        context.SaveChanges();
                        return true;
                    }

                    return false;
                    
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }       

        public List<gateway> getItems()
        {
            try
            {
                using (var context = new devicesEntities())
                {
                    return context.gateway.ToList<gateway>();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private bool existsGateway(string serialNumber)
        {
            List<gateway> gatewayList = getItems();
            return ((from gW in gatewayList where gW.serial_number.Equals(serialNumber) select gW).Count() >= 1);
        }

    }
}
