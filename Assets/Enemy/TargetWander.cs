using UnityEngine;

public class TargetWander : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float wanderRadius = 30f;

    private Vector3 targetPoint;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetNewDestination();
    }

    void Update()
    {
        Vector3 move = (targetPoint - transform.position);
        if (move.magnitude > 0.2f)
        {
            Vector3 moveDir = move.normalized * moveSpeed * Time.deltaTime;
            rb.MovePosition(transform.position + moveDir);
        }
        else
        {
            SetNewDestination();
        }
    }

    void SetNewDestination()
    {
        Vector3 randomDirection = Random.insideUnitSphere * wanderRadius;
        randomDirection.y = 0;
        targetPoint = transform.position + randomDirection;
    }
}