using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyone : MonoBehaviour
{
    [SerializeField]
    [Range(1f,10f)]float speed = 2f;

   /* [SerializeField]
    [Range(0,2)]int typeEnemy = 0;*/

    enum ZombieType { SoyReFacil, SoyMedioFacil, CorazonDeElla};
    [SerializeField] ZombieType zombieType;

    [SerializeField] Transform PlayerTransform;
    // Start is called before the first frame update
    void Start()
    {
      

       
    }
    private void MoveForward()
    {
         
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void ChasePlayer()
    {
         LookPlayer();
            Vector3 direction = (PlayerTransform.position - transform.position);
            if(direction.magnitude > 2f){

             transform.position += direction.normalized * speed * Time.deltaTime;
            }
            
    }

    private void RotateAroundPlater()
    {
         LookPlayer();
            transform.RotateAround(PlayerTransform.position, Vector3.up, 20f * Time.deltaTime);
    }

    private void LookPlayer()
    {
         
        transform.LookAt(PlayerTransform);
    }


    // Update is called once per frame
          void Update()
    {
       
        
    switch(zombieType)
        {
            case ZombieType.SoyReFacil:
            Debug.Log(name + "->MOVER FORDWARD");
            MoveForward();
             break;
            case ZombieType.SoyMedioFacil:
            Debug.Log(name + "->SEGUIR AL PERRO ESE");
            ChasePlayer();
             break;
            case ZombieType.CorazonDeElla:
            Debug.Log(name + "->SOLO DALE VUELTICAS NO LO JODAS");
            RotateAroundPlater();
            break;
    }
}
}
