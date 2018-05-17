using System;
namespace OOP_Course_Work.SupportService
{
	class Chatroom : AbstractChatroom
    {
		public Colleague Client { get; set; }
		public Colleague Suport { get; set; }

		public override void Send(string msg, Colleague colleague)
		{
			if (Client == colleague)
				Suport.Notify(msg);
			else if (Suport == colleague)
				Client.Notify(msg);
		}
	}
}
