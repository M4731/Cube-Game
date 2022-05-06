using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;

    //The position between the camera and the player
    public Vector3 CameraDistance;

    // Update is called once per frame
    void Update()
    {
        //This script makes the camera follow the player while keeping a "CameraDistance"(XYZ coordinates) from the center of the player object
        transform.position = Player.position + CameraDistance;
    }
}
