using UnityEngine;

public class BulletV2 : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float bulletSpeed = 100f;

    [SerializeField]private Player player;

    private void Start()
    {
        player = GameObject.Find("PlayerUI").GetComponent<Player>();

    }
    public void SetTarget(Transform targetTransform)
    {
        target = targetTransform;
        if (target != null)
        {
            Debug.Log($"Target assigned to bullet: {target.name}");
        }
        else
        {
            Debug.LogError("Target is null! Bullet won't move.");
        }
    }

    private void Update()
    {
        if (target == null)
        {
            Debug.Log("Target is null. Destroying bullet.");
            Destroy(gameObject);
            player.coins = player.coins + 30;
            return;

        }

        Vector3 direction = target.position - transform.position;
        float distanceThisFrame = bulletSpeed * Time.deltaTime;
        Debug.Log($"Bullet moving towards: {target.name}, Speed: {bulletSpeed}, Distance this frame: {distanceThisFrame}");

        if (direction.magnitude <= distanceThisFrame)
        {
            Debug.Log($"Bullet hit the target: {target.name}");
            HitTarget();
            return;
        }

        transform.Translate(direction.normalized * distanceThisFrame, Space.World);
    }




    private void HitTarget()
    {
        Destroy(target.gameObject); // Удаляем объект цели
        Destroy(gameObject); // Удаляем пулю
    }
}
