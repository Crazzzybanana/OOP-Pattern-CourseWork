using System;
namespace OOP_Course_Work.SupportService
{
	class ClientColleague : Colleague
    {
		public ClientColleague(AbstractChatroom chatroom) : base(chatroom)
        {
        }

		public override void Notify(string message)
		{
			Console.WriteLine("Message for support service: " + message);
		}
	}
}
