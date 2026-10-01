using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private GameObject waypoint1; // point 1 for the enemy to patrol to
    [SerializeField] private GameObject waypoint2; // point 2 for the enemy to patrol to
    [SerializeField] private float patrolSpeed = 2f;

    private bool hasReachedWaypoint1 = false;
    private bool hasReachedWaypoint2 = false;
    private Vector2 enemyMovementVector;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        //check to see if the enemy is already at one of the waypoints upon spawning
        if (transform.position == waypoint1.transform.position)
        {
            hasReachedWaypoint1 = true;
        }
        else if(transform.position == waypoint2.transform.position)
        {
            hasReachedWaypoint2 = true;
        }
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }
}
