using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitisContinuePressed : MonoBehaviour
{
    [SerializeField] public CanvasExit mainScript;
    public void ContinuePressed()
    {
        mainScript.buttonPressCount += 1;
    }
}
