using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameCleaner : MonoBehaviour {


	public GameObject ball;
	public Transform whereToSpawnLow;
	public Transform whereToSpawnHigh;

	private Vector2 pos;


	//float respawnTime;
	//float respawnDelay = .5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Player") {
			Destroy (other.gameObject);
		//	respawnTime = Time.time + respawnDelay;
		}
		//if(Time.time >= respawnTime)
		//pos.x = Random.Range(-5.5f, 5.5f);
		//pos.y = -4.36f;
		pos = new Vector2(Random.Range(whereToSpawnLow.position.x, whereToSpawnHigh.position.x), whereToSpawnLow.position.y);
        Instantiate (ball, pos, Quaternion.identity);
	

	}
}
