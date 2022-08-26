using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recocha : MonoBehaviour
{
    public GameObject[] Cameras;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKeyDown(KeyCode.E))
         {
             Cameras[0].SetActive(true);
              Cameras[1].SetActive(false);
               Cameras[2].SetActive(false);
        
         }

         if (Input.GetKeyDown(KeyCode.R))
         {
             Cameras[0].SetActive(false);
              Cameras[1].SetActive(true);
               Cameras[2].SetActive(false);
        
         }
         if (Input.GetKeyDown(KeyCode.T))
         {
             Cameras[0].SetActive(false);
              Cameras[1].SetActive(false);
               Cameras[2].SetActive(true);
        
         }
    }
}
