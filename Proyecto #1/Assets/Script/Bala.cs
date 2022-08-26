using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public Vector3 direction = new Vector3(0f,0f,1f);
    public float Speed = 2f;
     public int hp = 3; // int es para definir numero enteros
     public int attack = 20;
     public float speed = 2f;
    public float Livetime = 3f;
    public float scaleChange = 2f;
     public Vector3 direchone = new Vector3(10f, 10f, 10f);
  

    // Start is called before the first frame update
    void Start()
    {
         Invoke("DestroyDelay", Livetime);
        Damage(attack);
    }

       void Damage(int newAttack) //esto es un metodo
    {
           hp = hp - newAttack;


    }
    
    // Update is called once per frame
    void Update()
    {
        move();

        if (Input.GetKeyUp(KeyCode.Space))
        {
           transform.localScale = direchone * scaleChange * Time.deltaTime;
        }
        


    }

    private void move()
    {
        transform.position += direction * Speed * Time.deltaTime;

    }
    private void DestroyDelay()
    {
        Debug.Log("DESTROY DELAY");
        Destroy(gameObject);


    }
}
