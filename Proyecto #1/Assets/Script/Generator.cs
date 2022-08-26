using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    //public GameObject Enenemyprefab;
    
    public GameObject[] Enenemyprefab;
    public float delaySpawn = 2f;
    public float intervalSpawn = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
       InvokeRepeating("SpawnEnemy", delaySpawn, intervalSpawn);
    }

    private void SpawnEnemy()
    {
        int indexEnemy = Random.Range(0, Enenemyprefab.Length);
        Instantiate(Enenemyprefab[indexEnemy], transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}