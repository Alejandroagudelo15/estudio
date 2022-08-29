using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    
    public float Speed = 10f; // float es para definir numeors con parte  desimal 

     public int hp = 3; // int es para definir numero enteros

     public int attack = 20;

     public int healing = 30;
     

     public string name = "MR.Tildou";// string nos permite definir un nombre 

     
    void Start()
    {
        
        Debug.Log(hp);//VAMOS A TULIZAR EL Debug.Log para mostra un mensaje en la consola o una accion en la consola 
        Debug.Log("EJECUTANDO EL START MADAFAKERS");
        Damage(attack);
        Recuperar(healing);
        transform.position = Vector3.forward * 2f; // Aqui lo podemos iniciar arriba
       
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log("EJECUTANDO EL UPDATE");
        Move();
       

    
    }
    void Damage(int newAttack) //esto es un metodo
    {
           hp = hp - newAttack;
          // GameManager.hp--;
          // Debug.Log(GameManager.hp);
           


    }
    void Move()
    {

          transform.position = transform.position + Vector3.up * Speed * Time.deltaTime;

     }

     void Recuperar(int vida)
     {
        hp = hp + vida;
        //GameManager.hp++;
       // Debug.Log(GameManager.hp);
     }
}
