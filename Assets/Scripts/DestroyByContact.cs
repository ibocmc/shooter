using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

	public GameObject Explosion;
	public GameObject playerExplosion;
	//public GameObject enemyExplosion;
	public int scoreValue;
	private GmaeController gameController;


	// Use this for initialization
	void Start () {

		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		if(gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent<GmaeController>();
		}
	
	}

	void OnTriggerEnter(Collider other){

		if (other.tag == "Boundary"){

			return;

			}


		if(other.tag == "Player")
		{
		    Instantiate(playerExplosion,other.transform.position,other.transform.rotation);
			Destroy(gameObject);
			Destroy(other.gameObject);
			}
	    
		if (Explosion != null)
		{
			Instantiate(Explosion, transform.position, transform.rotation);
		}
		if(other.tag == "Gun")

		{
			Destroy(gameObject);
			Destroy(other.gameObject);
		}


		//Destroy(GameObject.FindWithTag("Astroid"));
		//Destroy(GameObject.FindWithTag("Gun"));
		//Instantiate(enemyExplosion,other.transform.position,other.transform.rotation);

		if(other.tag == "Gun"){
		gameController.AddScore(scoreValue);
		}

		//Destroy (GameObject.FindWithTag("Astroid"));

		//Destroy (GameObject.FindWithTag("Player"));
	}
				

	}

	
	