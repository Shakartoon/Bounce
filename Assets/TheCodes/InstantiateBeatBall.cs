using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBeatBall : MonoBehaviour {

	public GameObject beatBall; 

	void Start () {
		
	}

	//Instantiate the BeatBall on button press 
	void OnMouseDown(){

		Debug.Log ("ButtonPressed!"); 
		// Dragging occurs 

		Instantiate (beatBall); 

		// thing occurs
	}

	void OnMouseDrag () { 


	
	} 
}
