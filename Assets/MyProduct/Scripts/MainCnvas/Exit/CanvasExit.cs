using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasExit : MonoBehaviour
{
    public int buttonPressCount = 0;
    public Canvas myCanvas;
    public TextMeshProUGUI canvasText;
    private int prevButton = 0;


    // Start is called before the first frame update
    void Start()
    {
        myCanvas.enabled = false;
        canvasText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(myCanvas.enabled);
        if (myCanvas.enabled)
        {
            if (buttonPressCount == 0 && prevButton == 0)
            {
                canvasText.text = "Remember: Before proceeding through any closed doors, check the temperature of the door handle. ";
                prevButton += 1;
            }
            if (buttonPressCount == 1 && prevButton == 1)
            {
                canvasText.text = "You determine that this door is safe to travel through. ";
                prevButton += 1;
            }
            if (buttonPressCount == 2 && prevButton == 2)
            {
                canvasText.text = "Once you outside, walk a safe distance away from the building and call emergency personnel.";
                prevButton += 1;
            }
            if (buttonPressCount == 3 && prevButton == 3)
            {
                myCanvas.enabled = false;
                buttonPressCount = 0;
                prevButton = 0;
            }
        }
    }
}
