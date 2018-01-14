using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

public class IAPProductList : MonoBehaviour
{
    public IAPProduct[] productList = new IAPProduct[0];

    /// <summary>
    /// When purchase is complete, use this to search for completed product and execute its actions
    /// </summary>
    /// <param name="productID_toFind"></param>
    /// <param name="products"></param>
    public void DoOnComplete(string productID_toFind)
    {
        for (int i = 0; i < productList.Length; i++)
        {
            if (productList[i].productID == productID_toFind)
            {
                productList[i].doOnComplete.Invoke();
                break;
            }
        }
    }
}
