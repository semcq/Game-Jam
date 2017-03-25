using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TurretHealth : MonoBehaviour {

    // Use this for initialization
    private float health;

    void Awake()
    {

    }

    void Start() {
        health = 3;
    }

    // Update is called once per frame
    void Update() {
        checkHealth();
    }

    void checkHealth()
    {
        if (health == 0)
        {
            health = 3;
            SceneManager.LoadScene("Failure");

        }
    }


    public void updateHealth()
    {
        health -= 1;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Robot")
        {
            updateHealth();
            Debug.Log("Robot!");
        }
    }

}
