using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Taxi.Service
{
    public class Service
    {
        public List<Automobile> GetAutomobileCollection()
        {
            List<Automobile> automobiles = new List<Automobile>();
            automobiles.Add(new Automobile() {CarBrand = "BMW",Collor = "Black", YearMake = "2014", Mileage =100000 });
            automobiles.Add(new Automobile() {CarBrand = "BMW",Collor = "White", YearMake = "2013", Mileage =100 });
            automobiles.Add(new Automobile() {CarBrand = "Shkoda",Collor = "Blue", YearMake = "2012", Mileage =1050 });
            automobiles.Add(new Automobile() {CarBrand = "Lada",Collor = "Black", YearMake = "2014", Mileage =10 });
            automobiles.Add(new Automobile() {CarBrand = "Toyota",Collor = "Red", YearMake = "2014", Mileage =100 });
            return automobiles;
        }
    }
}