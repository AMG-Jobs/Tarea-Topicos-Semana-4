using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriadeClases
{
    public partial class Orders
    {
        public string DirecionEntrega {
            get
            {
                //pais,ciudad, direccion,postal
                if (ShipPostalCode != null) {
                    var direccionEntrega = string.Format("{0}, {1}, {2}, {3}", ShipCountry, ShipCity, ShipAddress, ShipPostalCode);
                    return direccionEntrega;
                }
                else
                {
                    var direccionEntrega = string.Format("{0}, {1}, {2}", ShipCountry, ShipCity, ShipAddress);
                    return direccionEntrega;
                }
                
            }
            set { }
        }
    }
}
