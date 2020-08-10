using UnityEngine;
using System.Collections;

public class RondomRotater : MonoBehaviour {

	public Rigidbody rb;
	public float rotatefaktor;

	// Use this for initialization
	void Start () {

		rb.GetComponent<Rigidbody>();

		rb.angularVelocity = Random.insideUnitSphere * rotatefaktor;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
