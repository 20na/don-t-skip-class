using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotebookManager : MonoBehaviour
{
    public Text notebookText;

    int total = 0;

    // Start is called before the first frame update
    void Start()
    {
        notebookText.text = total.ToString() + " FOUND";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
