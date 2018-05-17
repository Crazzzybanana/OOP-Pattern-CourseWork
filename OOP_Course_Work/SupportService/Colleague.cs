using System;
namespace OOP_Course_Work.SupportService
{
	abstract class Colleague
    {
		protected AbstractChatroom chatroom;

		public Colleague(AbstractChatroom chatroom)
		{
			this.chatroom = chatroom;
		}

		public virtual void Send(string message)
		{
			chatroom.Send(message, this);
		}

		public abstract void Notify(string message);
    }
}
