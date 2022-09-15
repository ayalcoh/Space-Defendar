using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
     public int numOfEnemiesToSpawn = 10;
    public GameObject[] enemiesArray;

    public float minRandomSpawn = -300;
    public float maxRandomSpawn = 300;

    private void Start() 
    {
        enemiesSpawn();       
    }

    void enemiesSpawn() // lets get some asteroids
    {
        for (int i = 0; i < numOfEnemiesToSpawn ; i++)
        {
            float randomX = Random.Range(minRandomSpawn, maxRandomSpawn);
            float randomY = Random.Range(minRandomSpawn, maxRandomSpawn);
            float randomZ = Random.Range(minRandomSpawn, maxRandomSpawn);
            Vector3 ranSpawnPos = 
                new Vector3(transform.position.x + randomX, transform.position.y + randomY, transform.position.z + randomZ);    
            GameObject temp = Instantiate(enemiesArray[0], ranSpawnPos, Quaternion.identity);  //prefab default rotation at random spawn point  
            temp.transform.parent = this.transform;// set the parent to the spawn obj
        }   
    }

    private void OnDrawGizmos() 
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(maxRandomSpawn * 2, maxRandomSpawn *2, maxRandomSpawn *2));
    }
}
