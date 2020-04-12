using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waypoint : MonoBehaviour
{
    public RectTransform prefab;

    private RectTransform waypoint;

    private Transform player;
    private Text distanceText;
    private float distance; // The distance from the player to a waypoint

    private bool waypointReached = false; // Whether the player has reached the current waypoint or not
    private bool nextWaypoint = false; // Enable/disable the display of the next waypoint
    private bool doNotUpdate = false; // Prevents the last waypoint from being enabled from the first floor

    // Moves the location of the waypoint to be slightly above the object it is attached to
    private Vector3 waypointPosOffset = new Vector3(0, 1.5f, 0); 

    // Allows the waypoint marker to be a dynamic prefab. Drag and drop the script on to a Game Object and then drag and drop
    // the Waypoint prefab on to the prefab tab in the Waypoint Script component box
    void Start()
    {
        var canvas = GameObject.Find("Waypoints").transform;

        waypoint = Instantiate(prefab, canvas);
        distanceText = waypoint.GetComponentInChildren<Text>();

        player = GameObject.Find("Player").transform;

        // COMMENT OUT TO TURN ON ALL WAYPOINTS FOR TESTING
        waypoint.gameObject.SetActive(false);
    }

    // Mark that the player has reached the current waypoint once they make it to the designated location
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //if (distance <= 4)
                waypointReached = true;

            Debug.Log("waypointReached " + waypointReached);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Calculates the position of the waypoint marker
        var screenPos = Camera.main.WorldToScreenPoint(transform.position + waypointPosOffset);
        waypoint.position = screenPos;

        // Calculates how far the player is from a waypoint marker and displays it as text rounded to the nearest integer below each one
        distance = Vector3.Distance(player.position, transform.position);
        distanceText.text = Vector3.Distance(player.position, transform.position).ToString("0") + "m";

        // HERE FOR TESTING
        //waypoint.gameObject.SetActive(screenPos.z > 0); // Gets rid of the waypoint marker if it's position is behind the player

        // Once a waypoint is reached disable it's visibility
        if (waypointReached == true)
            waypoint.gameObject.SetActive(false);

        // Check the distance from the starting location to the first waypoint and enable it
        if (waypointReached == false & (Mathf.RoundToInt(distance)) == 9) 
        {
            nextWaypoint = true;
        }

        // Check the distance from the first waypoint to the second waypoint and enable it and also distance from second
        // waypoint to the third waypoint
        else if (doNotUpdate == false & waypointReached == false & (Mathf.RoundToInt(distance)) == 46) 
        {
            nextWaypoint = true;
        }

        // Check the distance from the third waypoint to the fourth waypoint and enable it
        // Once player steps outside after reaching fourth waypoint, last waypoint should appear
        else if (doNotUpdate == false & waypointReached == false & (Mathf.RoundToInt(distance)) == 36)
        {
            nextWaypoint = true;
        }

        // This is here because when the player is going down the first floor hallway, the distance that
        // they can be from the last waypoint is 46m or 47m. Both of these distances are used to trigger
        // the 2nd and 3rd waypoints so when the last waypoint is in this range, its visibility gets 
        // triggered early.
        else if ((Mathf.RoundToInt(distance)) > 50 | (Mathf.RoundToInt(distance)) == 18) // Enable doNotUpdate on last and 2nd to last waypoints when player makes it to first waypoint
        {
            doNotUpdate = true;
        }
        // Allows the 2nd to last waypoint to be updated once it passes 36m from player on way to 2nd waypoint
        else if ((Mathf.RoundToInt(distance)) == 37)
        {
            doNotUpdate = false;
        }

        // While nextWaypoint is enabled, keep displaying the next waypoint's location
        if (nextWaypoint == true)
        {
            waypoint.gameObject.SetActive(true);
            waypoint.gameObject.SetActive(screenPos.z > 0); // Gets rid of the waypoint marker if it's position is behind the player

            if (waypointReached == true)
                nextWaypoint = false;
        }
    }
}
