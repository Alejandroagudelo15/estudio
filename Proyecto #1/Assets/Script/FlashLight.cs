using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    // Start is called before the first frame update
    private Light myLight;
    void Start()
    {
        myLight = GetComponent<Light>();
        InvokeRepeating("Battery", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Battery()
    {
       myLight.intensity--; 
       if (myLight.intensity == 0) CancelInvoke("Battery");
    }
}
