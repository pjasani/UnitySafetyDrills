using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    private Animator animator; // Door animation object

    bool atDoor = false; // Whether the user is near the door 

    public GameObject instructions; // Pop up text to interact with door

    //public AudioSource source;
    //public AudioClip door;

    // Used for initialization
    void Start()
    {
        animator = GetComponent<Animator>(); // Initalize the door animation object
        //Debug.Log("animator: " + animator);
        //source = GetComponent<AudioSource>();
        instructions.SetActive(false); // Toggle the visibility of the popup to off initially
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount != 0)
        {
            for (int i = 0; i < Input.touchCount; ++i)
            {
                Touch t = Input.GetTouch(i);
                if (atDoor == true && t.phase == TouchPhase.Began) // If the person is at the door and inputs a button press, the door will open/close
                {
                    animator.SetTrigger("OpenDoor"); // Trigger for door animation
                    //source.Play();
                }
            }
        }

        // Here for Mouse + Keyboard testing
        else if (atDoor == true & Input.GetMouseButtonDown(0)) // If the person is at the door and inputs a button press, the door will open/close
        {
            //Debug.Log("Door should be opened");
            animator.SetTrigger("OpenDoor"); // Trigger for door animation
            //source.Play();
        }
    }

    // When the user is at the door, set the flag and display the interaction message
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") { // Check if the user has collided with the box collider trigger
            atDoor = true;
            //Debug.Log("atDoor: " + atDoor);
            instructions.SetActive(true); // Toggle the visibility of the popup to on
            //animator.SetTrigger("OpenDoor"); // Used to trigger door animation without a button input
        }

    }

    // When the user walks away from the door, set the flag and remove the interaction message
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") // Check if the user is leaving the box collider trigger
        {
            atDoor = false;
            instructions.SetActive(false); // Toggle the visibility of the popup to off
            //animator.SetTrigger("OpenDoor"); // Used to trigger door animation without a button input
        }
    }
}
