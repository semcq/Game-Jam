using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SouthSceneChange : MonoBehaviour
{

    // Use this for initialization
    bool enterSouth;

    void Start()
    {
        enterSouth = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (enterSouth == true && Input.GetKey(KeyCode.E))
        {
            Debug.Log("E");
            SceneManager.LoadScene("Black Hole");
        }
    }

    void OnCollisionEnter(Collision collider)
    {
        Debug.Log("South Wall Collision");
        enterSouth = true;
    }

    void OnCollisionExit(Collision collider)
    {
        Debug.Log("South Wall Exit");
        enterSouth = false;
    }
}

