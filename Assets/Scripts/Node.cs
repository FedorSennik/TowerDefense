using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Color hoverColor;
    [SerializeField] private Color selectedColor;
    [SerializeField] private Color normalColor;
    [SerializeField] private Material nodeMaterial;
    [SerializeField] private GameObject tower;

    private void Start()
    {
        nodeMaterial = GetComponent<MeshRenderer>().material;
        normalColor = nodeMaterial.color;
    }

    private void OnMouseEnter()
    {
        if (BuildManager.instance.towerToBuild == null)
        {
            return;
        }

        nodeMaterial.color = hoverColor;
    }

    private void OnMouseExit()
    {
        if (BuildManager.instance.towerToBuild == null)
        {
            return;
        }

        nodeMaterial.color = normalColor;
    }

    private void OnMouseDown()
    {
        if (BuildManager.instance.towerToBuild == null)
        {
            return;
        }

        if (tower == null)
        {
            tower = Instantiate(BuildManager.instance.towerToBuild, transform.position + offset, Quaternion.identity);
        }
        else
        {
            nodeMaterial.color = selectedColor;
        }
    }
}