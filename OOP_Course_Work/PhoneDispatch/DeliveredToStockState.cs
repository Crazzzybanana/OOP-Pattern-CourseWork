using System;
namespace OOP_Course_Work.PhoneDispatch
{
	class DeliveredToStockState : OrderState
    {      
		public void DeliveredToClient(Order order)
		{
			throw new NotImplementedException();
		}

		public void DeliveredToCountry(Order order)
		{
			throw new NotImplementedException();
		}

		public void DeliveredToStock(Order order)
		{
			Console.WriteLine("Order is delivered to Stock");
		}

		public void Expecting(Order order)
		{
			throw new NotImplementedException();
		}

		public void InTransit(Order order)
		{
			Console.WriteLine("Order is in transit");
			order.State = new InTransitState();
		}
	}
}
