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
    public GameObject bellSoundObject;
    private AudioSource bellSound;
    private float breakResumeTime;
    private float playtimeResumeTime;
    private int activeIndex = 0;
    private professorBehaviourWatch currentWatchBehavior;
    private Supedock_Move currentMoveBehavior;

    // Start is called before the first frame update
    void Start()
    {
        bellSound = bellSoundObject.GetComponent<AudioSource>();
        playtimeResumeTime = startTimeDuration;
        breakResumeTime = startTimeDuration + playTimeDuration;
        for (int i = 0; i < professors.Length; i ++)
        {
            professors[i].SetActive(false);
            classrooms[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Play time
        if (Time.time > playtimeResumeTime)
        {
            //play bell sound
            bellSound.Play();
            //activate activeIndex
            professors[activeIndex].SetActive(true);
            classrooms[activeIndex].SetActive(true);
            classrooms2[activeIndex].SetActive(true);
            //activate activeIndex
            professors[activeIndex + 1].SetActive(true);
            classrooms[activeIndex + 1].SetActive(true);
            classrooms2[activeIndex + 1].SetActive(true);
            //Next time
            playtimeResumeTime = Time.time + playTimeDuration + breakTimeDuration;

        }
        else if (Time.time > breakResumeTime)
        {
            //play bell sound
            bellSound.Play();
            //deactivate activeIndex
            professors[activeIndex].SetActive(false);
            classrooms[activeIndex].SetActive(false);
            classrooms2[activeIndex].SetActive(false);
            //deactivate activeIndex
            professors[activeIndex + 1].SetActive(false);
            classrooms[activeIndex + 1].SetActive(false);
            classrooms2[activeIndex + 1].SetActive(false);
            //all the technical stuff
            activeIndex = (activeIndex + 2) % 8;
            currentWatchBehavior = professors[activeIndex].GetComponent<professorBehaviourWatch>();
            currentMoveBehavior = professors[activeIndex].GetComponent<Supedock_Move>();
            breakResumeTime = Time.time + playTimeDuration;
        }
    }
}
