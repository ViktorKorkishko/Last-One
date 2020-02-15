using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerOrder
{
    firstPlayer,
    secondPlayer
}

public class TouchController : MonoBehaviour
{
    public GameObject stickManager;
    public PlayerOrder currentPlayerOrder;
    Rigidbody2D rb;
    Touch touch;
    public bool isTouching;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPlayerOrder = PlayerOrder.firstPlayer;
        stickManager.GetComponent<SticksManager>().UpdateAvailableSticks();
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            TouchPositionControl(touch);
            isTouching = true;
        }
        else
        {
            isTouching = false;
        }
    }

    public void ChangePlayer()
    {
        if (stickManager.GetComponent<SticksManager>().hitSticksNumber == 1)
        {
            if (currentPlayerOrder == PlayerOrder.firstPlayer)
            {
                currentPlayerOrder = PlayerOrder.secondPlayer;
            }
            else
            {
                currentPlayerOrder = PlayerOrder.firstPlayer;
            }
            stickManager.GetComponent<TurnQualifier>().ChangeTurnInfo();
            stickManager.GetComponent<SticksManager>().UpdateAvailableSticks();
        }
    }

    void TouchPositionControl(Touch touch)
    {
        touch = Input.GetTouch(0);
        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
        touchPosition.z = 0;
        transform.position = touchPosition;
    }
}
