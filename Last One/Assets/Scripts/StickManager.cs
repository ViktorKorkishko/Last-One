using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickManager : MonoBehaviour
{
    bool isCutting;
    public List<GameObject> sticks = new List<GameObject>();

    void Start()
    {

    }

    void Update()
    {
        if (Input.touchCount == 0)
        {
            StartCutting();
        }
        else
        {
            StopCutting();
        }
    }

    void StartCutting()
    {
        isCutting = true;
    }

    void StopCutting()
    {
        isCutting = false;
    }
}
