using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SticksManager : MonoBehaviour
{
    public List<GameObject> sticks = new List<GameObject>();
    public List<GameObject> hitSticks = new List<GameObject>();
    public int hitSticksNumber;
    [SerializeField] private int lastAvailableStick;

    void Update()
    {

    }

    private void Reset()
    {
        for(int i = 0; i < sticks.Count; i++)
        {
            hitSticks.Remove(sticks[i]);
        }
    }
}
