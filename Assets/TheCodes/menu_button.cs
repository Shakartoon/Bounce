using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_button : MonoBehaviour {


	public GameObject menuPrefab; 
	//public bool mousePressed = false; 

	void Start () {

		menuPrefab.SetActive (false); 

	}
	
	void Update () {

		if (Input.GetMouseButtonDown (0)) {

			Debug.Log ("Licked"); 	
			menuPrefab.SetActive (true); 
		} 

	}
}
