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
        for (int i = 3; i < sticks.Count; i++)
        {
            if (i < lastAvailableStick)
            {
                sticks[i].GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }
}
