using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class Points_Subjects : MonoBehaviour
{
    
    [SerializeField]
    private int goalPoints; 
    [SerializeField]
    private string ballType; 
    public static event Action<int, string> GainPoints;
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Ball") {
            GainPoints?.Invoke(goalPoints,ballType);
        }
    }
}
