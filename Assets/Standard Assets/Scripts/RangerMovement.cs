using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangerMovement : MonoBehaviour
{

    // Use this for initialization

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    double fireRate;
    double lastShot;

    public AudioClip fire;

    void Start()
    {
        fireRate = 0.3;
        lastShot = 0.0;
    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 100.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 15.0f;

        transform.Rotate(0, x, 0);
        //transform.Translate(0, 0, z);

        if (Input.GetMouseButton(0))
        {
            
            Fire();
        }
    }

    void Fire()
    {

        if (Time.time > fireRate + lastShot)
        {
            var bullet = (GameObject)Instantiate(
                bulletPrefab,
                bulletSpawn.position,
                bulletSpawn.rotation);

            lastShot = Time.time;
            AudioSource.PlayClipAtPoint(fire, transform.position, 0.1f);

            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;
            Destroy(bullet, 2.0f);

        }
    }
}
