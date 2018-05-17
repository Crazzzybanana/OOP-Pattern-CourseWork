using System;
namespace OOP_Course_Work.SupportService
{
	class SuportColleague : Colleague
    {
		public SuportColleague(AbstractChatroom chatroom) : base(chatroom)
        {
        }

		public override void Notify(string message)
		{
			Console.WriteLine("Message for client: " + message);
		}
	}
}
