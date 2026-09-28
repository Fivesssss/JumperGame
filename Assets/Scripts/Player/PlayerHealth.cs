using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float setHealth; //used to set player health in the unity insepctor
    private float health;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = setHealth;
    }

    public void doDamage(float damage) 
    {
        if (health >= damage)
        {
            health -= damage;
        }
        else 
        {
            health = 0;
            //add death screen or something
            Destroy(gameObject);
        }
    }

    public void addHealth(float amount) 
    {
        if (health + amount < setHealth)
        {
            health += amount;
        }
        else if (health + amount >= setHealth) 
        {
            health = setHealth;
        }
    }

    public float getHealth() 
    {
        return health;
    }
}
