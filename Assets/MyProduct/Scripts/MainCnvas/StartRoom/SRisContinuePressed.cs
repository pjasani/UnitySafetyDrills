using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRisContinuePressed : MonoBehaviour
{
    [SerializeField] public CanvasStartRoom mainScript;
    public void ContinuePressed()
    {
        mainScript.buttonPressCount += 1;
    }
}
