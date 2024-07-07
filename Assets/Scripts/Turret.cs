using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour
{

	private Transform target;
	private EnemyHealth targetEnemy;

	[Header("General")]

	public float range = 15f;

	[Header("Use Bullets (default)")]
	public GameObject bulletPrefab;
	public float fireRate = 1f;
	private float fireCountdown = 0f;

	[Header("Use Laser")]
	public bool useLaser = false;

	public int damageOverTime = 30;
	public float slowAmount = .5f;

	//public LineRenderer lineRenderer;

	[Header("Unity Setup Fields")]

	public string enemyTag = "Enemy";

	public Transform partToRotate;
	public float turnSpeed = 10f;

	public Transform firePoint;
	public Transform firePoint2;

	public bool RocketTurret;
	public bool NormalTurret;

	public float CooldownTime = 1f;
	public bool Cooldown;

	public AudioSource RocketTurretAudio;
	public AudioSource NormalTurretAudio;

	// Use this for initialization
	void Start()
	{
		InvokeRepeating("UpdateTarget", 0f, 0.5f);
	}

	void UpdateTarget()
	{
		GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
		float shortestDistance = Mathf.Infinity;
		GameObject nearestEnemy = null;
		foreach (GameObject enemy in enemies)
		{
			float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
			if (distanceToEnemy < shortestDistance)
			{
				shortestDistance = distanceToEnemy;
				nearestEnemy = enemy;
			}
		}

		if (nearestEnemy != null && shortestDistance <= range)
		{
			target = nearestEnemy.transform;
			targetEnemy = nearestEnemy.GetComponent<EnemyHealth>();
		}
		else
		{
			target = null;
		}

	}

	// Update is called once per frame
	void Update()
    {

        LockOnTarget();

        if (useLaser)
        {
            if (!Cooldown)
            {
                Shoot();
                Laser();
                StartCoroutine(CooldownDelay());

            }
        }
    }

    IEnumerator CooldownDelay()
    {
        Cooldown = true;
        yield return new WaitForSecondsRealtime(CooldownTime);
        Cooldown = false;

    }

	void LockOnTarget()
	{
		Vector3 dir = target.position - transform.position;
		Quaternion lookRotation = Quaternion.LookRotation(dir);
		Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
		partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);
	}

	void Laser()
	{
		if(RocketTurret)
        {
			targetEnemy.TakeDamage();
			targetEnemy.Shot();
			RocketTurretAudio.Play();
		}

		
		targetEnemy.TakeDamage();

		Vector3 dir = firePoint.position - target.position;
	}

	void Shoot()
	{
		GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		Bullet bullet = bulletGO.GetComponent<Bullet>();

		if(RocketTurret)
        {
			Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
			RocketTurretAudio.Play();

		}

		if (NormalTurret)
		{
			NormalTurretAudio.Play();
		}

		if (bullet != null)
			bullet.Seek(target);

	}

	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, range);
	}
}