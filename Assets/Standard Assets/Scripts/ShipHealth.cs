using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShipHealth : MonoBehaviour {

    // Use this for initialization
    public Image healthBar;
    public float health;

    float amount = 20f;

    void Awake()
    {

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        checkHealth();
    }

    void checkHealth()
    {
        healthBar.rectTransform.localScale = new Vector3(healthBar.rectTransform.localScale.x, health / 100, healthBar.rectTransform.localScale.z);
        if (health <= 0.0f)
        {
            Debug.Log("Death");
            SceneManager.LoadScene("Failure");
        }
    }


    public void updateHealth()
    {
        if (health - amount <= 0.0f)
        {
            health = 0.0f;
        }
        else
        {
            Debug.Log("Health Change");
            health -= amount;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            updateHealth();
            Debug.Log("Ouch!");
        }
    }
}
