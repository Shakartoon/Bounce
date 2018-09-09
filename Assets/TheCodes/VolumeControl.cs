using System.Collections;
using System.Collections.Generic; 
using UnityEngine; 

public class VolumeControl : MonoBehaviour {

	public float gain; 
	public float volume = 0.1f;  

	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			gain = volume; 
		
		}

		if (Input.GetKeyUp (KeyCode.Space)) {

			gain = 0; 
		}

	}
}
