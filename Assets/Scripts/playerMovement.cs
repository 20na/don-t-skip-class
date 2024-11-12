using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public GameObject[] notebooks;
    private int currentBookIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Activate the first notebook UI
        notebooks[currentBookIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Check if if theres a next notebook
        if (currentBookIndex < notebooks.Length - 1)
        {
            //Deactivate current notebook
            notebooks[currentBookIndex].SetActive(false);

            //Move to the next notebook
            currentBookIndex++;
            notebooks[currentBookIndex].SetActive(true);

        }
    }
}
