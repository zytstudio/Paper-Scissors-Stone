using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ChooseGesture : MonoBehaviour
{
    private Image image;
    private RPS rPS;

    public string pSSName;
    public UnityEvent<RPS> TransferParam;

    private void Start()
    {
        rPS = new RPS(pSSName);
        image = GetComponent<Image>();
        image.sprite = rPS.sprite;
    }

    public void OnClick()
    {
        TransferParam?.Invoke(rPS);
    }
}
