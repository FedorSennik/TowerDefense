using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    Player player;

    private int ScoutPrice = 75;
    private int SoldierPrice = 125;
    private int SniperPrice = 150;

    [SerializeField] TextMeshProUGUI scoutPrice;
    [SerializeField] TextMeshProUGUI soldierPrice;
    [SerializeField] TextMeshProUGUI sniperPrice;

    private void Start()
    {
        scoutPrice.text = ScoutPrice.ToString();
        soldierPrice.text = SoldierPrice.ToString();
        sniperPrice.text = SniperPrice.ToString();

        print($"{player.coins}");
    }

    public void PurchaseScout()
    {
        if (player.coins >= ScoutPrice)
        {
            BuildManager.instance.SetTowerToBuild(BuildManager.instance.Scout);
            player.coins =- ScoutPrice;

            print("Scout");
        }
    }

    public void PurchaseSoldier()
    {
        if (player.coins >= SoldierPrice)
        {
            BuildManager.instance.SetTowerToBuild(BuildManager.instance.Soldier);
            player.coins =- SoldierPrice;
            print("Sniper");

        }
    }
    public void PurchaseSniper()
    {
        if (player.coins >= SniperPrice)
        {
            BuildManager.instance.SetTowerToBuild(BuildManager.instance.Sniper);
            player.coins =- SniperPrice;
            print("Sniper");

        }
    }
}
