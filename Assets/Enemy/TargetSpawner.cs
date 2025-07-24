using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;
    public int maxTargets = 5;
    public float spawnRadius = 40f;

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Target").Length < maxTargets)
        {
            Vector3 pos = transform.position + new Vector3(Random.Range(-spawnRadius, spawnRadius), 0, Random.Range(-spawnRadius, spawnRadius));
            Instantiate(targetPrefab, pos, Quaternion.identity);
        }
    }
}