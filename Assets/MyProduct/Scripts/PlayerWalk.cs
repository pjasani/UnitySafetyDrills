using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public int playerSpeed;

    void Update()
    {
        int i = 0;
        while (i < Input.touchCount)
        {
            Touch t = Input.GetTouch(i);
            if (t.phase == TouchPhase.Stationary)
            {
                if (t.position.x > Screen.width / 2)
                {
                    playerMove();
                }
            }
            else if (t.phase == TouchPhase.Ended)
            {
                playerStop();
            }
        }
    }

    public void playerMove()
    {
        Debug.Log("Player Move...");
        //transform.position = transform.position + Camera.main.transform.forward * Time.deltaTime;
    }
    public void playerStop()
    {
        Debug.Log("Player Stop...");
        //transform.position = transform.position;
    }
}
