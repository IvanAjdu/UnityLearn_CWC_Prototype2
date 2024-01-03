using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalToSpawn;
    public int zSpawnLoc = 30;
    private float spawnStart = 2f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnStart, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    //method to spawn a rondom animal in a random x position.
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalToSpawn.Length);
        int xSpawnRange = Random.Range(-20, 20);
        Vector3 xSpawnIndex = new Vector3(xSpawnRange, 0, zSpawnLoc);
        Instantiate(animalToSpawn[animalIndex], xSpawnIndex, animalToSpawn[animalIndex].transform.rotation);
    }
}
