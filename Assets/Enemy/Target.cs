using UnityEngine;

public class Target : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void OnHit()
    {
        currentHealth -= 20;
        if (currentHealth <= 0)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                PlayerHealth ph = player.GetComponent<PlayerHealth>();
                if (ph != null)
                {
                    ph.AddKill();
                }
            }
            Destroy(gameObject);
        }
    }
}