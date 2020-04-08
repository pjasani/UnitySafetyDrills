using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GymisContinuePressed : MonoBehaviour
{
    [SerializeField] public CanvasGym mainScript;
    public void ContinuePressed()
    {
        mainScript.buttonPressCount += 1;
    }
}
