using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public int count;
	public Text CountText;

	// Use this for initialization
	void Start () {
		CountText.text = "Score: " + count.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			Rigidbody2D r = other.GetComponent<Rigidbody2D> ();
			if (r.velocity.y < 0) {
				count = count + 1;
				CountText.text = "Score: " + count.ToString ();
			}
		
		}
	}
}
