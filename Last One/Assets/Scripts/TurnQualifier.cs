using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnQualifier : MonoBehaviour
{
    [SerializeField] public GameObject touch;
    public TextMeshProUGUI whoseTurnText;
    
    public void ChangeTurnInfo()
    {
        if(touch.GetComponent<TouchController>().currentPlayerOrder == PlayerOrder.firstPlayer)
        {
            whoseTurnText.text = "1st player turn";
        }
        else
        {
            whoseTurnText.text = "2nd player turn";
        }
    }
}
