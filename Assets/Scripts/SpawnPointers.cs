using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointers : MonoBehaviour
{
    public static SpawnPointers _instance;

	void Awake ()
    {
        _instance = this;
	}
	
}
