using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShitSucks : MonoBehaviour
{
public Transform exitRoom;
public Transform corner_1;
public Transform corner_2;
public Transform corner_3;
public Transform corner_4;

 public double targetPoint1= 0.1;
 public double targetPoint2= 0.2;
 public double targetPoint3= 0.3;
 public double targetPoint4= 0.4;

 public float teleportDelay = 30f; 
    // Start is called before the first frame update
    void Start()
    {
         if (exitRoom != null){
            Invoke("Teleport", teleportDelay);
           
        }

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Teleport(){
       // yield return new WaitForSeconds(teleportDelay);

        transform.position= exitRoom.position;
        StartCoroutine("walktoPoint1");
        StartCoroutine("walktoPoint2");
        StartCoroutine("walktoPoint3");
        StartCoroutine("walktoPoint4");

        
    }

    IEnumerator walktoPoint1(){
        Debug.Log("walk to point 1");
         Vector3 direction; 

        for(double i= 0.0; i <= targetPoint1; i+=0.02){
            direction = (corner_2.position- transform.position).normalized;
            
            transform.position = Vector3.MoveTowards(transform.position, corner_2.position, 5f* Time.deltaTime);
            
        }

        yield return null;
        
    }

    IEnumerator walktoPoint2(){
        StopCoroutine("walktoPoint1");

        Debug.Log("walk to point 2");
         Vector3 direction; 

        for(double i= 0.0; i <= targetPoint2; i+=0.02){
            direction = (corner_3.position- transform.position).normalized;
            
            transform.position = Vector3.MoveTowards(transform.position, corner_3.position, 5f* Time.deltaTime);
            
            
        }
       
        yield return null;
        
    }

    IEnumerator walktoPoint3(){
        StopCoroutine("walktoPoint2");
        Debug.Log("walk to point 3");
         Vector3 direction; 

        for(double i= 0.0; i <= targetPoint3; i+=0.02){
            direction = (corner_4.position- transform.position).normalized;
            
            transform.position = Vector3.MoveTowards(transform.position, corner_4.position, 5f* Time.deltaTime);
            
           
        }
        
        yield return null;
        
    }

    IEnumerator walktoPoint4(){
        StopCoroutine("walktoPoint3");
        Debug.Log("walk to point 4");
         Vector3 direction; 

        for(double i= 0.0; i <= targetPoint4; i+=0.02){
            direction = (corner_1.position- transform.position).normalized;
            
            transform.position = Vector3.MoveTowards(transform.position, corner_1.position, 5f* Time.deltaTime);
            
           
        }
       
        yield return null;
        
    }
}