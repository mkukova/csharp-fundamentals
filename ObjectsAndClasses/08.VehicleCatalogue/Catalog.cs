using System.Linq;
using System.Collections.Generic;

namespace _08.VehicleCatalogue
{
	class Catalog
	{
		public Catalog()
		{
			this.Cars = new List<Car>();
			this.Trucks = new List<Truck>();
		}
		public List<Car> Cars { get; set; }
		public List<Truck> Trucks { get; set; }
	}
}
