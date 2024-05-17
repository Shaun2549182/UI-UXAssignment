using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseManager : MonoBehaviour
{
    public ItemSlot[] itemSlots;
    public GameObject spellBookPrefab;
    public int dabloon;
    public Text dabloonText;

    public void Start()
    {
        dabloon = 100;
    }

    public bool AddBook(Products products)
    {
        for (int i = 0; i < itemSlots.Length; i++)
        {
            ItemSlot slot = itemSlots[i];
            Movement bookinslot = slot.GetComponentInChildren<Movement>();
            if (bookinslot != null && bookinslot.products == products && bookinslot.count < 3 && bookinslot.products.stackable == true)
            {
                bookinslot.count++;
                bookinslot.RefreshCount();
                return true;
            }
        }


        for (int i = 0; i < itemSlots.Length; i++)
        {
            ItemSlot slot = itemSlots[i];
            Movement bookinslot = slot.GetComponentInChildren<Movement>();
            if (bookinslot == null)
            {
                BuyNewBook(products, slot);
                return true;
            }
        }
        return false;
    }

    public void BuyNewBook(Products products, ItemSlot slot)
    {
        GameObject newBookGo = Instantiate(spellBookPrefab, slot.transform);
        Movement movement = newBookGo.GetComponent<Movement>();
        movement.InitiializeProduct(products);
    }

    public void Update()
    {
        dabloonText.text = dabloon.ToString();
    }
}
