using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WestSceneChange : MonoBehaviour
{

    // Use this for initialization
    bool enterWest;
    public AudioClip imagination;

    void Start()
    {
        enterWest = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (enterWest == true && Input.GetKey(KeyCode.E))
        {
            Debug.Log("E");
            AudioSource.PlayClipAtPoint(imagination, transform.position);
            SceneManager.LoadScene("Pirate Start");
        }
    }

    void OnCollisionEnter(Collision collider)
    {
        if (gameObject.tag == "West")
        {
            Debug.Log("West Wall Collision");
            enterWest = true;
        }
    }

    void OnCollisionExit(Collision collider)
    {
        Debug.Log("West Wall Exit");
        enterWest = false;
    }
}

