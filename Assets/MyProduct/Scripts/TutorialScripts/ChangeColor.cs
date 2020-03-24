using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Tutorial tutorialScript;
    public void Green()
    {
        if (GetComponent<Renderer>().material.color != Color.green && tutorialScript.interactionCount <= 6)
        {
            tutorialScript.interactionCount += 1;
        }
        GetComponent<Renderer>().material.color = Color.green;
    }

}
