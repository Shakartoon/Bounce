﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockwiserotation : MonoBehaviour {


	public float rotateX; 
	public float rotateY; 
	public float rotateZ; 
	public float speed = -3; 


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(rotateX, rotateY, Time.deltaTime * speed, Space.World);
		//if rotates around, stop at original location for several seconds, then rotate again. 
		
	}
}
