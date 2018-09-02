using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_button : MonoBehaviour {


    public GameObject menuPrefab;
    //public bool mousePressed = false; 
    public bool menuOpen = false;

    void Start() {

        menuPrefab.SetActive(false);

    }

    // Update is called once per frame
    void Update() {
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log("Licked");
            menuPrefab.SetActive(true);
            menuOpen = true;
        }
    }
    void OnMouseDown()
    {
        if (menuOpen == true && (Input.GetMouseButtonDown(0)))
            {
            menuPrefab.SetActive(false);
        }
    }
}
