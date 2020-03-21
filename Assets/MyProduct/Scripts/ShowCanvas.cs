using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCanvas : MonoBehaviour
{
    [SerializeField] private Canvas customCanvas;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            //LookWalk moveScript = other.GetComponent<LookWalk>();
            customCanvas.enabled = true;
            //moveScript.canMove = false;
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
