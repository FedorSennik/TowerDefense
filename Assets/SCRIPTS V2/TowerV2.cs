using UnityEngine;

public class TowerV2 : MonoBehaviour
{
    [SerializeField] private TowerDATA towerData;
    [SerializeField] private float rotateSpeed = 5f;
    private float fireCooldown = 0f;

    private Transform target;

    private void Update()
    {
        FindClosestEnemy();

        if (target != null)
        {
            RotateTowardsTarget();

            if (fireCooldown <= 0f)
            {
                Shoot();
                fireCooldown = towerData.kd;
            }

            fireCooldown -= Time.deltaTime;
        }
    }

    private void FindClosestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float shortestDistance = towerData.range;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            Debug.Log($"Found enemy: {enemy.name}, Distance: {distanceToEnemy}");

            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null)
        {
            Debug.Log($"Closest enemy: {nearestEnemy.name}, Distance: {shortestDistance}");
        }
        else
        {
            Debug.Log("No enemies found within range.");
        }

        target = nearestEnemy?.transform;
    }


    private void RotateTowardsTarget()
    {
        Vector3 direction = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        Vector3 rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * rotateSpeed).eulerAngles;

        transform.rotation = Quaternion.Euler(0f, rotation.y, 0f);
    }

    private void Shoot()
    {
        Debug.Log("Shoot method called!");
        GameObject bullet = Instantiate(towerData.bulletPrefab, transform.position + Vector3.up, Quaternion.identity);
        BulletV2 bulletScript = bullet.GetComponent<BulletV2>();
        if (bulletScript != null)
        {
            bulletScript.SetTarget(target);
            Debug.Log("Bullet instantiated");


        }
    }
}