using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausebutton : MonoBehaviour {

    GameObject[] balls;

    // Use this for initialization
    void Start()
    {
        if (balls == null)
        {
            balls = GameObject.FindGameObjectsWithTag("beatball");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            foreach (GameObject beat1 in balls)
            {
                beat1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            }
        }
    }
}
