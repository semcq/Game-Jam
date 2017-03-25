using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NorthSceneChange : MonoBehaviour
{

    // Use this for initialization
    bool enterNorth;

    void Start()
    {
        enterNorth = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (enterNorth == true && Input.GetKey(KeyCode.E))
        {
            Debug.Log("E");
            SceneManager.LoadScene("Ranger Start");
        }
    }

    void OnCollisionEnter(Collision collider)
    {

        if (gameObject.tag == "North")
        {
            Debug.Log("North Wall Collision");
            enterNorth = true;
        }
    }

    void OnCollisionExit(Collision collider)
    {
        Debug.Log("North Wall Exit");
        enterNorth = false;
    }
}
