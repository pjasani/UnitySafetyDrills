using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGivenCanvas : MonoBehaviour
{
    [SerializeField] private Canvas customCanvas;

    //public int scriptNumber = 0;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            //LookWalk moveScript = other.GetComponent<LookWalk>();
            customCanvas.enabled = true;
        }
    }
    //void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        customCanvas.enabled = false;
    //    }
    //}
}
