using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeScript : MonoBehaviour
{
    public PurchaseManager manager;
    public int UpgradePrice = 25;
    public GameObject upgrade;
    public GameObject upgradeButton;


    public void UpgradeDat()
    {
        if (manager.dabloon > UpgradePrice)
        {
            upgrade.SetActive(true);
            manager.dabloon = manager.dabloon - UpgradePrice;
            upgradeButton.SetActive(false);
        }
        else
        {
            Debug.Log("Not Enough Dabloons!");
        }
    }
}
