﻿using System;  namespace OOP_Course_Work.OrderType {     class LargeOrder : IOrderType     {         public int GetOrderSum(float weight, int deliveryCost)         {             return (int)(weight * 5 + deliveryCost);         }     } } 