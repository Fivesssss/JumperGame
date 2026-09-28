using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float setHealth; //used to set player health in the unity insepctor
    [SerializeField] HealthUI healthUI;
    private float health;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = setHealth;
        healthUI.setHeartsFull();
    }

    public void doDamage(float damage) 
    {
        health -= damage;
        healthUI.removeHearts(damage);

        if (health <= 0) 
        {
            Destroy(gameObject);
        }
    }

    public void addHealth(float amount) 
    {
        if (health + amount < setHealth)
        {
            health += amount;
            healthUI.addHearts(amount);
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
