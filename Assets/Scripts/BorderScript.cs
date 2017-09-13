using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderScript : MonoBehaviour
{

    void OnTriggerExit(Collider other)
    {

        Debug.Log("if mde");

        if (other.gameObject.tag == "AsteroidTag")
        {
            Debug.Log("if");

            MotherOfSpawnPointers._instance.LaunchAsteroid();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "ShotTag")
        {
            Destroy(other.gameObject);
        }

        //Debug.Log("if shemdeg");
    }
}
