using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCanvas : MonoBehaviour
{
    [SerializeField] private Canvas customCanvas;
    //public int scriptNumber = 0;
    
    void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Player"))
        {
            LookWalk moveScript = other.GetComponent<LookWalk>();
            moveScript.canMove = false;
            customCanvas.enabled = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            customCanvas.enabled = false;
        }
    }
}
