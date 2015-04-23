using UnityEngine;
using System.Collections;

public class BulletHit : MonoBehaviour 
{
	public GameObject explosion;
	
	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Bullet")
		{
			Destroy (gameObject);
			Destroy (other.gameObject);
			Instantiate(explosion, transform.position, transform.rotation);
		}
	}
}
