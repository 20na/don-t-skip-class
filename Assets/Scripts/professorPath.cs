using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class professorPath : MonoBehaviour
{


public Transform professor;
//public Transform professorRoom;
public Transform exitRoom;
public Transform corner_1;
public Transform corner_2;
public Transform corner_3;
public Transform corner_4;
public Transform corner_5;
public Transform corner_6;
public Transform corner_7;


public float speed; 
public bool fullmap;

 

 public float teleportDelay = 5f; 
 // public float moveDelay = 5f; 

    // Start is called before the first frame update
    void Start()
    {
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
       // Debug.Log("teleport");
        StartCoroutine("walktoPoint1");
      
        
        
       // Invoke("walktoPoint1", moveDelay);
        //StartCoroutine("walktoPoint3");
        //StartCoroutine("walktoPoint4");
    }
    
    IEnumerator walktoPoint1(){
       // Debug.Log("walk to point 1");
         Vector3 direction; 
         //Debug.Log(targetPoint1);
          //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
         
        
        for(float i= 0.0f;Vector3.Distance(transform.position, corner_1.position) > 1f; i--){
            yield return new WaitForSeconds(0.00002f);
            direction = (corner_1.position- transform.position).normalized;
            //Debug.Log(transform.position);
            transform.position = Vector3.Lerp(transform.position, corner_1.position, speed* Time.deltaTime);
            
        }
        //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
        //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
       

        if (Vector3.Distance(transform.position, corner_1.position) <= 1f){
          //  Debug.Log("comparing positions");
           StopCoroutine("walktoPoint1");
           StartCoroutine("walktoPoint2");
        }
        yield return null;
        
    }
    
    IEnumerator walktoPoint2(){
       // StopCoroutine("walktoPoint1");

       // Debug.Log("walk to point 2");
         Vector3 direction; 

        
        for(float i= 0.0f; Vector3.Distance(transform.position, corner_2.position) > 1f; i--){
             yield return new WaitForSeconds(0.00002f);
            direction = (corner_2.position- transform.position).normalized;
          //  Debug.Log(transform.position);
            transform.position = Vector3.Lerp(transform.position, corner_2.position, speed* Time.deltaTime);
            
            
        }

        if (Vector3.Distance(transform.position, corner_2.position) <= 1f){
         //  Debug.Log("comparing positions");
           StopCoroutine("walktoPoint2");
           StartCoroutine("walktoPoint3");
        }
       
        yield return null;
        
    }

    IEnumerator walktoPoint3(){
        //StopCoroutine("walktoPoint2");
        //Debug.Log("walk to point 3");
         Vector3 direction; 

      
        for(double i= 0.0; Vector3.Distance(transform.position, corner_3.position) > 1f; i--){
            yield return new WaitForSeconds(0.00002f);
            direction = (corner_3.position- transform.position).normalized;
           // Debug.Log(transform.position);
            transform.position = Vector3.Lerp(transform.position, corner_3.position, speed* Time.deltaTime);
            
           
        }

         if (Vector3.Distance(transform.position, corner_3.position) <= 1f){
         //  Debug.Log("comparing positions");
           StopCoroutine("walktoPoint3");
           StartCoroutine("walktoPoint4");
        }
        
        yield return null;
        
    }

    IEnumerator walktoPoint4(){
        //StopCoroutine("walktoPoint3");
    //    Debug.Log("walk to point 4");
         Vector3 direction; 

        
        for(double i= 0.0; Vector3.Distance(transform.position, corner_4.position) > 1f; i--){
             yield return new WaitForSeconds(0.00002f);
            direction = (corner_4.position- transform.position).normalized;
  //          Debug.Log(transform.position);
            transform.position = Vector3.Lerp(transform.position, corner_4.position, speed* Time.deltaTime);
            
           
        }

        if (Vector3.Distance(transform.position, corner_4.position) <= 1f){
//           Debug.Log("comparing positions");
           if (fullmap == false){
           transform.position= professor.position;
           StopCoroutine("walktoPoint4");
           }

           else{
               

              StartCoroutine("walktoPoint5"); 
           }
        }
        
     
        yield return null;
        
   } 

   IEnumerator walktoPoint5(){
    //    Debug.Log("walk to point 5");
         Vector3 direction; 
         //Debug.Log(targetPoint1);
          //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
         
        
        for(float i= 0.0f;Vector3.Distance(transform.position, corner_5.position) > 1f; i--){
            yield return new WaitForSeconds(0.00002f);
            direction = (corner_5.position- transform.position).normalized;
            //Debug.Log(transform.position);
            transform.position = Vector3.Lerp(transform.position, corner_5.position, speed* Time.deltaTime);
            
        }
        //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
   //     Debug.Log(Vector3.Distance(transform.position, corner_5.position));
       

        if (Vector3.Distance(transform.position, corner_5.position) <= 1f){
    //        Debug.Log("comparing positions");
           StopCoroutine("walktoPoint5");
           StartCoroutine("walktoPoint6");
        }
        yield return null;
        
    }


    IEnumerator walktoPoint6(){
    //    Debug.Log("walk to point 6");
         Vector3 direction; 
         //Debug.Log(targetPoint1);
          //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
         
        
        for(float i= 0.0f;Vector3.Distance(transform.position, corner_6.position) > 1f; i--){
            yield return new WaitForSeconds(0.00002f);
            direction = (corner_6.position- transform.position).normalized;
            //Debug.Log(transform.position);
            transform.position = Vector3.Lerp(transform.position, corner_6.position, speed* Time.deltaTime);
            
        }
        //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
      //  Debug.Log(Vector3.Distance(transform.position, corner_6.position));
       

        if (Vector3.Distance(transform.position, corner_6.position) <= 1f){
      //      Debug.Log("comparing positions");
           StopCoroutine("walktoPoint6");
           StartCoroutine("walktoPoint7");
        }
        yield return null;
        
    }

    IEnumerator walktoPoint7(){
    //    Debug.Log("walk to point 7");
         Vector3 direction; 
         //Debug.Log(targetPoint1);
          //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
         
        
        for(float i= 0.0f;Vector3.Distance(transform.position, corner_7.position) > 1f; i--){
            yield return new WaitForSeconds(0.00002f);
            direction = (corner_7.position- transform.position).normalized;
            //Debug.Log(transform.position);
            transform.position = Vector3.Lerp(transform.position, corner_7.position, speed* Time.deltaTime);
            
        }
        //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
//        Debug.Log(Vector3.Distance(transform.position, corner_7.position));
       

        if (Vector3.Distance(transform.position, corner_7.position) <= 1f){
 //           Debug.Log("comparing positions");
           //transform.position= professor.position;
           StopCoroutine("walktoPoint7");
           StartCoroutine("reversetoPoint6");
        }
        yield return null;
        
    }

     IEnumerator reversetoPoint6(){
     //   Debug.Log("reverse to point 6");
         Vector3 direction; 
         //Debug.Log(targetPoint1);
          //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
         
        
        for(float i= 0.0f;Vector3.Distance(transform.position, corner_6.position) > 1f; i--){
            yield return new WaitForSeconds(0.00002f);
            direction = (corner_6.position- transform.position).normalized;
            //Debug.Log(transform.position);
            transform.position = Vector3.Lerp(transform.position, corner_6.position, speed* Time.deltaTime);
            
        }
        //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
    //    Debug.Log(Vector3.Distance(transform.position, corner_6.position));
       

        if (Vector3.Distance(transform.position, corner_6.position) <= 1f){
        //    Debug.Log("comparing positions");
           //transform.position= professor.position;
           StopCoroutine("reversetoPoint6");
           StartCoroutine("reversetoPoint5");
        }
        yield return null;
        
    }

    IEnumerator reversetoPoint5(){
    //    Debug.Log("reverse to point 5");
         Vector3 direction; 
         //Debug.Log(targetPoint1);
          //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
         
        
        for(float i= 0.0f;Vector3.Distance(transform.position, corner_5.position) > 1f; i--){
            yield return new WaitForSeconds(0.00002f);
            direction = (corner_5.position- transform.position).normalized;
            //Debug.Log(transform.position);
            transform.position = Vector3.Lerp(transform.position, corner_5.position, speed* Time.deltaTime);
            
        }
        //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
  //      Debug.Log(Vector3.Distance(transform.position, corner_5.position));
       

        if (Vector3.Distance(transform.position, corner_5.position) <= 1f){
        //    Debug.Log("comparing positions");
           StopCoroutine("reversetoPoint5");
           StartCoroutine("reversetoPoint4");
        }
        yield return null;
        
    }

    
    IEnumerator reversetoPoint4(){
    //    Debug.Log("reverse to point 4");
         Vector3 direction; 
         //Debug.Log(targetPoint1);
          //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
         
        
        for(float i= 0.0f;Vector3.Distance(transform.position, corner_4.position) > 1f; i--){
            yield return new WaitForSeconds(0.00002f);
            direction = (corner_4.position- transform.position).normalized;
            //Debug.Log(transform.position);
            transform.position = Vector3.Lerp(transform.position, corner_4.position, speed* Time.deltaTime);
            
        }
        //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
        Debug.Log(Vector3.Distance(transform.position, corner_4.position));
       

        if (Vector3.Distance(transform.position, corner_4.position) <= 1f){
        //    Debug.Log("comparing positions");
           StopCoroutine("reversetoPoint4");
           StartCoroutine("reversetoPoint3");
        }
        yield return null;
        
    }
   
     IEnumerator reversetoPoint3(){
     //   Debug.Log("reverse to point 3");
         Vector3 direction; 
         //Debug.Log(targetPoint1);
          //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
         
        
        for(float i= 0.0f;Vector3.Distance(transform.position, corner_3.position) > 1f; i--){
            yield return new WaitForSeconds(0.00002f);
            direction = (corner_3.position- transform.position).normalized;
            //Debug.Log(transform.position);
            transform.position = Vector3.Lerp(transform.position, corner_3.position, speed* Time.deltaTime);
            
        }
        //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
    //    Debug.Log(Vector3.Distance(transform.position, corner_3.position));
       

        if (Vector3.Distance(transform.position, corner_3.position) <= 1f){
    //        Debug.Log("comparing positions");
           StopCoroutine("reversetoPoint3");
           StartCoroutine("reversetoPoint2");
        }
        yield return null;
        
    }

    IEnumerator reversetoPoint2(){
     //   Debug.Log("reverse to point 2");
         Vector3 direction; 
         //Debug.Log(targetPoint1);
          //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
         
        
        for(float i= 0.0f;Vector3.Distance(transform.position, corner_2.position) > 1f; i--){
            yield return new WaitForSeconds(0.00002f);
            direction = (corner_2.position- transform.position).normalized;
            //Debug.Log(transform.position);
            transform.position = Vector3.Lerp(transform.position, corner_2.position, speed* Time.deltaTime);
            
        }
        //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
    //    Debug.Log(Vector3.Distance(transform.position, corner_2.position));
       

        if (Vector3.Distance(transform.position, corner_2.position) <= 1f){
    //        Debug.Log("comparing positions");
           StopCoroutine("reversetoPoint2");
           StartCoroutine("reversetoPoint1");
        }
        yield return null;
        
    }

     IEnumerator reversetoPoint1(){
    //    Debug.Log("reverse to point 1");
         Vector3 direction; 
         //Debug.Log(targetPoint1);
          //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
         
        
        for(float i= 0.0f;Vector3.Distance(transform.position, corner_1.position) > 1f; i--){
            yield return new WaitForSeconds(0.00002f);
            direction = (corner_1.position- transform.position).normalized;
            //Debug.Log(transform.position);
            transform.position = Vector3.Lerp(transform.position, corner_1.position, speed* Time.deltaTime);
            
        }
        //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
       // Debug.Log(Vector3.Distance(transform.position, corner_1.position));
       

        if (Vector3.Distance(transform.position, corner_1.position) <= 1f){
       //     Debug.Log("comparing positions");
           StopCoroutine("reversetoPoint1");
           StartCoroutine("reversetoPoint0");
        }
        yield return null;
        
    }

    IEnumerator reversetoPoint0(){
    //    Debug.Log("reverse to point 0");
         Vector3 direction; 
         //Debug.Log(targetPoint1);
          //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
         
        
        for(float i= 0.0f;Vector3.Distance(transform.position, exitRoom.position) > 1f; i--){
            yield return new WaitForSeconds(0.00002f);
            direction = (exitRoom.position- transform.position).normalized;
            //Debug.Log(transform.position);
            transform.position = Vector3.Lerp(transform.position, exitRoom.position, speed* Time.deltaTime);
            
        }
        //Debug.Log(Vector3.Distance(transform.position, corner_1.position));
      //  Debug.Log(Vector3.Distance(transform.position, exitRoom.position));
       

        if (Vector3.Distance(transform.position, exitRoom.position) <= 1f){
       //     Debug.Log("comparing positions");
           transform.position= professor.position;
           StopCoroutine("reversetoPoint0");
          
        }
        yield return null;
        
    } 

}
}

