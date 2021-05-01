using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
public class HealthSpawner : MonoBehaviour
{
    public GameObject[] startSpawnPoint;
    public List<GameObject> spawnPoint;


    public GameObject PrefabHealth;

    public float startSpawnTime;
    public float spawnTime;

    private int[] Ran;
    void Start()
    {
        spawnTime = startSpawnTime;
        for (int i = 0; i < startSpawnPoint.Length; i++)
        {
            spawnPoint.Add(startSpawnPoint[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        var healthObjects = GameObject.FindGameObjectsWithTag("Health");
        if (spawnTime <= 0)
        {
           
            if (healthObjects.Length == 0)
            {
                CheckHealth();
            }
            
            spawnTime = startSpawnTime;
        }
        //else if (healthObjects.Length > 2)
        //{
        //    for (int i = 0; i < healthObjects.Length; i++)
        //    {
        //        Destroy(healthObjects[i]);
        //    }

        //}
        if (healthObjects.Length == 0)
        {
            spawnTime -= Time.deltaTime;
        }
        if (spawnPoint.Count <= 1)
        {
            spawnPoint.Clear();
            for (int j = 0; j < startSpawnPoint.Length; j++)
            {
                spawnPoint.Add(startSpawnPoint[j]);
            }
        }
    }
    public void CheckHealth()
    {
        var healthObjects = GameObject.FindGameObjectsWithTag("Health");
        while (healthObjects.Length < 2)
        {
            int lastEnumerable = spawnPoint.Count;
            System.Random random = new System.Random();
            Ran = Enumerable.Range(0, lastEnumerable).OrderBy(i => random.Next()).ToArray();
            for (int i = 0; i < spawnPoint.Count; i++)
            {

                if (Ran[i] == i)
                {
                    Instantiate(PrefabHealth, spawnPoint[i].transform.position, Quaternion.identity);
                    spawnPoint.RemoveAt(i);

                }
                healthObjects = GameObject.FindGameObjectsWithTag("Health");
            }
        }


    }
}