using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public float speed = 70f;

    private void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        if (dir.magnitude <= speed * Time.deltaTime)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
    }

    public void HitTarget()
    {
        Debug.Log("Hit!");
        Destroy(gameObject);
        Destroy(target.gameObject);
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

}
