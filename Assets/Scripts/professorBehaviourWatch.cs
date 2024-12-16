using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class professorBehaviourWatch : MonoBehaviour
{
    public float watchStopSeconds = 5f;
    public float watchRotationSpeed = 30f;
    public GameObject positionTarget;
    private int watchRotationDirection = 1;
    private float resumeTime = -1;

    void Awake()
    {
        transform.position = new Vector3(positionTarget.transform.position.x, transform.position.y, positionTarget.transform.position.z);
        transform.rotation = positionTarget.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.rotation.eulerAngles.y);
        // If professor has reached max rotation, stop and wait
        if (transform.rotation.eulerAngles.y >= 90 && transform.rotation.eulerAngles.y <= 180)
        {
            resumeTime = Time.time + watchStopSeconds;
            transform.rotation = Quaternion.Euler(0, watchRotationDirection * 89.9f, 0);
            watchRotationDirection = watchRotationDirection * -1;
            //Debug.Log("max right reached");
        }
        // If professor has reached min rotation, stop and wait
        else if (transform.rotation.eulerAngles.y <= 270 && transform.rotation.eulerAngles.y >= 180)
        {
            resumeTime = Time.time + watchStopSeconds;
            transform.rotation = Quaternion.Euler(0, watchRotationDirection * 89.9f, 0);
            watchRotationDirection = watchRotationDirection * -1;
            //Debug.Log("min left reached");
        }
        // Professor is rotating
        else if (Time.time >= resumeTime)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * watchRotationSpeed * watchRotationDirection);
            //Debug.Log("rotating");
        }

        // I could theoretically optimize this by changing the conditions : 90 = 180 - 90 ; 270 = 180 +90
        // only thing is the change from >= to <= which I wouldn't really know how to handle
    }

    public void setToPosition()
    {
        transform.position = new Vector3(positionTarget.transform.position.x, transform.position.y, positionTarget.transform.position.z);
        transform.rotation = positionTarget.transform.rotation;
    }
}