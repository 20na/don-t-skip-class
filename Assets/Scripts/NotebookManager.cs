using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NotebookManager : MonoBehaviour
{
    public TextMeshProUGUI[] notebookTexts;
    public int currentNotebookIndex = 0;

    void Start()
    {
        ActivateUI(currentNotebookIndex);
    }

    void Update()
    {
        //if new nottebook  found 
        if (Input.GetKeyDown(KeyCode.C))
        {
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
        foreach (TextMeshProUGUI ui in notebookTexts)
        {
            ui.gameObject.SetActive(false);
        }
        if (index >= 0 && index < notebookTexts.Length)
        {
            notebookTexts[index].gameObject.SetActive(true);
        }
    }

    void SwitchUI()
    {
        currentNotebookIndex = (currentNotebookIndex + 1) % notebookTexts.Length;
        ActivateUI(currentNotebookIndex);
    }
}