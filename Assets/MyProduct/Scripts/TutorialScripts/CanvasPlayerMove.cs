using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPlayerMove : MonoBehaviour
{
    [SerializeField] private LookWalk moveScript;
    public Canvas myScriptCanvas;
    public void PlayerMove()
    {
        myScriptCanvas.enabled = false;
      //  moveScript.canMove = true;
    }
}
