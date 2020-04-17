using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class initial : MonoBehaviour
{
    //public  AudioSource source;
    //public AudioClip alarm;
    public TextMeshProUGUI canvasText;
    public Canvas myCanvas;
    public int init_continueCount = 0;
    private int prevButton = 0;
    
void Start()
    {
        canvasText = GetComponent<TextMeshProUGUI>();
        // source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (myCanvas.enabled)
        {

            if (init_continueCount == 0 && prevButton == 0)
            {
                canvasText.text = "When a fire accurs your first warning will most often be a fire/smoke alarm.";
                prevButton += 1;
            }
            if (init_continueCount == 1 && prevButton == 1)
            {
                canvasText.text = "When you hear the alarm. \n DO NOT PANIC!!!.";
                prevButton += 1;
            }
            if (init_continueCount == 2 && prevButton == 2)
            {
                canvasText.text = "Calmly gather all the people in the room and proceed to the door.";
                prevButton += 1;
            }
            if (init_continueCount == 3 && prevButton == 3)
            {
                myCanvas.enabled = false;
                //source.Play();
            }
        }
    }
}
