using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstreoidSpawnPos : MonoBehaviour
{
    public int numOfAstToSpawn = 10;
    public GameObject[] asteroidArray;

    public float minRandomSpawn = -300;
    public float maxRandomSpawn = 300;

    private void Start() 
    {
        asteroidSpawn();       
    }

    void asteroidSpawn() // lets get some asteroids
    {
        for (int i = 0; i < numOfAstToSpawn ; i++)
        {
            float randomX = Random.Range(minRandomSpawn, maxRandomSpawn);
            float randomY = Random.Range(minRandomSpawn, maxRandomSpawn);
            float randomZ = Random.Range(minRandomSpawn, maxRandomSpawn);
            Vector3 ranSpawnPos = 
                new Vector3(transform.position.x + randomX, transform.position.y + randomY, transform.position.z + randomZ);    
            GameObject temp = Instantiate(asteroidArray[0], ranSpawnPos, Quaternion.identity);  //prefab default rotation at random spawn point  
            temp.transform.parent = this.transform;// set the parent to the spawn obj
        }   
    }

    private void OnDrawGizmos() 
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(maxRandomSpawn * 2, maxRandomSpawn *2, maxRandomSpawn *2));
    }
}
