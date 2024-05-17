using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PurchaseScript : MonoBehaviour
{
    public PurchaseManager manager;
    public Products[] bookPurchase;

    public void PurchaseFireBook(int id)
    {
        if (manager.dabloon > 5)
        {
            bool result = manager.AddBook(bookPurchase[id]);
            if (result == true)
            {
                Debug.Log("Fire Book Purchased!");
            }
            else
            {
                Debug.Log("Inventory Full!");
            }
            manager.dabloon = manager.dabloon - 5;
            manager.spellBookPrefab.tag = "FireBook";
        }
    }

    public void PurchaseCheeseBook(int id)
    {
        if (manager.dabloon > 10)
        {
            bool result = manager.AddBook(bookPurchase[id]);
            if (result == true)
            {
                Debug.Log("Cheese Book Purchased!");
            }
            else
            {
                Debug.Log("Inventory Full!");
            }
            manager.dabloon = manager.dabloon - 10;
            manager.spellBookPrefab.tag = "CheeseBook";
        }
    }

    public void PurchaseLightningBook(int id)
    {
        if (manager.dabloon > 7)
        {
            bool result = manager.AddBook(bookPurchase[id]);
            if (result == true)
            {
                Debug.Log("Zap Book Purchased!");
            }
            else
            {
                Debug.Log("Inventory Full!");
            }
            manager.dabloon = manager.dabloon - 7;
            manager.spellBookPrefab.tag = "ZapBook";
        }
    }

    public void PurchaseSpookyBook(int id)
    {
        if (manager.dabloon > 12)
        {
            bool result = manager.AddBook(bookPurchase[id]);
            if (result == true)
            {
                Debug.Log("Necromancy Book Purchased!");
            }
            else
            {
                Debug.Log("Inventory Full!");
            }
            manager.dabloon = manager.dabloon - 12;
            manager.spellBookPrefab.tag = "SpookyBook";
        }
    }

    public void PurchaseSwordBook(int id)
    {
        if (manager.dabloon > 15)
        {
            bool result = manager.AddBook(bookPurchase[id]);
            if (result == true)
            {
                Debug.Log("Sword Book Purchased!");
            }
            else
            {
                Debug.Log("Inventory Full!");
            }
            manager.dabloon = manager.dabloon - 15;
            manager.spellBookPrefab.tag = "SwordBook";
        }
    }
}
