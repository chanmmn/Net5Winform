using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMaintenance.Model
{
	public class Products
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public int SupplierID { get; set; }
		public int CategoryID { get; set; }
		public string QuantityPerUnit { get; set; }
		public decimal UnitPrice { get; set; }
		public short UnitsInStock { get; set; }
		public short UnitsOnOrder { get; set; }
		public short ReorderLevel { get; set; }
		public bool Discontinued { get; set; }

		public Products() { }
		public Products(int ProductID_, string ProductName_, int SupplierID_, int CategoryID_, string QuantityPerUnit_, decimal UnitPrice_, short UnitsInStock_, short UnitsOnOrder_, short ReorderLevel_, bool Discontinued_)
		{
			this.ProductID = ProductID_;
			this.ProductName = ProductName_;
			this.SupplierID = SupplierID_;
			this.CategoryID = CategoryID_;
			this.QuantityPerUnit = QuantityPerUnit_;
			this.UnitPrice = UnitPrice_;
			this.UnitsInStock = UnitsInStock_;
			this.UnitsOnOrder = UnitsOnOrder_;
			this.ReorderLevel = ReorderLevel_;
			this.Discontinued = Discontinued_;
		}
	}
}
