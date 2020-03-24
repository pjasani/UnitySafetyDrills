using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorial : MonoBehaviour
{
    public int interactionCount = 0;
    public bool buttonPressed = false;
    public TextMeshProUGUI myText;
    private Time temp;


    void Start()
    {
        myText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(buttonPressed == false)
        { 
            myText.text = "Instuctions \n 1. Look Donw to walk \n 2. Press the Button to interact with the cube. \n\n Objective \n Convert all the red cubes to green by interacting with them.\n Total interactions : " + interactionCount.ToString() + "/8";
        }else if (buttonPressed == true && interactionCount == 8)
        {
            myText.text = "Congratulations!!! \n you have completed the tutorial. \n You may now pass though the door.";
        }
        else
        {
            buttonPressed = false;
        }
    }
}
