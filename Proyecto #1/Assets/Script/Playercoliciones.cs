using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercoliciones : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        Debug.Log("ENTRADO EN COLISION CON -> " + other.gameObject.name);
        if(other.gameObject.CompareTag("PowerUps"))
        {
            Destroy(other.gameObject);
            GetComponent<PlayerData>().live++;
        }
       
    }

    private void OnCollisionExit(Collision other) {
         Debug.Log("SALIENDO DE LA  COLISION  -> " + other.gameObject.name);
    }

    private void OnCollisionStay(Collision other) {
         Debug.Log("EN CONTACTO CON -> " + other.gameObject.name);
    }

    
}
