using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptclass : MonoBehaviour
{
    
  //public GameObject Enenemyprefab;
    
    public GameObject[] Enenemyprefab;
    public float delaySpawn = 2f;
    public float intervalSpawn = 2f;
    public float speed = 2f;
    //public float scaleChange = 2f;
   // public Vector3 scaleChange = new Vector3(10f, 10f, 10f);
   //public Vector3 direction = new Vector3(0f, 0f, 1f);
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
    
    
    
    

