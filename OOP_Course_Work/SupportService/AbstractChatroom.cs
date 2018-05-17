using System;
namespace OOP_Course_Work.SupportService
{
	abstract class AbstractChatroom
    {
		public abstract void Send(string msg, Colleague colleague);
    }
}
