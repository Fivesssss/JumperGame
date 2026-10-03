using UnityEngine;

public abstract class EnemyState : MonoBehaviour
{
    protected bool isStateActive;

    public abstract void Enter();

    public abstract void Execute();

    public abstract void FixedExecute();

    public abstract void Exit();
}
