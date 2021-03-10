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

    private int Ran;
    public float Time;
    void Start()
    {
        StartCoroutine(CheckHealth());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator CheckHealth()
    {
        while (true)
        {
            yield return new WaitForSeconds(Time);
            var healthObjects = GameObject.FindGameObjectsWithTag("Health");
            if (healthObjects.Length < 2)
            {
                CheckAndSpawn();
            }
        }

    }
    void CheckAndSpawn()
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
    }
}
