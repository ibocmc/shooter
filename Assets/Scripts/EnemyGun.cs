using UnityEngine;
using System.Collections;

public class EnemyGun : MonoBehaviour {

	public float enemyGunSpeed;
	public Rigidbody rb;
	public Transform shotSpawn;
	public GameObject eshot;
	public float fireRate;
	public float delay;
	public AudioSource eses;
	//public float nextFire;


	// Use this for initialization
	void Start () {
		InvokeRepeating("Fire",delay,fireRate);
		rb.GetComponent<Rigidbody>();
		rb.velocity = transform.forward * enemyGunSpeed;
		eses.GetComponent<AudioSource>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void Fire () {
		
		if(eshot != null){
			//nextFire = Time.time + fireRate;
			Instantiate(eshot, shotSpawn.position, shotSpawn.rotation);
			eses.Play();

		}
	}


}
