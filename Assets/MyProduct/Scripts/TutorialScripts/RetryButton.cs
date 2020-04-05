using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryButton : MonoBehaviour
{
    [SerializeField] private Tutorial tutorialScript;
    public void RetryPressed()
    {
        tutorialScript.retryPressed = true;
    }
}
