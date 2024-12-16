using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Schedule : MonoBehaviour
{
    public float startTimeDuration = 30;
    public float breakTimeDuration = 15;
    public float playTimeDuration = 150;
    public GameObject[] professors;
    public GameObject[] classrooms;
    public GameObject[] classrooms2;
    public GameObject[] professors2;
    public GameObject bellSoundObject;
    private AudioSource bellSound;
    private float breakResumeTime;
    private float playtimeResumeTime;
    private int activeIndex = 0;
    private int previousIndex = 6;
    private bool isGameActive = true;
    private Vector3[] professorsPositions;
    private Quaternion[] professorsRotations;
    private professorBehaviourWatch currentProfessorWatchScript;
    private Supedock_Move currentProfessorPatrolScript;

    // Start is called before the first frame update
    void Start()
    {
        bellSound = bellSoundObject.GetComponent<AudioSource>();
        playtimeResumeTime = startTimeDuration;
        breakResumeTime = startTimeDuration + playTimeDuration;
        for (int i = 0; i < professors.Length; i ++)
        {
            professorsPositions[i] = professors[i].transform.position;
            professorsRotations[i] = professors[i].transform.rotation;
            professors[i].SetActive(false);
            classrooms[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive)
        {
            //Play time
            if (Time.time > playtimeResumeTime)
            {
                Debug.Log("Play time, index " + activeIndex.ToString());
                //play bell sound
                bellSound.Play();
                //activate professors
                //Patrol professor
                professors[activeIndex].SetActive(true);
                currentProfessorPatrolScript = professors[activeIndex + 1].GetComponent<Supedock_Move>();
                //Watch professor
                professors[activeIndex + 1].SetActive(true);
                currentProfessorWatchScript = professors[activeIndex + 1].GetComponent<professorBehaviourWatch>();
                currentProfessorWatchScript.setToPosition();
                //deactivate their classrooms
                classrooms[activeIndex].SetActive(false);
                classrooms[activeIndex + 1].SetActive(false);
                //deactivate bonus classrooms
                classrooms2[activeIndex].SetActive(false);
                classrooms2[activeIndex + 1].SetActive(false);
                //reactivate previous prof classrooms
                classrooms[previousIndex].SetActive(true);
                classrooms[previousIndex + 1].SetActive(true);
                //reactivate previous bonus classrooms
                classrooms2[previousIndex].SetActive(true);
                classrooms2[previousIndex + 1].SetActive(true);
                //Next time
                playtimeResumeTime = Time.time + playTimeDuration + breakTimeDuration;

            }
            else if (Time.time > breakResumeTime)
            {
                Debug.Log("Break time");
                //play bell sound
                bellSound.Play();
                //deactivate professors
                professors[activeIndex].SetActive(false);
                professors[activeIndex + 1].SetActive(false);
                //all the technical stuff
                previousIndex = activeIndex;
                activeIndex = (activeIndex + 2) % 8;
                breakResumeTime = Time.time + playTimeDuration + breakTimeDuration;
            }
        }
    }

    public void endGame()
    {
        isGameActive = false;
        //deactivating all profs
        for (int i = 0; i < professors.Length; i++)
        {
            professors[i].SetActive(false);
            classrooms[i].SetActive(false);
        }
    }
}
