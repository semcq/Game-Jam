using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipSeek : MonoBehaviour
{

    // Use this for initialization
    bool destroy;

    Transform Player;
    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
        destroy = false;
    }

    // Update is called once per frame
    void Update()
    {
        var MoveSpeed = 20;

        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
    }



   

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Pirates!");
        SceneManager.LoadScene("Pirate Finish");
    }
}