﻿using System; using OOP_Course_Work.DeliveryType;  namespace OOP_Course_Work.PaymentCheker {     class Sender : AbsSender     {         public override void SendOrder(Client client, float weight, int amount, IDeliveryType delivery)         {             Console.WriteLine("Send order for client");         }     } } 