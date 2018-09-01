using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseoverselect : MonoBehaviour {

	private Vector3 mousePosition; 
	public float moveSpeed = 0.5f; 

	public GameObject greenCircle; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseOver () { 

		Debug.Log ("Did this work?"); 
		mousePosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
		transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
		SpriteRenderer m = greenCircle.GetComponent<SpriteRenderer> (); 
		m.enabled = true; 
	

		//Enable the two finger thing? 

		// Find the mesh renderer "greenCricle1" and enable. DID IT BITCH 


		// if (OnMouseOver == true) {
		
		//Allow Double Mouse movement to happen 
		// If not, do not allow 

		// } 
	} 

	void OnMouseExit () { 
		Debug.Log ("Yes it did"); 
		SpriteRenderer m = greenCircle.GetComponent<SpriteRenderer> (); 
		m.enabled = false; 

		// if two fingers, move 
	
	} 
		
}
