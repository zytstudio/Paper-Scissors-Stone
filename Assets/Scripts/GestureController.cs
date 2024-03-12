using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GestureController : MonoBehaviour
{
    private Image image;

    public bool isPaused;
    public int player;
    public RPS choice;
    public UnityEvent<RPS, int> OnUpdate;

    void Start()
    {
        image = GetComponent<Image>();
    }

    public void UpdateChoice(RPS choice)
    {
        if(isPaused)
        {
            return;
        }
        this.image.enabled = true;
        this.choice = choice;
        image.sprite = choice.sprite;
        OnUpdate.Invoke(choice, player);
    }

    public void Clear()
    {
        choice = new RPS(0);
        image.sprite = null;
        this.image.enabled = false;
    }

    public void SetPause(bool isPaused)
    {
        this.isPaused = isPaused;
    }
}
