using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public Rigidbody rb;

    public float tumble;
    public float speed;

    public GameObject explosion;
    public GameObject playerExplosion;

    void Start()
    {
        rb.velocity = transform.forward * (-speed);
        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BorderTag")
        {
            return;
        }

        //playeris afetqebis efeqti
        if (other.tag == "PlayerTag")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);

        }

        //asteroidis afetqebis efeqti
        Instantiate(explosion, transform.position, transform.rotation);

        //obieqtebis ganadgureba
        Destroy(gameObject);
        Destroy(other.gameObject);

        if (other.tag != "PlayerTag")
        {
            MotherOfSpawnPointers._instance.LaunchAsteroid();
            Debug.Log("Asteroids moxvda");
        }

    }

}
