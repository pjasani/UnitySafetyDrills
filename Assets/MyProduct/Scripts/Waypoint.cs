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
    private float distance;

    private int count = 1;

    // Moves the location of the waypoint to be slightly above the object it is attached to
    private Vector3 waypointPosOffset = new Vector3(0, 3.5f, 0); 

    // Allows the waypoint marker to be a dynamic prefab. Drag and drop it onto Game Objects to add it as a component
    void Start()
    {
        var canvas = GameObject.Find("Waypoints").transform;

        waypoint = Instantiate(prefab, canvas);
        distanceText = waypoint.GetComponentInChildren<Text>();

        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculates the position of the waypoint marker
        var screenPos = Camera.main.WorldToScreenPoint(transform.position + waypointPosOffset);
        waypoint.position = screenPos;

        // Gets rid of the waypoint marker if it's position is behind the player 
        waypoint.gameObject.SetActive(screenPos.z > 0);

        // Calculates how far the player is from a waypoint marker and displays it as text rounded to the nearest integer below each one
        distance = Vector3.Distance(player.position, transform.position);
        distanceText.text = Vector3.Distance(player.position, transform.position).ToString("0") + "m";

        
        // NOTE: This method for enabling/disabling waypoints will give continuous errors while it is running 
        // because I am removing waypoints after the player gets to its location and the code continues to try
        // and reference them. This shouldn't cause any problems however.

        // When player is close to the waypoint, get rid of it
        if (distance < 5)
        {
            Destroy(waypoint.gameObject);
        }
        // When the waypoint is a certain distance away from the player, disable it
        else if (distance >= 30)
        {
            waypoint.gameObject.SetActive(false);
        }
        // Otherwise, when player gets in range of a waypoint, enable it
        else
        {
            waypoint.gameObject.SetActive(true);
            waypoint.gameObject.SetActive(screenPos.z > 0); // Gets rid of the waypoint marker if it's position is behind the player 
        }
    }
}
