using System;
namespace OOP_Course_Work.PhoneDispatch
{
    interface OrderState
    {
		void Expecting(Order order);
		void DeliveredToStock(Order order);
		void InTransit(Order order);
		void DeliveredToCountry(Order order);
		void DeliveredToClient(Order order);
    }
}
