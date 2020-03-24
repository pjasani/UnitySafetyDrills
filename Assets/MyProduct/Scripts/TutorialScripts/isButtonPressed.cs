using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isButtonPressed : MonoBehaviour
{
    [SerializeField] private Tutorial tutorialScript;
    public void ButtonisPressed()
    {
        tutorialScript.buttonPressed = true;
    }
}
