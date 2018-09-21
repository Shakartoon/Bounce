﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {


	public GameObject sparkles; 
	public bool colorChangeCollision; 

	public Material firstMaterial; 

	public GameObject cy3; 
	private Material m; 

	public GameObject hh; 
	public Vector3 defPos;
	Rigidbody2D rb;

	void Start () {
		defPos = transform.position;
		rb = GetComponent<Rigidbody2D> ();
	}
	void Update(){
		if (Camera.main.WorldToViewportPoint (transform.position).y < -.2f) {
			rb.velocity = Vector3.zero;
			transform.position = defPos;
		}
	}
	void OnCollisionEnter2D (Collision2D col) {
		Debug.Log ("Collision Detected.");
	

		foreach (ContactPoint2D contact in col.contacts)
		{
			Debug.DrawRay(contact.point, contact.normal, Color.black);
		}


		if (col.relativeVelocity.magnitude > 2) { 	

			Debug.Log ("HI!"); 

		} 


		if (col.collider.tag == "hh") {

			Services.audioManager.Play ("hh"); 
			GameObject.FindGameObjectsWithTag ("hh"); 
			hh.GetComponent<Renderer>().material.color = Color.yellow;  
		} 

		else if (col.collider.tag == "hh"){
			
			GameObject.FindGameObjectsWithTag ("hh"); 
			hh.GetComponent<Renderer>().material.color = Color.black;  
		}

		if (col.collider.tag == "a") {


			Services.audioManager.Play ("A"); 
		} 


		if (col.collider.tag == "pink_rect") {
		
			Debug.Log ("COLLIDED!"); 
			Services.audioManager.Play ("drumloop1"); 
			 
		} 


		if (col.collider.tag == "hh") {

			Services.audioManager.Play ("hh"); 

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
		    
//			cy3 = GameObject.FindGameObjectsWithTag ("cy3"); 
//			cy3.GetComponent<Renderer> ().material; //.SetColor("_Color", Color.red);
//			GameObject.FindGameObjectsWithTag ("cy3").Material.color = Color.yellow;


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
        if (col.collider.tag == "Metronome")
        {

            Services.audioManager.Play("Metronome");

        }
        if (col.collider.tag == "Rhodes")
        {

            Services.audioManager.Play("Rhodes");

        }
        if (col.collider.tag == "Snare")
        {

            Services.audioManager.Play("High Hat");


        }

        if (col.collider.tag == "Highhat")
        {

            Services.audioManager.Play("Snare Drum");
			colorChangeCollision = true; 

        }
        if (col.collider.tag == "Thoughts")
        {

            Services.audioManager.Play("Thoughts");

        }
        if (col.collider.tag == "Crickets")
        {

            Services.audioManager.Play("Crickets");

        }
        if (col.collider.tag == "Hustling")
        {

            Services.audioManager.Play("Hustling");

        }
        if (col.collider.tag == "Armenian")
        {

            Services.audioManager.Play("Armenian");

        }
        if (col.collider.tag == "Cinematic")
        {

            Services.audioManager.Play("Cinematic");

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
