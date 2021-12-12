using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBarriorOnTimer : MonoBehaviour
{
    [SerializeField]
    private float timeRemaining, timerMax;
    private bool countDown;  
    public GameObject gameBarrior; 
    void Start()
    {
        timerMax = 60.0f; 
        timeRemaining = timerMax; 
        countDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0 && countDown) {
            timeRemaining -= Time.deltaTime; 
            if (timeRemaining <= 0) {
                countDown = false;
                timeRemaining = timerMax; 
                gameBarrior.SetActive(true);
            }
        }
    }

    public void StartCountDown() { 
        countDown = true;
        gameBarrior.SetActive(false);  
    }
}
