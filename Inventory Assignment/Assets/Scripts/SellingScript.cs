using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellingScript : MonoBehaviour
{
    public PurchaseManager manager;
    public GameObject sellingSlot;
    

    public void SellDatBook()
    {
            if (sellingSlot.transform.childCount > 0)
            {
            DestroyImmediate(sellingSlot.transform.GetChild(0).gameObject);
                Debug.Log("Book sold!");
            }
            else
            {
                Debug.Log("There is nothing to sell!");
            }
    }

    public void AddDatCash()
    {
        
        if (sellingSlot.transform.childCount > 0)
        {
            manager.dabloon += sellingSlot.transform.GetChild(0).GetComponent<Movement>().products.sellValue * sellingSlot.transform.GetChild(0).GetComponent<Movement>().count;
        }
    }
}
