using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballDrag : MonoBehaviour {


	Rigidbody2D rb;
	//float distance = 10;
	bool shot = false;
	public float shootForce;

	void Start(){
		rb = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate(){
		if (Input.GetKeyDown (KeyCode.Space) && !shot) {
			shot = true;
			rb.gravityScale = 3f;
			rb.AddForce (new Vector2 (0, 1) * shootForce, ForceMode2D.Impulse);
		}
	}




	/*void OnMouseDrag(){
		Vector3 mousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPos = Camera.main.ScreenToWorldPoint (mousePos);
		transform.position = objPos;
		//rb.AddForce (objPos, ForceMode2D.Impulse);
	}
	*/
}
