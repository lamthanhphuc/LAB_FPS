using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject fireballPrefab;
    public float shootInterval = 3f;
    public Transform player;
    public float fireballSpeed = 20f;

    private float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > shootInterval)
        {
            Shoot();
            timer = 0;
        }
    }

    void Shoot()
    {
        if (player)
        {
            GameObject fireball = Instantiate(fireballPrefab, transform.position + Vector3.up * 4f, Quaternion.identity);
            fireball.GetComponent<Rigidbody>().linearVelocity = (player.position - transform.position).normalized * fireballSpeed;
        }
    }
}