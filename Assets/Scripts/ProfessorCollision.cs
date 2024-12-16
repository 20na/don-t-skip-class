using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProfessorCollision : MonoBehaviour
{
    public TextMeshPro lose;                    
    private GameObject scheduleController;    
    private Schedule scheduleScript;         

    void Start()
    {
        scheduleController = GameObject.Find("ScheduleManager");
        scheduleScript = scheduleController.GetComponent<Schedule>();
        lose.gameObject.SetActive(false);
    }

    // Detect collision with professors
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        // Check if the collided object is a professor
        if (collision.gameObject.CompareTag("Professor"))
        {
            Debug.Log("Collided with Professor!");
            EndGame();
        }
    }

    private void EndGame()
    {
        lose.gameObject.SetActive(true);

        // Stop the schedule system
        scheduleScript.endGame();
        StartCoroutine(HideGameOverScreenAfterDelay());
    }

    // Coroutine to hide the game over screen after 2 seconds
    private IEnumerator HideGameOverScreenAfterDelay()
    {
        yield return new WaitForSeconds(2);
    }
}
