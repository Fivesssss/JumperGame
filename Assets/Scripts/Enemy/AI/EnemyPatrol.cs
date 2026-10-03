using UnityEngine;

public class EnemyPatrol : EnemyState
{
    [SerializeField] private GameObject waypoint1; // point 1 for the enemy to patrol to
    [SerializeField] private GameObject waypoint2; // point 2 for the enemy to patrol to
    [SerializeField] private float patrolSpeed = 2f;

    private bool hasReachedWaypoint1 = false;
    private bool hasReachedWaypoint2 = false;
    private Vector2 enemyMovementVector;

    public override void Enter()
    {
        throw new System.NotImplementedException();
    }

    public override void Execute()
    {
        //check to see if the enemy is already at one of the waypoints upon spawning
        if (transform.position == waypoint1.transform.position)
        {
            hasReachedWaypoint1 = true;
        }
        else if (transform.position == waypoint2.transform.position)
        {
            hasReachedWaypoint2 = true;
        }
    }

    public override void FixedExecute()
    {
        throw new System.NotImplementedException();
    }

    public override void Exit()
    {
        throw new System.NotImplementedException();
    }
}
