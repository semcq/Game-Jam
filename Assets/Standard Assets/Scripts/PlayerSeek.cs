using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSeek : MonoBehaviour {

    // Use this for initialization
    bool destroy;
    public float health;

    float amount = 20f;

    public AudioClip explosion;

    Transform Player;
	void Start () {
        Player = GameObject.FindWithTag("Player").transform;
        destroy = false;
    }
	
	// Update is called once per frame
	void Update () {
        var MoveSpeed = 3;
        var MaxDist = 10;
        var MinDist = 5;

        if (destroy)
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(explosion, transform.position);
        }

        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }
	}

    void updateHealth()
    {
        if (health - amount <= 0.0f)
        {
            health = 0.0f;
            destroy = true;
        }
        else
        {
            Debug.Log("Health Change");
            health -= amount;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Destroy");
            destroy = true;
            AudioSource.PlayClipAtPoint(explosion, transform.position);
        }

        if (other.gameObject.tag == "Bullet")
        {
            updateHealth();
            Debug.Log("Hit");
            Destroy(other.gameObject);
        }
    }
}
