using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookGrabDetector : MonoBehaviour
{
    private Vector3 initialPosition;
    public GameObject notebookManagerObject;
    private NotebookManager notebookManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        notebookManagerScript = notebookManagerObject.GetComponent<NotebookManager>();
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != initialPosition)
        {
            notebookManagerScript.SwitchUI();
            Destroy(gameObject);
        }
    }
}
