using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EastSceneChange : MonoBehaviour
{

    // Use this for initialization
    bool enterEast;

    void Start()
    {
        enterEast = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (enterEast == true && Input.GetKey(KeyCode.E))
        {
            Debug.Log("E");
            SceneManager.LoadScene("Alien Start");
        }
    }

    void OnCollisionEnter(Collision collider)
    {
        if (gameObject.tag == "East")
        {
            Debug.Log("East Wall Collision");
            enterEast = true;
        }
    }

    void OnCollisionExit(Collision collider)
    {
        Debug.Log("East Wall Exit");
        enterEast = false;
    }
}
