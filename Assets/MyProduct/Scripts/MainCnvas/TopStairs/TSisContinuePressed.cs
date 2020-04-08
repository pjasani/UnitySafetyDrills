using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TSisContinuePressed : MonoBehaviour
{
    [SerializeField] public CanvasTopStairs mainScript;
    public void ContinuePressed()
    {
        mainScript.buttonPressCount += 1;
    }
}
