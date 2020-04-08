using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BSisContinuePressed : MonoBehaviour
{
    [SerializeField] public CanvasBottomStairs mainScript;
    public void ContinuePressed()
    {
        mainScript.buttonPressCount += 1;
    }
}
