using System.Collections;
using UnityEngine;

public class Gun2 : MonoBehaviour
{
    [SerializeField]
    private bool AddBulletSpread = true;
    [SerializeField]
    private Vector3 BulletSpreadVariance = new Vector3(0.05f, 0.05f, 0.05f);
    [SerializeField]
    private ParticleSystem ShootingSystem;
    [SerializeField]
    private Transform BulletSpawnPoint;
    [SerializeField]
    private TrailRenderer BulletTrail;
    [SerializeField]
    private float BulletSpeed = 10;
    public LayerMask Mask;
    public bool Cooldown;

    public float damage = 1f;
    public float range = 10f;

    public Camera MainCamera;
    public void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        if (!Cooldown)
        {
            RaycastHit hit;
            if (Physics.Raycast(MainCamera.transform.position, MainCamera.transform.forward, out hit, range) && !Cooldown)
            {
                EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
                if (target != null)
                {
                    target.TakeDamage();

                    StartCoroutine(Shooting());

                    if (Physics.Raycast(BulletSpawnPoint.position, BulletSpawnPoint.transform.forward, out hit, float.MaxValue, Mask))
                    {
                        TrailRenderer trail = Instantiate(BulletTrail, BulletSpawnPoint.position, Quaternion.identity);

                        StartCoroutine(SpawnTrail(trail, hit.point, hit.normal, true));
                    }
                    // this has been updated to fix a commonly reported problem that you cannot fire if you would not hit anything
                    else
                    {
                        TrailRenderer trail = Instantiate(BulletTrail, BulletSpawnPoint.position, Quaternion.identity);

                        StartCoroutine(SpawnTrail(trail, BulletSpawnPoint.position + BulletSpawnPoint.transform.forward * 100, Vector3.zero, false));

                    }
                }
            }
        }
    }

    private IEnumerator SpawnTrail(TrailRenderer Trail, Vector3 HitPoint, Vector3 HitNormal, bool MadeImpact)
    {

        Vector3 startPosition = Trail.transform.position;
        float distance = Vector3.Distance(Trail.transform.position, HitPoint);
        float remainingDistance = distance;

        while (remainingDistance > 0)
        {
            Trail.transform.position = Vector3.Lerp(startPosition, HitPoint, 1 - (remainingDistance / distance));

            remainingDistance -= BulletSpeed * Time.deltaTime;

            yield return null;
        }
        Trail.transform.position = HitPoint;

        Destroy(Trail.gameObject, Trail.time);
    }

    IEnumerator Shooting()
    {
        Cooldown = true;
        yield return new WaitForSeconds(1f);
        Cooldown = false;
    }
}