using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float nextSpawnTime;
    public float spawnInterval;
    public float speed;
    public Vector3 direction;
    // Start is called before the first frame update

    private void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            Spawn();
            nextSpawnTime += spawnInterval;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
    void Spawn()
    {
    
        Vector3 randomSpawn = new Vector3(Random.Range(-10, 11), 2, Random.Range(-10, 11));
        Instantiate(prefab, randomSpawn, Quaternion.identity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        direction = -direction;
    }
}

