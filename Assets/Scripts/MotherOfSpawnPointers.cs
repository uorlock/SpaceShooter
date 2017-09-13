using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherOfSpawnPointers : MonoBehaviour
{
    public static MotherOfSpawnPointers _instance;
    public GameObject spawnPointer;
    public GameObject prefab;
    public Transform[] SpawnPointersArray;
	
	void Start ()
    {
        InitiateSpawnPontsArray();
        LaunchAsteroid();
        _instance = this;
        DontDestroyOnLoad(gameObject);
    }

    //asteroidis agmshvebi
    public void LaunchAsteroid()
    {
        Debug.Log("launching Asteroid");
        GameObject t = Instantiate(
            prefab,
            SpawnPointersArray[Random.Range(0, SpawnPointersArray.Length)].position,
            Quaternion.identity,
            SpawnPointers._instance.transform
            );
        //SpawnPointersArray[Random.Range(0, SpawnPointersArray.Length)]
    }

    //spawnpointerebis masivis shevseba
    void InitiateSpawnPontsArray()
    {
        SpawnPointersArray = new Transform[spawnPointer.transform.childCount];
        for (int i = 0; i < SpawnPointersArray.Length; i++)
        {
            SpawnPointersArray[i] = spawnPointer.transform.GetChild(i);
        }
    }
}
