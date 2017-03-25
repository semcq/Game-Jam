using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    // Use this for initialization
    bool enterBed;

    void Start()
    {
        enterBed = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (enterBed == true && Input.GetKey(KeyCode.E))
        {
            Debug.Log("Exit Game");
            SceneManager.LoadScene("End Game");
        }
    }

    void OnCollisionEnter(Collision collider)
    {
        if (gameObject.tag == "Bed")
        {
            Debug.Log("Bed Collision");
            enterBed = true;
        }
    }

    void OnCollisionExit(Collision collider)
    {
        Debug.Log("Bed Exit");
        enterBed = false;
    }
}

