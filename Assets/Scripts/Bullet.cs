using UnityEngine;

public class Bullet : MonoBehaviour
{
	private Transform target;

	public float speed = 70f;

	public GameObject RocketAOEGO;
	public RocketAOE RocketScript;

    private void Start()
    {
		RocketAOEGO = GameObject.FindGameObjectWithTag("Rocket");
		RocketScript = RocketAOEGO.GetComponent<RocketAOE>();
	}
    public void Seek(Transform _target)
	{
		target = _target;
	}

	void Update()
	{

		if (target == null)
		{
			Destroy(gameObject);
			return;
		}

		Vector3 dir = target.position - transform.position;
		float distanceThisFrame = speed * Time.deltaTime;

		if (dir.magnitude <= distanceThisFrame)
		{
			HitTarget();
			return;
		}

		transform.Translate(dir.normalized * distanceThisFrame, Space.World);
		transform.LookAt(target);

	}

	void HitTarget()
	{
		RocketScript.Shot();
		Destroy(gameObject);
	}

	private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}