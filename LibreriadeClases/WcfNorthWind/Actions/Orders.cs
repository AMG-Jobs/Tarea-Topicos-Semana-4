using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibreriadeClases;

namespace WcfNorthWind.Actions
{
    internal class Orders
    {
        private static NorthwindEntities _elRepositorio = new NorthwindEntities();

        public IList<LibreriadeClases.Orders> OrdersByShipper(int shipperID)
        {
            var elRepositorio = new Repositorios.Orders();
            var elResultado = elRepositorio.OrdersByShipper(shipperID);
            return elResultado;
        }
    }
}