using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    [SerializeField] private Transform target;
    private int waypointIndex = 0;
    public Player player;

    private void Start()
    {
        player = GameObject.Find("PlayerUI").GetComponent<Player>();
        target = Waypoints.waypoints[0];
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }

    private void GetNextWaypoint()
    {
        if (waypointIndex >= Waypoints.waypoints.Length - 1)
        {
            player.TakeDamage();
            Destroy(gameObject);
        }

        waypointIndex++;
        target = Waypoints.waypoints[waypointIndex];
    }
}