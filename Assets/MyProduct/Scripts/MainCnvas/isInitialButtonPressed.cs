using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isInitialButtonPressed : MonoBehaviour
{
    [SerializeField] public initial mainScript;
    public void ContinuePressed()
    {
        mainScript.init_continueCount += 1;
    }
}
