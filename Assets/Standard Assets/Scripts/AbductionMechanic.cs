using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AbductionMechanic : MonoBehaviour {
    bool hover;

	// Use this for initialization
	void Start () {
        hover = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (hover == true && Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Abduct");
            transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);

        }

        if (transform.position.y < 9f && transform.position.y > 1f && !Input.GetKey(KeyCode.Space))
        {

           Debug.Log("Gravity!");
           transform.Translate(Vector3.down * Time.deltaTime * 3, Space.World);

        }

        if (transform.position.y > 7.5f)
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Target Aquired");
        hover = true;
        
    }

    void OnTriggerExit(Collider collider)
    {
        Debug.Log("Target Lost");
        hover = false;
    }

}
