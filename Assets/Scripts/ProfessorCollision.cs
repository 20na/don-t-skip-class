using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfessorCollision : MonoBehaviour
{

    public GameObject gameOverScreen;
   // public GameObject ProfessorBots;
    private GameObject scheduleController;
    private Schedule scheduleScript;
    //public GameObject[] Prof;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

      public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Professor")){
            Debug.Log("Contact Professor");
            gameOverScreen.SetActive(true);
            StartCoroutine(Coroutine1());
        //Ending game (deactivating schedule and professors)
            scheduleScript.endGame();
        }
        
        
    }

    IEnumerator Coroutine1()
    {
        yield return new WaitForSeconds(2);
        gameOverScreen.SetActive(false);
    }

}
