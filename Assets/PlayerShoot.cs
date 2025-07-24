using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Camera playerCam;
    public GameObject hitEffectPrefab;
    public float shootRange = 50f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Ray ray = playerCam.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, shootRange))
        {
            if (hitEffectPrefab)
                Instantiate(hitEffectPrefab, hit.point, Quaternion.LookRotation(hit.normal));

            var target = hit.collider.GetComponent<Target>();
            if (target)
                target.OnHit();
        }
    }
}