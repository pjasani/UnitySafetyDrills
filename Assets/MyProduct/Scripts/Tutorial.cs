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
            myText.text = "Convert all the red cubes to green by interacting with them.\n\n Total interactions : " + interactionCount.ToString() + "/6";
        }else if (buttonPressed == true && interactionCount == 6)
        {
            myText.text = "Congratulations!!! \n you have completed the tutorial. \n You may pass though the door now.";
        }
        else
        {
            buttonPressed = false;
        }
    }
}
