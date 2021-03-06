using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //player rigidbody
    public Rigidbody playerCube;

    //force that pushed our player forward
    public float forwardForce = 1000f;
    //force that pushed our player sideways
    public float sidewaysForce = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerCube.AddForce(0, 0, forwardForce * Time.deltaTime);

        //if we press the d key
        if(Input.GetKey("d") )
        {
            //we push our player to the right using the sidewaysForce
            playerCube.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a") )
        {
            //we push our player to the right using the sidewaysForce
            playerCube.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(playerCube.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
