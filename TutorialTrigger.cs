using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTrigger : MonoBehaviour
{
    public float delay;
    public GameObject tutorial;

    void OnTriggerEnter()
    {

        tutorial.SetActive(true);
        Invoke("func", delay);


    }
    public void func()
    {
        tutorial.SetActive(false); 
    }
}
