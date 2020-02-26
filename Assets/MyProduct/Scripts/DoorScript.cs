using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    private Animator animator; // Door animation object

    bool atDoor = false; // Whether the user is near the door 

    public GameObject instructions; // Pop up text to interact with door
    

    // Used for initialization
    void Start()
    {
        animator = GetComponent<Animator>(); // Initalize the door animation object
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; ++i)
        {
            Touch t = Input.GetTouch(i);
            if (atDoor == true && t.phase == TouchPhase.Began) // If the person is at the door and inputs a button press, the door will open/close
            {
                animator.SetTrigger("OpenDoor"); // Trigger for door animation
            }
        }
    }

    // When the user is at the door, set the flag and display the interaction message
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") { // Check if the user has collided with the box collider trigger
            atDoor = true;
            instructions.SetActive(true);
            //animator.SetTrigger("OpenDoor"); // Used to trigger door animation without a button input
        }

    }

    // When the user walks away from the door, set the flag and remove the interaction message
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") // Check if the user is leaving the box collider trigger
        {
            atDoor = false;
            instructions.SetActive(false);
            //animator.SetTrigger("OpenDoor"); // Used to trigger door animation without a button input
        }
    }
}
