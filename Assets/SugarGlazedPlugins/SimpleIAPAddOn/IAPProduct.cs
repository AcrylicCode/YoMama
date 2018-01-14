using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;

[System.Serializable]
public class IAPProduct
{
    public string productID = "";
    public UnityEvent doOnComplete = new UnityEvent();
    public ProductType productType = ProductType.Consumable;
}
