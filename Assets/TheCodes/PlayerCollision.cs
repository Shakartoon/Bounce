﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

//	public GameObject objeckt;  

//	public ParticleSystem.TriggerModule sparkle;
//	public Transform sparkle; 

	void Start () {

//		sparkle.GetComponent<ParticleSystem> ().enableEmission = false;   

	} 


	void OnCollisionEnter2D (Collision2D col) {
		Debug.Log ("Collision Detected.");

//		sparkle.GetComponent<ParticleSystem> ().enableEmission = true; 
//		StartCoroutine (stopSparkles); 

		if (col.collider.tag == "pink_rect") {
		
			Debug.Log ("COLLIDED!"); 

			Services.audioManager.Play ("drumloop1"); 
			 
		} 

		if (col.collider.tag == "lavendar_rect") {

			Services.audioManager.Play ("icecreamsound"); 

		} 
	
		if (col.collider.tag == "cy1") {

			Services.audioManager.Play ("synth1"); 

		} 

		if (col.collider.tag == "cy2") {

			Services.audioManager.Play ("synth2"); 

		} 

		if (col.collider.tag == "cy3") {

			Services.audioManager.Play ("synth3"); 

		} 

		if (col.collider.tag == "cy4") {

			Services.audioManager.Play ("synth4"); 

		} 

		if (col.collider.tag == "cdg1") {

			Services.audioManager.Play ("humming"); 

		} 

		if (col.collider.tag == "cdg2") {

			Services.audioManager.Play ("singing"); 

		} 

		if (col.collider.tag == "cdg3") {

			Services.audioManager.Play ("goodboy"); 

		} 

		if (col.collider.tag == "cdg4") {

			Services.audioManager.Play ("cutesound"); 

		} 

		if (col.collider.tag == "cg1") {

			Services.audioManager.Play ("secrets"); 

		} 
	}

//	IEnumerator stopSparkles()
//	{
//		//yield return new WaitForSeconds (.4f); 
//
//		sparkle.GetComponent<ParticleSystem> ().enableEmission = false; 
//
//	}
}
