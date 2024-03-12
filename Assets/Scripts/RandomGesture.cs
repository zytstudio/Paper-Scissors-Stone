using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomGesture : MonoBehaviour
{
    public bool isPaused;

    private GestureController gestureController;

    private void Start()
    {
        gestureController = GetComponent<GestureController>();
    }

    private void FixedUpdate()
    {
        if (isPaused)
        {
            return;
        }
        int newGestureType = Random.Range(1, 4);
        RPS newRPS = new RPS(newGestureType);
        gestureController.UpdateChoice(newRPS);
    }
}
