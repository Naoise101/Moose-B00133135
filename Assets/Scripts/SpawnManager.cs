using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] threatPrefabs;
    private float spawnRange1 = 20;
    private float spawnPositionX = 20;
    private float startDelay = 2;
    private float spawnTime = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomThreat", startDelay, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void SpawnRandomThreat(){
    
        int threatIndex = Random.Range(0, 5);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange1, spawnRange1), 0, spawnPositionX);
         //spawn random threats
        Instantiate(threatPrefabs[threatIndex], spawnPosition, threatPrefabs[threatIndex].transform.rotation);
    }
    

}
