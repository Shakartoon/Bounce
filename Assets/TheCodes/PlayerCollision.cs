using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

//	public GameObject objeckt;  

	void OnCollisionEnter2D (Collision2D col) {
		Debug.Log ("Collision Detected.");
		if (col.collider.tag == "pink_rect") {
		
			Debug.Log ("COLLIDED!"); 

			Services.audioManager.Play("drumloop1"); 
			 
		} 
	
	}  

}
