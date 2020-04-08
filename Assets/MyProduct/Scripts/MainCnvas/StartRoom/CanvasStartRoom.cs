using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasStartRoom : MonoBehaviour
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
                canvasText.text = "For safe practices, always keep an emergency exit route posted near the door.";
                prevButton += 1;
            }
            if (buttonPressCount == 1 && prevButton == 1)
            {
                canvasText.text = "Remember: In the event of a fire, always take the stairs!";
                prevButton += 1;
            }
            if (buttonPressCount == 2 && prevButton == 2)
            {
                canvasText.text = "Proceed cautiously to the stairs.\n Follow the Exit/Stair signs.";
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
