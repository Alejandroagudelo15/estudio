using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMannager : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Transform endPoint;

    [SerializeField]
    [Range(1f,20f)] 
    private float rayDistance = 10;
    [SerializeField] private GameObject bullet;

    bool canShoot = true;

    // Start is called before the first frame update
    void Start()
    {
        

       
    }

    // Update is called once per frame
    void Update()
    {
        cannonRaycast();
    }

    private void cannonRaycast()
    {
         RaycastHit hit;
       if( Physics.Raycast(shootPoint.position, endPoint.position, out hit, rayDistance)){
        if(hit.transform.CompareTag("Player")&& canShoot)
        Debug.Log("collision con player");
        Instantiate(bullet, shootPoint.transform.position, bullet.transform.rotation);
        canShoot = false;
        Invoke ("delayShoot", 1f);
    }

}
void delayShoot(){
    canShoot = true;
}
private void OnDrawGizmo(){
Gizmos.color = Color.blue;
Vector3 direction = shootPoint.transform.TransformDirection(Vector3.forward) * rayDistance;
Gizmos.DrawLine(shootPoint.position, endPoint.position);

}
}
