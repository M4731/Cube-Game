using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerCube;

    // Start is called before the first frame update
    void Start()
    {
        //playerCube.useGravity = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerCube.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
