using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPlayerMove : MonoBehaviour
{
    public GameObject playerObject;
    public void PlayerMove()
    {
        playerObject = GameObject.Find("Player");
        Debug.Log(playerObject);
        //moveScript.canMove = true;
        
    }
}
