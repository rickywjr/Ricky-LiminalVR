using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingStar : MonoBehaviour
{

    public GameObject star;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    public float zMin;
    public float zMax;

    void Start()
    {
        InvokeRepeating("SpawnStar", spawnTime, spawnDelay);  
    }

    public void SpawnStar()
    {
        float x = Random.Range(xMin,xMax);
        float z = Random.Range(zMin,zMax);
        float y = Random.Range(yMin,yMax);

        Vector3 randomPosition = new Vector3(x, 20, z);

        Instantiate(star, new Vector3(x,20,z) , transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnStar");
        }
    }

    


}
