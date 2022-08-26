using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimiento : MonoBehaviour

{
   // public Vector3 direction = new Vector3(0f,0f,1f);
    public float Speed = 2f;
     public float cameraAxisx = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     RotatePlayer();
        if(Input.GetKey(KeyCode.W)){
               Debug.Log("VAS PARA DELANTE PAPA");
             transform. Translate(Vector3.forward * Speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S)){
              Debug.Log("BROTHER VAS PARA ATRAS"); 
             transform. Translate(Vector3.back * Speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.A)){
            Debug.Log("MI PANA DESCUBRITE LA TECLA PARA IR A LA IZQUIERDA ");
             transform. Translate(Vector3.left * Speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D)){
                  Debug.Log("TE GUSTA PERDER TU TIEMPO, VAS ASI LA DERECHA");
             transform. Translate(Vector3.right * Speed * Time.deltaTime);
        }
            
    }

        public void RotatePlayer()//se hace para movimiento suaves
        {
             cameraAxisx += Input.GetAxis("Mouse X");
             Quaternion newRotation = Quaternion.Euler(0,cameraAxisx * 0.5f, 0);
             transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 2f * Time.deltaTime);
        }
    

}  