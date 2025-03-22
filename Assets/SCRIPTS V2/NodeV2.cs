using UnityEngine;

public class NodeV2 : MonoBehaviour
{
    private Renderer rend;
    private Color startColor;
    public Color hoverColor = Color.blue;

    [SerializeField] private Player player;
    private GameObject tower;
    [SerializeField] private PlaceManagerV2 placeManager;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        placeManager = GameObject.Find("PlaceManagerV2").GetComponent<PlaceManagerV2>();
        player = GameObject.Find("PlayerUI").GetComponent<Player>();

    }

    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    private void OnMouseDown()
    {
        if (placeManager == null)
        {
            Debug.LogError("PlaceManager is not assigned in NodeV2!");
            return;
        }

        if (placeManager.SelectedModel != null && tower == null && placeManager.selectedTowerPrice <= player.coins)
        {
            tower = Instantiate(placeManager.SelectedModel, transform.position + Vector3.up, Quaternion.identity);
            Debug.Log("Tower placed");
            player.coins -= placeManager.selectedTowerPrice;
        }
    }

}
