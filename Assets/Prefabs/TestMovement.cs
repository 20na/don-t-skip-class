using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{
    /*public Transform exitRoom;
    public float teleportDelay = 30f; 
    
     public Transform corner_1;
     public Transform corner_2;
     public Transform corner_3;
     public Transform corner_4;
     
     
     Transform[] corners = new Transform[];
     int corner_index=0;

     public float moveSpeed= 5f;
     public float movingDelay= 5f;
    */
     // Start is called before the first frame update
    void Start()
    {
        /* if (exitRoom != null){
            Invoke("Teleport", teleportDelay);
           

        }

        */

    }

    //public Transform beacon;
    //public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
    
    /*if (corner_index <= corners.Length -1){
            transform.position = Vector3.MoveTowards(transform.position, corners[corner_index].transform.position, moveSpeed *Time.deltaTime);

            if (transform.position == corners[corner_index].transform.position){
                corner_index=1;
            }

            

        }
  */

      //  Moving();
        
    }

   // void Teleport(){
        //yield return new WaitForSeconds(teleportDelay);

        //transform.position= exitRoom.position;

        
 //   }

    /*void Moving(){
        int curr_Corner=1;
        Vector3 direction; 
        //bool complete= false;

        while(curr_Corner <= 4){
        
        if (corner_1 != null && curr_Corner== 1){
            direction = (corner_1.position- transform.position).normalized;

            transform.position = Vector3.MoveTowards(transform.position, corner_2.position, moveSpeed* Time.deltaTime);
  
             if (Vector3.Distance(transform.position, corner_2.position) < 0.0001f)
            {
                // Stop moving or trigger any action
                moveSpeed = 0f;
                curr_Corner=2;
                break;
               // Debug.Log("Reached the beacon!");
               
            }
           // break;
        }

        else if(corner_2 != null&& curr_Corner==2){

            direction = (corner_3.position- transform.position).normalized;

            transform.position = Vector3.MoveTowards(transform.position, corner_3.position, moveSpeed*Time.deltaTime);
           

            if (Vector3.Distance(transform.position, corner_3.position) < 0.0001f)
            {
                // Stop moving or trigger any action
                moveSpeed = 0f;
                curr_Corner=3;
                break;
               // Debug.Log("Reached the beacon!");
               
            }
            //break;
        }

        else if(corner_3 != null && curr_Corner==3){
       
            direction = (corner_3.position- transform.position).normalized;

            transform.position = Vector3.MoveTowards(transform.position, corner_3.position, moveSpeed*Time.deltaTime);
            curr_Corner=4;
            //break;

        }

       else if(corner_4 != null && curr_Corner==4){

            direction = (corner_4.position- transform.position).normalized;

            transform.position = Vector3.MoveTowards(transform.position, corner_4.position, moveSpeed *Time.deltaTime);
            curr_Corner= 5;
            //break;
            
        }

        
        }
        }
        */


        
    }



