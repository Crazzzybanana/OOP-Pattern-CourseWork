using System;
namespace OOP_Course_Work.PhoneDispatch
{
	class InTransitState : OrderState
    {
		public void DeliveredToClient(Order order)
		{
			throw new NotImplementedException();
		}

		public void DeliveredToCountry(Order order)
		{
			Console.WriteLine("Order is delivered to country");
			order.State = new DeliveredToCountryState();
		}

		public void DeliveredToStock(Order order)
		{
			throw new NotImplementedException();
		}

		public void Expecting(Order order)
		{
			throw new NotImplementedException();
		}

		public void InTransit(Order order)
		{
			Console.WriteLine("Order is in transit");
		}
	}
}
