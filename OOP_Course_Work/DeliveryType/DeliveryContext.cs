﻿using System; namespace OOP_Course_Work.DeliveryType {     class DeliveryContext     {         public IDeliveryType _deliveryType;         public float _weight;         public int _amount;          public void SetDeliveryType(IDeliveryType delivery)         {             _deliveryType = delivery;         }          public float Weight         {             get { return _weight; }             set { _weight = value; }         }          public int Amount         {             get { return _amount; }             set { _amount = value; }         }          public int DelivetyCost         {             get { return _deliveryType.CalculateDeliveryValue(_weight, _amount); }         }     } } 