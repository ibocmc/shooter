using UnityEngine;
using System.Collections;

public class GmaeController : MonoBehaviour {

	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	//public GameObject Enemy;
	//public Vector3 eSpawnValues;
	//public int enemyCount;


	public GUIText scoreText;
	private int score;





	// Use this for initialization
	void Start () {

		score = 0;
		UpdateScore();
		StartCoroutine (SpawnWaves());
	
	}
	

	IEnumerator SpawnWaves(){

		yield return new WaitForSeconds(startWait);

		while(true)
		{

		for (int i=0; i<hazardCount; i++){

			    Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x,spawnValues.x), spawnValues.y, spawnValues.z);
				//Vector3 espawnPosition = new Vector3(eSpawnValues.x,eSpawnValues.y,eSpawnValues.z);
			   
				Quaternion spawnRotation = Quaternion.identity;
				//Quaternion espawnRotation = Quaternion.identity;
			    
				Instantiate(hazard,spawnPosition,spawnRotation);
				//Instantiate(Enemy,espawnPosition,espawnRotation);
				yield return new WaitForSeconds(spawnWait);

		}
		yield return  new WaitForSeconds(waveWait);
	}
	
	}

	public void AddScore(int newScoreValue){


		score += newScoreValue;
		UpdateScore();

	}

	// Update is called once per frame
	void UpdateScore () {

		scoreText.text = "Score:" + score;


	
	}
}
