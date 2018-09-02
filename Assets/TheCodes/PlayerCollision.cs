using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

//	public GameObject objeckt;  

//	public ParticleSystem.TriggerModule sparkle;
//	public Transform sparkle; 

	public GameObject sparkles; 

	void Start () {

//		sparkle.GetComponent<ParticleSystem> ().enableEmission = false;   

	} 


	void OnCollisionEnter2D (Collision2D col) {
		Debug.Log ("Collision Detected.");
					
//		SpriteRenderer c = sparkles.GetComponent<SpriteRenderer> ();
//		c.enabled = true;  
		 

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
