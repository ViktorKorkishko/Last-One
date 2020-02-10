using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public GameObject sticksManager;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Touch"))
        {
            sticksManager.GetComponent<SticksManager>().hitSticksNumber++;
            sticksManager.GetComponent<SticksManager>().sticks.Remove(this.gameObject);
            sticksManager.GetComponent<SticksManager>().hitSticks.Add(this.gameObject);
        }
    }
}
