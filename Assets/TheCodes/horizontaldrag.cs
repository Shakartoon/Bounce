using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontaldrag : MonoBehaviour {

	public bool isRotating;
	public Vector3 screenPoint; 
	public Vector3 offset;
	public float degreesPerSec = 360f;


	void Start () {
	}


	void Update () {

	}

	void OnMouseOver(){
		if (Input.GetMouseButtonDown(1)){
			float rotAmount = degreesPerSec * Time.deltaTime;
			float curRot = transform.localRotation.eulerAngles.z;
			transform.localRotation = Quaternion.Euler(new Vector3(0, 0, curRot + rotAmount));
		}
	}

	void OnMouseDown()
	{
		screenPoint = Camera.main.WorldToScreenPoint(transform.position);
		offset =  transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 0));
	}

	void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, 0, 0);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;

		if (transform.position.x >= -0.599f) {
			Debug.Log ("PAST"); 
		} 


		//if (isRotating == true)
		//{

		//}
	}

}
