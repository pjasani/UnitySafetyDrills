using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasTopStairs : MonoBehaviour
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
        Debug.Log(myCanvas.enabled);
        if (myCanvas.enabled)
        {
            if (buttonPressCount == 0 && prevButton == 0)
            {
                canvasText.text = "Remember: In the event of an emergency, always take the stairs instead of elevator. ";
                prevButton += 1;
            }
            if (buttonPressCount == 1 && prevButton == 1)
            {
                canvasText.text = "Your planned emergency exit route tells you that the nearest exit is at the bottom of this staircase. ";
                prevButton += 1;
            }
            if (buttonPressCount == 2 && prevButton == 2)
            {
                canvasText.text = "Remember to proceed with caution, because the staircase might block your view of any potential hazards.";
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
