using System;
using OOP_Course_Work.PhoneDispatch;
using OOP_Course_Work.Deliveryman;
using OOP_Course_Work.PaymentMethod;
using OOP_Course_Work.DeliveryType;
using OOP_Course_Work.PaymentCheker;

namespace OOP_Course_Work
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Receiver receiver = new Receiver(true, true, true);
			SenderCheck senderCheck = new SenderCheck();
			Order order = new Order(new ExpectingState());
			Random rnd = new Random();

			Console.WriteLine("Enter client name");
			String name = Console.ReadLine();
			Console.WriteLine("Enter client money");
			String money = Console.ReadLine();
			Console.WriteLine("Enter client card money");
			String cMoney = Console.ReadLine();
			Console.WriteLine("Enter client card limit");
			String cLim = Console.ReadLine();
			Console.WriteLine("Enter client phone");
			String phone = Console.ReadLine();

			Console.WriteLine("Enter amount of orders");
			String a = Console.ReadLine();
			Console.WriteLine("Enter weight of orders");
			String w = Console.ReadLine();

			UsualClient client = new UsualClient(name, 
			                                     new CashPayment(), 
			                                     Int32.Parse(money), 
			                                     Int32.Parse(cMoney), 
			                                     Int32.Parse(cLim), 
			                                     phone);

			order.Expecting();
            
			int buff = 0;
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine("Day: " + i);
				if(i == rnd.Next(0, 3))
				{
					order.DeliveredToStock();
					buff = i;
					break;
				}
			}

			for (int i = 0; i < 2; i++)
            {
				Console.WriteLine("Day: " + (i + buff));
				if (i == rnd.Next(1, 2))
                {
					order.InTransit();
                    buff = i + buff;
					break;
                }
            }

			for (int i = 0; i < 4; i++)
            {
				Console.WriteLine("Day: " + (i + buff));
                if (i == rnd.Next(0, 4))
                {
					order.DeliveredToCountry();
                    buff = i + buff;
                    break;
                }
            }
            
			senderCheck.SendOrder(client, Int32.Parse(w), Int32.Parse(a), GetDeliveryType("usual"));
			Console.WriteLine(client.Money);
            Console.WriteLine(client.CardMoney);
            Console.WriteLine(client.CardLimitMoney);
			order.DeliveredToClient();
        }

		public static IDeliveryType GetDeliveryType(String s)
		{
			switch(s.ToLower())
			{
				case "usual": return new UsualDelivery();
				case "fast": return new FastDelivery();
				case "pickup": return new Pickup();
				default: return new Pickup();
			}
		}
    }
}
