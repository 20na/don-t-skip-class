using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotebookManager : MonoBehaviour
{
    public Text[] notebookTexts;
    private int currentNotebookIndex = 0;

    // Method to handle finding a notebook
    public void AddNotebook(string notebookName)
    {
        // Ensure we don't exceed the number of Text elements
        if (currentNotebookIndex < notebookTexts.Length)
        {
            // Update the UI for the current notebook
            notebookTexts[currentNotebookIndex].text = notebookName + " FOUND";
            notebookTexts[currentNotebookIndex].gameObject.SetActive(true); // Make the Text visible if it was hidden

            // Move to the next index for the next found notebook
            currentNotebookIndex++;
        }
    }
}
