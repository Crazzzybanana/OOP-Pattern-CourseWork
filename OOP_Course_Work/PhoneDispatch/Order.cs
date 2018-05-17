using System;
namespace OOP_Course_Work.PhoneDispatch
{
    class Order
    {
		public OrderState State { get; set; }

		public Order(OrderState os)
		{
			State = os;
		}

		public void DeliveredToClient()
		{
			State.DeliveredToClient(this);
		}

		public void DeliveredToCountry()
		{
			State.DeliveredToCountry(this);
		}
        
		public void DeliveredToStock()
		{
			State.DeliveredToStock(this);
		}

		public void Expecting()
		{
			State.Expecting(this);
		}

		public void InTransit()
		{
			State.InTransit(this);
		}
    }
}
