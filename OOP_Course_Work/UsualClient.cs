using System;
using OOP_Course_Work.PaymentMethod;
namespace OOP_Course_Work
{
	class UsualClient : Client
    {      
		public UsualClient(String name, IPayment payment, int money,
		                   int cMoney, int cLim, String phone) 
			: base(name, payment, money, cMoney, cLim, phone)
		{}

        public override void GetOrder()
        {
			Console.WriteLine("Client get order");
        }
    }
}
