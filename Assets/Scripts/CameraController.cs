using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float moveSpeed = 10f;
    private float minZ = -19.5f;
    private float maxZ = -1.45f;
    public float scrollSpeed = 10f;
    private float minY = 5f;
    private float maxY = 20f;

    void Update()
    {
        float moveZ = Input.GetAxis("Vertical");
        Vector3 currentPosition = transform.position;
        currentPosition.z += moveZ * moveSpeed * Time.deltaTime;
        currentPosition.z = Mathf.Clamp(currentPosition.z, minZ, maxZ);

        float moveY = Input.GetAxis("Mouse ScrollWheel");
        if (moveY != 0)
        {
            currentPosition.y -= moveY * scrollSpeed * 1000 * Time.deltaTime;
            currentPosition.y = Mathf.Clamp(currentPosition.y, minY, maxY);
        }

        float moveX = Input.GetAxis("Horizontal");
        currentPosition.x += moveX * moveSpeed * Time.deltaTime;
        transform.position = new Vector3(currentPosition.x, currentPosition.y, currentPosition.z);
    }
}
