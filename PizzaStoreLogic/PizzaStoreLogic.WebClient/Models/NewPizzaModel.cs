using PizzaStoreLogic.Logic;
using PizzaStoreLogic.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreLogic.WebClient.Models
{
    public class NewPizzaModel
    {
        private DataService _Data = new DataService();
        private List<SizeDTO> _Sizes = new DataService().GetSizes();
        private List<CrustDTO> _Crusts = new DataService().GetCrusts();
        private List<SauceDTO> _Sauces = new DataService().GetSauces();
        private List<CheeseDTO> _Cheeses = new DataService().GetCheeses();
        private List<MeatDTO> _Meats = new DataService().GetMeats();
        private List<VegetableDTO> _Vegetables = new DataService().GetVegetables();

        public List<SizeDTO> Sizes { get { return _Sizes; } set { _Sizes = value; } }
        public List<CrustDTO> Crusts { get { return _Crusts; } set { _Crusts = value; } }
        public List<SauceDTO> Sauces { get { return _Sauces; } set { _Sauces = value;} }
        public List<CheeseDTO> Cheeses { get { return _Cheeses; } set { _Cheeses = value; } }
        public List<MeatDTO> Meats { get { return _Meats; } set { _Meats = value; } }
        public List<VegetableDTO> Vegetables { get { return _Vegetables; } set { _Vegetables = value; } }
        public int Quantity { get; set; }
    }
}