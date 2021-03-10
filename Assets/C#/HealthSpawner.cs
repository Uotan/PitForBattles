using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawner : MonoBehaviour
{
    public GameObject health1;
    public GameObject health2;
    public GameObject health3;
    public GameObject health4;
    public GameObject health5;
    public GameObject PrefabHealth;

    int Ran;
    public float timeSpawn = 3f;
    public float timeLost;
    void Start()
    {
        timeLost = timeSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        timeLost -= Time.deltaTime;
        if (timeLost<=0)
        {
            Ran = Random.Range(1, 6);
            switch (Ran)
            {
                case 1: Instantiate(PrefabHealth, health1.transform.position, Quaternion.identity); break;
                case 2: Instantiate(PrefabHealth, health2.transform.position, Quaternion.identity); break;
                case 3: Instantiate(PrefabHealth, health3.transform.position, Quaternion.identity); break;
                case 4: Instantiate(PrefabHealth, health4.transform.position, Quaternion.identity); break;
                case 5: Instantiate(PrefabHealth, health5.transform.position, Quaternion.identity); break;
                default:
                    break;
            }
            timeLost = timeSpawn;
        }
    }
}
