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

		if (col.collider.tag == "lavendar_rect") {

			Services.audioManager.Play("icecreamsound"); 

		} 
	
		if (col.collider.tag == "cy1") {

			Services.audioManager.Play("synth1"); 

		} 

		if (col.collider.tag == "cy2") {

			Services.audioManager.Play("synth2"); 

		} 

		if (col.collider.tag == "cy3") {

			Services.audioManager.Play("synth3"); 

		} 

		if (col.collider.tag == "cy4") {

			Services.audioManager.Play("synth4"); 

		} 

	}  

}
