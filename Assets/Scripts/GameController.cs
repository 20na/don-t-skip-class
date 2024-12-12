using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameOverScreen;
    private GameObject scheduleController;
    private Schedule scheduleScript;

    private void Start()
    {
        scheduleController = GameObject.Find("ScheduleManager");
        scheduleScript = scheduleController.GetComponent<Schedule>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        gameOverScreen.SetActive(true);
        StartCoroutine(Coroutine1());
        //Ending game (deactivating schedule and professors)
        scheduleScript.endGame();
    }

    IEnumerator Coroutine1()
    {
        yield return new WaitForSeconds(2);
        gameOverScreen.SetActive(false);
    }
    
}
