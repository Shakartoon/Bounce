using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMakingObject : MonoBehaviour {

	public AudioClip mySound; 

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision)
	 {
		Debug.Log ("Seeing this.");

		foreach (ContactPoint2D contact in collision.contacts)
		if (collision.gameObject.CompareTag("Ball")) {
				Services.audioManager.Play (mySound); 
			
		}
	}
}
