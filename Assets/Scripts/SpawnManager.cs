using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject powerUpPrefab;

    //private float spawnRange = 1f; 

    void Start()
    {
        SpawnPowerUp(); 
    }

    void Update()
    {
     //eventually make SpawnPowerUp() happen when count =1    
    }
    //!!!! this isnt working
    void SpawnPowerUp()
    {
       //make this depend on score? 
        for(int i=0; i<2; i++)
        {
            Instantiate(powerUpPrefab, GenerateSpawnPosition(), Quaternion.Euler(powerUpPrefab.transform.position));
        }
    }

    Vector3 GenerateSpawnPosition()
    {
        float xPos = Random.Range(-14f, -6f);
        float zPos = Random.Range(-2f, 6f);
        Vector3 spawnPos = new Vector3(xPos, 1, zPos);
        return spawnPos;
    }
}
