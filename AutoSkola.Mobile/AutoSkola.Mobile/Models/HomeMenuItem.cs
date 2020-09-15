using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        RasporedCasova,
        SalnjeZahtjeva,
        PodaciOObuci,
        Usluge,
        Uplate,
        OdjaviSe,
        Instruktori,
        Pocetna
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
