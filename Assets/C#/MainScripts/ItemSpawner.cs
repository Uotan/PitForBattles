using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] startSpawnPoint;
    public GameObject[] items;

    public float startSpawnTime;
    public float spawnTime;

    int Spawn_pos;
    int id_item;
    void Start()
    {
        spawnTime = startSpawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        var healthObjects = GameObject.FindGameObjectsWithTag("Health");
        var ammoObjects = GameObject.FindGameObjectsWithTag("Ammo");
        if (spawnTime <= 0)
        {

            if (healthObjects.Length == 0 && ammoObjects.Length == 0)
            {
                spawn();
            }

            spawnTime = startSpawnTime;
        }
        if (healthObjects.Length == 0&&ammoObjects.Length==0)
        {
            spawnTime -= Time.deltaTime;
        }
    }
    void spawn()
    {
        Spawn_pos = Random.Range(0, startSpawnPoint.Length);
        id_item = Random.Range(0, items.Length);
        switch (id_item)
        {
            case 0: Instantiate(items[0], new Vector2(startSpawnPoint[Spawn_pos].transform.position.x, startSpawnPoint[Spawn_pos].transform.position.y), Quaternion.identity); break;
            case 1: Instantiate(items[1], new Vector2(startSpawnPoint[Spawn_pos].transform.position.x, startSpawnPoint[Spawn_pos].transform.position.y), Quaternion.identity); break;
            default: break;
        }
        
    }
}
