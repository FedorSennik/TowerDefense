using UnityEngine;

[CreateAssetMenu(fileName = "New Tower Data", menuName = "Tower/Tower Data")]
public class TowerDATA : ScriptableObject
{
    public int range;
    public int kd;
    public GameObject bulletPrefab;
}
