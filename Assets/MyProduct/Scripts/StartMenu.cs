using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public void ExitSimulation()
    {
        Debug.Log("Exiting Simulation..."); // To test that the method works in the editor
        Application.Quit(); // Exits the application on mobile device
    }
}
