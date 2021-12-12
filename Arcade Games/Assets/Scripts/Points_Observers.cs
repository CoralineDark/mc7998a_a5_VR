using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 
using UnityEngine.UI; 

public class Points_Observers : MonoBehaviour
{

    [SerializeField]
    private string pointType;
    private int _numPoints; 
    public Text scoreBoard;  
    void Start()
    {
        _numPoints = 0;
        scoreBoard.text = "0" + _numPoints;  
    }

    void Update()
    {
        if (_numPoints < 10) 
            scoreBoard.text = "0" + _numPoints;
        else if (_numPoints >= 10) 
            scoreBoard.text = "" + _numPoints;          
    }

    private void OnEnable() { 
        Points_Subjects.GainPoints += AddPoints; 
    }

    private void OnDisable() { 
        Points_Subjects.GainPoints -= AddPoints; 
    }

    public void AddPoints(int points, string ballType) { 
        if (ballType == pointType) {
            _numPoints += points; 
        }
    }
}
