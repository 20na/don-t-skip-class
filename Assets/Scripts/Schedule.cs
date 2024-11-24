using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Schedule : MonoBehaviour
{
    public float startTimeDuration = 10;
    public float breakTimeDuration = 5;
    public float playTimeDuration = 60;
    public GameObject[] professors;
    private float breakResumeTime;
    private float playtimeResumeTime;
    private int activeProf1 = 0;
    private int activeProf2 = 1;

    // Start is called before the first frame update
    void Start()
    {
        playtimeResumeTime = startTimeDuration;
        breakResumeTime = startTimeDuration + playTimeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        //Play time
        if (Time.time > playtimeResumeTime)
        {
            //play bell sound
            //activate activeProf1
            //activate activeProf2
            playtimeResumeTime = Time.time + playTimeDuration + breakTimeDuration;

        }
        else if (Time.time > breakResumeTime)
        {
            //play bell sound
            //deactivate activeProf1
            //deactivate activeProf2
            activeProf1 = (activeProf1 + 2) % 7;
            activeProf2 = (activeProf2 + 2) % 7;
            breakResumeTime = Time.time + playTimeDuration;
        }
    }
}
