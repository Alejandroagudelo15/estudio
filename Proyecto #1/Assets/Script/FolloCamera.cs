using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolloCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lateUpdate();
    }


     private void lateUpdate()
    {
        transform.position = target.transform.position;
    }
}
