using System;
namespace OOP_Course_Work.PhoneDispatch
{
	class DeliveredToClientState : OrderState
	{
        public void Expecting(Order order)
        {
            throw new NotImplementedException();
        }

        public void DeliveredToStock(Order order)
        {
            throw new NotImplementedException();
		}

        public void InTransit(Order order)
        {
            throw new NotImplementedException();
        }

		public void DeliveredToCountry(Order order)
		{
			throw new NotImplementedException();
		}

		public void DeliveredToClient(Order order)
        {
			Console.WriteLine("Thank you for choosing us");
        }
	}
}
