using System;
namespace OOP_Course_Work.PhoneDispatch
{
	class DeliveredToCountryState : OrderState
    {      
		public void DeliveredToClient(Order order)
		{
			Console.WriteLine("Thank you for choosing us");
			order.State = new DeliveredToClientState();
		}

		public void DeliveredToCountry(Order order)
		{
			Console.WriteLine("Order is delivered to country");
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
			throw new NotImplementedException();
		}
	}
}
