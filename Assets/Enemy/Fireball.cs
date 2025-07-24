using UnityEngine;

public class Fireball : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(20);
        }
        Destroy(gameObject);
    }
}