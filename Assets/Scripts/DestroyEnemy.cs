using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour {

	public GameObject enemyExplosion;
	public GameObject playerExplosion;
	public int enemyScoreValue;
	private GmaeController gameController;

	// Use this for initialization
	void Start () {

		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		if(gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent<GmaeController>();
		}

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){

		if(other.tag == "Gun")
		{
			Instantiate(enemyExplosion,transform.position,transform.rotation);
			Destroy(gameObject);
			Destroy(other.gameObject);
		}


			if(other.tag == "Player")
			{
				Instantiate(playerExplosion,other.transform.position,other.transform.rotation);
			    Instantiate(enemyExplosion,other.transform.position,other.transform.rotation);
				Destroy(gameObject);
				Destroy(other.gameObject);
			}
		if(other.tag == "Gun"){
			gameController.AddScore(enemyScoreValue);
		}


		}

	
	}


