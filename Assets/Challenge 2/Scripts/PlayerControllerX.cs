using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float dogSpawnRate = 1f;
    float NextDogSpawn = 0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Time.time > NextDogSpawn)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                NextDogSpawn = Time.time + dogSpawnRate;
                Debug.Log(NextDogSpawn);
            }
        }

    }
}
