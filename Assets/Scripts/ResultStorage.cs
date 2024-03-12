using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultStorage : MonoBehaviour
{
    public RPS rPS1, rPS2;

    public void SetRPS(RPS newRPS, int player)
    {
        if(player == 1)
        {
            rPS1 = newRPS;
            return;
        }
        rPS2 = newRPS;
    }
}
