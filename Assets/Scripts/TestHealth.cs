using UnityEngine;

public class TestHealth : MonoBehaviour
{
    [SerializeField] private float heal = 0.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null) 
            {
                playerHealth.addHealth(heal);
            }
        }
    }
}
