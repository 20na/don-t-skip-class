using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProfessorCollision : MonoBehaviour
{
    public TextMeshPro lose;
    public GameObject gameOverScreen;
   // public GameObject ProfessorBots;
    private GameObject scheduleController;
    private Schedule scheduleScript;
    //public GameObject[] Prof;
    


    // Start is called before the first frame update
    void Start()
    {
        scheduleController = GameObject.Find("ScheduleManager");
        scheduleScript = scheduleController.GetComponent<Schedule>();
    }

      public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Professor collider script collision detected");
        if(collision.gameObject.CompareTag("Professor")){
            Debug.Log("Contact Professor");
            gameOverScreen.SetActive(true);
            StartCoroutine(Coroutine1());
            lose.gameObject.SetActive(true);
        //Ending game (deactivating schedule and professors)
            scheduleScript.endGame();
        } else {
            lose.gameObject.SetActive(false);
        }
        
        
    }

    IEnumerator Coroutine1()
    {
        yield return new WaitForSeconds(2);
        gameOverScreen.SetActive(false);
    }

}
