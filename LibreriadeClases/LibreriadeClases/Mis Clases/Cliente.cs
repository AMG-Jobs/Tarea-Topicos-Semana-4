using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriadeClases
{
    public partial class Customers
    {
        public string Direccion {
            get {
                //pais,ciudad,direccion,codpostal
                var direccion = string.Format("{0}, {1}, {2}, {3}", Country, City, Address, PostalCode);
                return direccion;
            }
            set { }
        }

        public string InformacionContacto {
            get {
                //nombre, title,company
                var informacionContacto = string.Format("{0}, {1} of {2}", ContactName, ContactTitle, CompanyName);
                return informacionContacto;
            }
            set { }
        }
    }
}
