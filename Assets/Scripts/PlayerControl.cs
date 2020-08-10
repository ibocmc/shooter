using UnityEngine;
using System.Collections;
[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;

}

public class PlayerControl : MonoBehaviour {
	public Rigidbody rb;
	public float speed;
	public Boundary boundary;
	public float tilt;


	public Transform shotSpawn;
	public GameObject shot;
	public AudioSource ses;

	public float fireRate;
	private float nextFire;

	// Use this for initialization
	void Start () {
		rb.GetComponent<Rigidbody>();
		ses.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButton("Fire1") && Time.time > nextFire ){

			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			ses.Play();

		}

	
	}


	void FixedUpdate(){

		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 Movement = new Vector3(moveHorizontal,0.0f,moveVertical);

		rb.velocity = Movement*speed;

		//rb.position = new Vector3(Mathf.Clamp(rb.position.x,boundary.xMin,boundary.xMax),0.0f,Mathf.Clamp(rb.position.z,boundary.zMin,boundary.zMax));

		rb.rotation = Quaternion.Euler(rb.velocity.x * tilt, 90f, 0.0f);
	

	}


}
