﻿using System; using OOP_Course_Work.PaymentCheker; namespace OOP_Course_Work.PaymentMethod {     class CashPayment : IPayment     {         public bool PayForOrder(Client client, int sum)         {             if (client.Money - sum < 0) return false;             else             {                 client.Money = client.Money - sum;                 return true;             }         }     } }