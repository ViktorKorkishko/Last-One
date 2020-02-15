using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StickState
{
    notHit,
    waiting,
    hit
}

public class Stick : MonoBehaviour
{
    public StickState currentStickState;
    public GameObject touch;
    public GameObject sticksManager;
    public Color defaultColor;
    public Color firstPlayerColor;
    public Color secondPlayerColor;
    public bool toChange = true;

    void Start()
    {
        currentStickState = StickState.notHit;
    }

    void Update()
    {
        if (currentStickState == StickState.waiting && !touch.GetComponent<TouchController>().isTouching)
        {
            currentStickState = StickState.hit;
            ChangeColor();
            touch.GetComponent<TouchController>().ChangePlayer();
            sticksManager.GetComponent<SticksManager>().hitSticksNumber--;
        }
    }

    void ChangeColor()
    {
        if (touch.GetComponent<TouchController>().currentPlayerOrder == PlayerOrder.firstPlayer)
        {
            GetComponent<SpriteRenderer>().color = firstPlayerColor;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = secondPlayerColor;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (currentStickState == StickState.notHit &&
        other.gameObject.CompareTag("Touch") &&
        other.gameObject.GetComponent<TouchController>().isTouching)
        {
            currentStickState = StickState.waiting;
            sticksManager.GetComponent<SticksManager>().hitSticksNumber++;
            sticksManager.GetComponent<SticksManager>().lastAvailableStick++;
        }
    }
}
