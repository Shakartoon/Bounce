using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flick : MonoBehaviour {

    public SpringJoint2D spring;
    public mouseoverselect mouseOver;
    public float springOffsetx = 10;
    public float springOffsety = 10;


	// Use this for initialization
	void Start () {
        spring = this.gameObject.GetComponent<SpringJoint2D>();
        spring.connectedAnchor = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        if (mouseOver.mouseIsover == true){
            spring.enabled = true; 
        }
        else if (mouseOver.mouseIsover == false)
        {
            spring.enabled = false;
        }
        if (spring.enabled == true)
        {
            Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            spring.connectedAnchor = cursorPosition; //+ new Vector2 (springOffsetx, springOffsety);
        }
    }
}
