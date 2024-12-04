using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameOverScreen;


    public void OnCollisionEnter(Collision collision)
    {
        gameOverScreen.SetActive(true);
        StartCoroutine(Coroutine1());
    }

    IEnumerator Coroutine1()
    {
        yield return new WaitForSeconds(2);
        gameOverScreen.SetActive(false);
    }
    
}
