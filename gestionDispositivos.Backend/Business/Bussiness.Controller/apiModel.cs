using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Backend.Business.Bussiness.Controller
{
    interface IApiModel<T>
        where T: class
    {
        List<T> getItems();
        bool addItem(T t);        
    }
}
