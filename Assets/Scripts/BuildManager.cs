using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        instance = this;
    }

    public GameObject Scout;
    public GameObject Soldier;
    public GameObject Sniper;

    public GameObject towerToBuild;

    public GameObject GetTowerToBuild()
    {
        return towerToBuild;
    }

    public void SetTowerToBuild(GameObject tower)
    {
        towerToBuild = tower;
    }
}