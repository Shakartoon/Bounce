using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public bool solved;
    public bool oneKissingtwo;
    public bool threeKissingfour;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((oneKissingtwo == true) && (threeKissingfour == true))
        {
            solved = true;
        }

        if (solved == true)
        {
            Debug.Log("Solved!");
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Circlekeypart2")
        {
            oneKissingtwo = true;
        }

        if (col.collider.tag == "Circlekeypart3")
        {
            threeKissingfour = true;
        }

    }
}

