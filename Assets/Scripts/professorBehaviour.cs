using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class professorBehaviour : MonoBehaviour
{
    public float moveSpeed = 8f;
    public float watchStopSeconds = 5f;
    public float watchRotationSpeed = 30f;
    public GameObject classroomDetectorCollider;
    public bool isMoving = false;
    public bool isWatching = false;
    public bool isInClass = true;
    public bool playerDetected = false;
    private int watchRotationDirection = 1;
    private Coroutine timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If the Professor is in class, detect if the player enters
        if (isInClass)
        {
            //activate the classroomDetectorCollider object
        }
        // Professor is moving
        else if (isMoving)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
            // go through a list of path objects (look for x and z coordinates only)
            // calculate direction and rotate prof to look that way
        }
        // Professor is watching (looking both ways looping)
        else if (isWatching)
        {
            Debug.Log(transform.rotation.eulerAngles.y);
            // If professor has reached max rotation, stop and wait
            if (transform.rotation.eulerAngles.y >= 90 && transform.rotation.eulerAngles.y <= 180)
            {
                timer = StartCoroutine(watchMaxRightReached());
                Debug.Log("max right reached");
            }
            // If professor has reached min rotation, stop and wait
            else if (transform.rotation.eulerAngles.y <= 270 && transform.rotation.eulerAngles.y >= 180)
            {
                timer = StartCoroutine(watchMinLeftReached());
                Debug.Log("min left reached");
            }
            // Professor is rotating
            else
            {
                if (timer is not null)
                {
                    StopCoroutine(timer);
                }
                transform.Rotate(Vector3.up, Time.deltaTime * watchRotationSpeed * watchRotationDirection);
                Debug.Log("rotating");
            }
        }
        //else, Professor is meeting (immobile)
    }

    // Makes the Professor stand still for specified time
    IEnumerator watchMinLeftReached()
    {
        watchRotationDirection = watchRotationDirection * -1;
        yield return new WaitForSeconds(watchStopSeconds);
        Debug.Log("debug min left");
        //transform.Rotate(Vector3.up, 0.1f);
        transform.rotation = Quaternion.Euler(0, -89.9f, 0);
    }

    // Makes the Professor stand still for specified time
    IEnumerator watchMaxRightReached()
    {
        watchRotationDirection = watchRotationDirection * -1;
        yield return new WaitForSeconds(watchStopSeconds);
        Debug.Log("debug max right");
        //transform.Rotate(Vector3.up, -0.1f);
        transform.rotation = Quaternion.Euler(0, 89.9f, 0);
    }
}