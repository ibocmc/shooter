using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {


	void OnTriggerExit(Collider cıkıs){

		Destroy(cıkıs.gameObject);

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
