using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public int interactionCount = 0;
    public bool retryPressed = false;
    public TextMeshProUGUI myText;
    public Button retryButton;
    public Button continueButton;
    public int buttonPressCount = 0;
    public MeshRenderer cube1;
    public MeshRenderer cube2;
    public MeshRenderer cube3;
    public MeshRenderer cube4;
    public MeshRenderer cube5;
    public MeshRenderer cube6;
    public MeshRenderer cube7;
    public MeshRenderer cube8;

    void Start()
    {
        myText = GetComponent<TextMeshProUGUI>();
        retryButton.interactable = false;
        continueButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (retryPressed == true)
        {
            //Reset reset the colors of all the cubes
            cube1.material.color = Color.red;
            cube2.material.color = Color.red;
            cube3.material.color = Color.red;
            cube4.material.color = Color.red;
            cube5.material.color = Color.red;
            cube6.material.color = Color.red;
            cube7.material.color = Color.red;
            cube8.material.color = Color.red;

            //reset interact count
            interactionCount = 0;
            //set retry false
            retryPressed = false;
            retryButton.interactable = false;
            continueButton.interactable = false;
            buttonPressCount = 0;

        }
        if (buttonPressCount == 0 )
        { 
            myText.text = "Instuctions \n 1. Look Down to walk \n 2. Press the Button to interact with the cube. \n\n Objective \n Convert all the red cubes to green by interacting with them.\n Total interactions : " + interactionCount.ToString() + "/8";
        }
        if(interactionCount == 8)
        {
            continueButton.interactable = true;
        }
        if (buttonPressCount == 1 && interactionCount == 8)
        {
            myText.text = "Congratulations!!! \n you have completed the tutorial. \n\n Click continue to quit \n Click retry to redo tutorial";
            retryButton.interactable = true;
        }
        if(buttonPressCount == 2)
        {
            SceneManager.LoadScene("Main");
        }
    }
}
