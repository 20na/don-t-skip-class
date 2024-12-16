using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    private Vector3[] professorsPositions = new Vector3[8];
    private Quaternion[] professorsRotations = new Quaternion[8];
    private Vector3[] professorsPositions2 = new Vector3[8];
    private Quaternion[] professorsRotations2 = new Quaternion[8];
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
            Debug.Log(professors[i].transform.position);
            professorsPositions[i] = professors[i].transform.position;
            professorsRotations[i] = professors[i].transform.rotation;
            professors[i].SetActive(true);
            classrooms[i].SetActive(true);
            professorsPositions2[i] = professors2[i].transform.position;
            professorsRotations2[i] = professors2[i].transform.rotation;
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
                currentProfessorPatrolScript = professors[activeIndex].GetComponent<Supedock_Move>();
                currentProfessorPatrolScript.behaviorIsActive = true;
                //Watch professor
                professors[activeIndex + 1].SetActive(true);
                currentProfessorWatchScript = professors[activeIndex + 1].GetComponent<professorBehaviourWatch>();
                currentProfessorWatchScript.setToPosition();
                //deactivate their classrooms
                classrooms[activeIndex].SetActive(false);
                classrooms[activeIndex + 1].SetActive(false);
                //deactivate bonus classrooms
                classrooms2[activeIndex].SetActive(false);
                professors2[activeIndex].SetActive(false);
                classrooms2[activeIndex + 1].SetActive(false);
                professors2[activeIndex + 1].SetActive(false);
                //reactivate previous prof classrooms
                classrooms[previousIndex].SetActive(true);
                professors[previousIndex].SetActive(true);
                professors[previousIndex].transform.position = professorsPositions[previousIndex];
                professors[previousIndex].transform.rotation = professorsRotations[previousIndex];
                classrooms[previousIndex + 1].SetActive(true);
                professors[previousIndex + 1].SetActive(true);
                professors[previousIndex + 1].transform.position = professorsPositions[previousIndex + 1];
                professors[previousIndex + 1].transform.rotation = professorsRotations[previousIndex + 1];
                //reactivate previous bonus classrooms
                classrooms2[previousIndex].SetActive(true);
                professors2[previousIndex].SetActive(true);
                professors2[previousIndex].transform.position = professorsPositions2[previousIndex];
                professors2[previousIndex].transform.rotation = professorsRotations2[previousIndex];
                classrooms2[previousIndex + 1].SetActive(true);
                professors2[previousIndex + 1].SetActive(true);
                professors2[previousIndex + 1].transform.position = professorsPositions2[previousIndex + 1];
                professors2[previousIndex + 1].transform.rotation = professorsRotations2[previousIndex + 1];
                //Next time
                Debug.Log("time change");
                playtimeResumeTime = Time.time + playTimeDuration + breakTimeDuration;

                Debug.Log("classroom Larkins " + classrooms[6].activeSelf.ToString());
                Debug.Log("classroom Superdock " + classrooms[7].activeSelf.ToString());
                Debug.Log("classroom Sanders " + classrooms[0].activeSelf.ToString());
                Debug.Log("classroom Cowen " + classrooms[1].activeSelf.ToString());
                Debug.Log("classroom Kugele " + classrooms[2].activeSelf.ToString());
                Debug.Log("classroom Kirlin " + classrooms[4].activeSelf.ToString());
                Debug.Log("classroom Welsh " + classrooms[5].activeSelf.ToString());
                Debug.Log("classroom Phillips " + classrooms[3].activeSelf.ToString());
            }
            else if (Time.time > breakResumeTime)
            {
                Debug.Log("Break time");
                //play bell sound
                bellSound.Play();
                //deactivate professors
                professors[activeIndex].SetActive(false);
                professors[activeIndex].transform.position = professorsPositions[activeIndex];
                professors[activeIndex].transform.rotation = professorsRotations[activeIndex];
                professors[activeIndex + 1].SetActive(false);
                currentProfessorWatchScript.behaviorIsActive = false;
                professors[activeIndex + 1].transform.position = professorsPositions[activeIndex + 1];
                professors[activeIndex + 1].transform.rotation = professorsRotations[activeIndex + 1];
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
