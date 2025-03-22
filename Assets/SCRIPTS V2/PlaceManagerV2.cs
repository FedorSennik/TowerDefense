using UnityEngine;

public class PlaceManagerV2 : MonoBehaviour
{
    public GameObject SelectedModel { get; private set; }

    [SerializeField] private GameObject scoutPrefab;
    [SerializeField] private GameObject soldierPrefab;
    [SerializeField] private GameObject sniperPrefab;

    public int selectedTowerPrice;
    private int scoutPrice = 75;
    private int soldierPrice = 100;
    private int sniperPrice = 125;

    [SerializeField] private Player player;

    private void Start()
    {
        player = GameObject.Find("PlayerUI").GetComponent<Player>();
    }

    public void SelectScout()
    {
        selectedTowerPrice = scoutPrice;
        SelectedModel = scoutPrefab;
        Debug.Log("Scout selected");
    }

    public void SelectSoldier()
    {
        selectedTowerPrice = soldierPrice;
        SelectedModel = soldierPrefab;
        Debug.Log("Soldier selected");
    }

    public void SelectSniper()
    {
        selectedTowerPrice = sniperPrice;
        SelectedModel = sniperPrefab;
        Debug.Log("Sniper selected");
    }
}
