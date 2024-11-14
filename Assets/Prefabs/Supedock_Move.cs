using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Supedock_Move : MonoBehaviour
{
public Transform exitRoom;
public Transform corner_1;
public Transform corner_2;
public Transform corner_3;
public Transform corner_4;

 

 public float teleportDelay = 5f; 
  public float moveDelay = 5f; 
    // Start is called before the first frame update
    void Start()
    {
         if (exitRoom != null){
            Invoke("Teleport", teleportDelay);
           // Invoke("walktoPoint1", moveDelay);
            //StartCoroutine("walktoPoint1");
           
        }

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Teleport(){
       // yield return new WaitForSeconds(teleportDelay);

        transform.position= exitRoom.position;
        Debug.Log("teleport");
        StartCoroutine("walktoPoint1");
      
        
        
       // Invoke("walktoPoint1", moveDelay);
        //StartCoroutine("walktoPoint3");
        //StartCoroutine("walktoPoint4");
    }
    
    IEnumerator walktoPoint1(){
        Debug.Log("walk to point 1");
         Vector3 direction; 
         //Debug.Log(targetPoint1);
          //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
         
        yield return new WaitForSeconds(3);
        for(float i= 0.0f;Vector3.Distance(transform.position, corner_1.position) > 0.001f; i--){
            direction = (corner_1.position- transform.position).normalized;

            Debug.Log("walk to point 1 LOOP");
            transform.position = Vector3.Lerp(transform.position, corner_1.position, 1f* Time.deltaTime);
            
        }
        //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
        Debug.Log(Vector3.Distance(transform.position, corner_1.position));

        if (Vector3.Distance(transform.position, corner_1.position) < 0.001f){
            Debug.Log("comparing positions");
           StopCoroutine("walktoPoint1");
           StartCoroutine("walktoPoint2");
        }
        yield return null;
        
    }
    
    IEnumerator walktoPoint2(){
       // StopCoroutine("walktoPoint1");

        Debug.Log("walk to point 2");
         Vector3 direction; 

        yield return new WaitForSeconds(3);
        for(float i= 0.0f; Vector3.Distance(transform.position, corner_2.position) > 0.001f; i--){
            direction = (corner_2.position- transform.position).normalized;
            Debug.Log("walk to point 2 LOOP");
            transform.position = Vector3.Lerp(transform.position, corner_2.position, 1f* Time.deltaTime);
            
            
        }

        if (Vector3.Distance(transform.position, corner_2.position) < 0.001f){
           Debug.Log("comparing positions");
           StopCoroutine("walktoPoint2");
           StartCoroutine("walktoPoint3");
        }
       
        yield return null;
        
    }

    IEnumerator walktoPoint3(){
        //StopCoroutine("walktoPoint2");
        Debug.Log("walk to point 3");
         Vector3 direction; 

        yield return new WaitForSeconds(3);
        for(double i= 0.0; Vector3.Distance(transform.position, corner_3.position) > 0.001f; i--){
            direction = (corner_3.position- transform.position).normalized;
            Debug.Log("walk to point 3 LOOP");
            transform.position = Vector3.Lerp(transform.position, corner_3.position, 1f* Time.deltaTime);
            
           
        }

         if (Vector3.Distance(transform.position, corner_3.position) < 0.001f){
           Debug.Log("comparing positions");
           StopCoroutine("walktoPoint3");
           StartCoroutine("walktoPoint4");
        }
        
        yield return null;
        
    }

    IEnumerator walktoPoint4(){
        //StopCoroutine("walktoPoint3");
        Debug.Log("walk to point 4");
         Vector3 direction; 

        yield return new WaitForSeconds(3);
        for(double i= 0.0; Vector3.Distance(transform.position, corner_4.position) > 0.001f; i--){
            direction = (corner_4.position- transform.position).normalized;
            Debug.Log("walk to point 4 LOOP");
            transform.position = Vector3.Lerp(transform.position, corner_4.position, 5f* Time.deltaTime);
            
           
        }

        if (Vector3.Distance(transform.position, corner_3.position) < 0.001f){
           Debug.Log("comparing positions");
           StopCoroutine("walktoPoint3");
           StartCoroutine("walktoPoint3");
        }
        
       if (Vector3.Distance(transform.position, corner_4.position) < 0.001f){
           Debug.Log("comparing positions");
           StopCoroutine("walktoPoint3");
           //StartCoroutine("walktoPoint3");
        }
       
        yield return null;
        
   } 
}
