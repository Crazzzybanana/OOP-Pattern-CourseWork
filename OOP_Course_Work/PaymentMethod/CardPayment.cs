﻿using System; using OOP_Course_Work.PaymentCheker; namespace OOP_Course_Work.PaymentMethod {     class CardPayment : IPayment     {         public bool PayForOrder(Client client, int sum)         {             if (client.CardMoney - sum < 0)             {                 if (client.CardLimitMoney < sum) return false;                 int buf = client.CardMoney - sum;                 client.CardMoney = 0;                 client.CardLimitMoney = client.CardLimitMoney + buf;                 return true;             }             else if (client.CardMoney - sum >= 0)             {                 client.CardMoney = client.CardMoney - sum;                 return true;             }             else return false;         }     } } 