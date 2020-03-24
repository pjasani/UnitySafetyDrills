using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPlayerMove : MonoBehaviour
{
    [SerializeField] private LookWalk moveScript;
    public void PlayerMove()
    {
        moveScript.canMove = true;
    }
}
