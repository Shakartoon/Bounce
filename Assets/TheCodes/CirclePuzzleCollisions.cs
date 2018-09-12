using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CirclePuzzleCollisions : MonoBehaviour {

    public bool solved;
    public bool oneKissingtwo;
    public bool threeKissingfour;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

        if (solved == true)
        {
            Debug.Log("Solved!");
        }
	}

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.collider.tag == "Circlekeypart2")
        {
            oneKissingtwo = true;
        }
        
    }
}
