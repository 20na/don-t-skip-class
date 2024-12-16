using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NotebookManager : MonoBehaviour
{
    public TextMeshPro[] notebookTexts;
    public int currentNotebookIndex = 0;
    public TextMeshPro win;

    void Start()
    {
        ActivateUI(currentNotebookIndex);
      
    }

    void Update()
    {
       
    }

    public void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Notebook")){
            SwitchUI();
        }
    }
    public bool IsActiveUIAtIndex(int indexToCheck)
    {
        if (indexToCheck >= 0 && indexToCheck < notebookTexts.Length)
        {
            return notebookTexts[currentNotebookIndex] == notebookTexts[indexToCheck];
        }
        else
        {
            return false;
        }
    }

    void ActivateUI(int index)
    {
        foreach (TextMeshPro ui in notebookTexts)
        {
            ui.gameObject.SetActive(false);
        }
        if (index >= 0 && index < notebookTexts.Length)
        {
            notebookTexts[index].gameObject.SetActive(true);
        } else 
        {
            notebookTexts[index].gameObject.SetActive(false);
       
        }
        if (index == 15)
        {
            notebookTexts[index].gameObject.SetActive(false);
            win.gameObject.SetActive(true);
        }
        else
        {
            win.gameObject.SetActive(false);
        }

        
    }

    public void SwitchUI()
    {
        currentNotebookIndex = (currentNotebookIndex + 1) % notebookTexts.Length;
        ActivateUI(currentNotebookIndex);
    }
}