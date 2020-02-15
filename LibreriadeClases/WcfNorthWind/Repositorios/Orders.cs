using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibreriadeClases;

namespace WcfNorthWind.Repositorios
{
    internal class Orders
    {
        private static NorthwindEntities _elRepositorio = new NorthwindEntities();

        internal IList<LibreriadeClases.Orders> OrdersByShipper(int shipperID)
        {
            var lasOrdenes = _elRepositorio.Orders.Where(s => s.ShipVia.Equals(shipperID)).ToList();
            return lasOrdenes;
        }
    }
}