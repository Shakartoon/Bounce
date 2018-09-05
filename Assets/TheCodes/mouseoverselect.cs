using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseoverselect : MonoBehaviour {

	private Vector3 mousePosition; 
	public float moveSpeed = 0.5f;
    public bool mouseIsover = false;
    public Rigidbody2D rb2d;
    private bool isFrozen;
	public GameObject greenCircle; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = mousePosition;
            rb2d.simulated = false;
            isFrozen = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && (isFrozen == true))
        {
            rb2d.simulated = true;
            isFrozen = false;
        }

    }

	void OnMouseDown() { 

		Debug.Log ("Did this work?"); 
		mousePosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
		transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
		SpriteRenderer m = greenCircle.GetComponent<SpriteRenderer> ();
        mouseIsover = true;
		m.enabled = true;

        //Enable the two finger thing? 

            // Find the mesh renderer "greenCricle1" and enable. DID IT BITCH 


            // if (OnMouseOver == true) {

            //Allow Double Mouse movement to happen 
            // If not, do not allow 

            // } 
    } 

	void OnMouseUp () { 
		Debug.Log ("Yes it did"); 
		SpriteRenderer m = greenCircle.GetComponent<SpriteRenderer> ();
        mouseIsover = false;
		m.enabled = false; 

		// if two fingers, move 
	
	} 
		
}
