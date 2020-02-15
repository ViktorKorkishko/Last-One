using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SticksManager : MonoBehaviour
{
    public List<GameObject> sticks = new List<GameObject>();
    public int hitSticksNumber;
    public int lastAvailableStick = 3;

    public void UpdateAvailableSticks()
    {
        for (int i = 0; i < sticks.Count; i++)
        {
            if (i < lastAvailableStick)
            {
                sticks[i - 1].GetComponent<BoxCollider2D>().enabled = true;
                Debug.Log("Stick #" + (i - 1).ToString() + " switched on!");
            }
        }
    }
}
