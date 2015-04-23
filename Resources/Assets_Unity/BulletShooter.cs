using UnityEngine;
using System.Collections;

public class BulletShooter : MonoBehaviour 
{
	public Rigidbody myBulletPrefab;
	public int shootForce = 20;
	public AudioClip shootClip;
	public GameObject gun;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("Fire1"))
		{	
			Rigidbody bullet = Instantiate(myBulletPrefab, transform.position, transform.rotation) as  Rigidbody;
			bullet.velocity = transform.TransformDirection(new Vector3 (0,0,shootForce));
			audio.PlayOneShot(shootClip);
			gun.animation.Play ("shoot");
			gun.animation.PlayQueued ("idle");
		}
	}
}