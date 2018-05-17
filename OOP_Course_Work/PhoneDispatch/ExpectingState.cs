using System;
namespace OOP_Course_Work.PhoneDispatch
{
	class ExpectingState : OrderState
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
			order.State = new DeliveredToStockState();
		}

		public void Expecting(Order order)
		{
			Console.WriteLine("Order is registered");
		}

		public void InTransit(Order order)
		{
			throw new NotImplementedException();
		}
	}
}
