using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMaintenance.Model
{
	public class OrderDetails
	{
		public int OrderID { get; set; }
		public int ProductID { get; set; }
		public decimal UnitPrice { get; set; }
		public short Quantity { get; set; }
		public Single Discount { get; set; }

		public OrderDetails(int OrderID_, int ProductID_, decimal UnitPrice_, short Quantity_, Single Discount_)
		{
			this.OrderID = OrderID_;
			this.ProductID = ProductID_;
			this.UnitPrice = UnitPrice_;
			this.Quantity = Quantity_;
			this.Discount = Discount_;
		}
	}
}
