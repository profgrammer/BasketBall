using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour {

	Rigidbody2D rb;
	Renderer ren;
	CircleCollider2D c;
	Vector2 initPos;
	Vector2 finalPos;
	Vector2 diff;

	public float force;

	public int sortingOrder = 0;
	void Start(){
		rb = GetComponent<Rigidbody2D> ();
		ren = GetComponent<Renderer> ();
		c = GetComponent<CircleCollider2D> ();
	}

	void FixedUpdate(){

		// for the visuals
		if (rb.velocity.y > 0) {
			ren.sortingOrder = 6;
			c.isTrigger = true;
		} else {
			ren.sortingOrder = 0;
			c.isTrigger = false;
		}

		// toggling the collision detector on and off


	}

	void OnMouseDown(){
		rb.gravityScale = 0;
		initPos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
	}

	void OnMouseUp(){
			if (rb.velocity.y == 0) {
				rb.gravityScale = 5;
				finalPos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
				diff = finalPos - initPos;
				diff.Normalize ();
				rb.AddForce (new Vector2 (diff.x, 1f) * force, ForceMode2D.Impulse);
				c.isTrigger = false;
			}
		}

}
