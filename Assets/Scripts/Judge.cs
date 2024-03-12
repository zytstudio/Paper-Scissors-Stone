using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    private ResultStorage result;

    public GameObject player1HealthSlider;
    public GameObject player2HealthSlider;

    private HealthSliderController controller1, controller2;

    private void Start()
    {
        result = GetComponent<ResultStorage>();
        controller1 = player1HealthSlider.GetComponent<HealthSliderController>();
        controller2 = player2HealthSlider.GetComponent<HealthSliderController>();
    }

    public void StartJudge()
    {
        if(result.rPS1 > result.rPS2)
        {
            controller2.AddHealth(-1);
            return;
        }
        if (result.rPS1 < result.rPS2)
        {
            controller1.AddHealth(-1);
        }
    }
}
