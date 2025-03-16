using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewTowerData", menuName = "NewTower")]
public class TowerData : ScriptableObject
{
    public GameObject bulletPrefab;
    public float range;
    public float damage;
    public float cooldown;
}
