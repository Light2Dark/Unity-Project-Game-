using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody playerRb;
    public float upDownMovement, leftRightMovement, maxSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        // Below is the proper code for movement using one keyboard for one player.
        /*
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                playerRb.AddForce(0, 0, upDownMovement * Time.deltaTime);
                playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, maxSpeed);
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                playerRb.AddForce(leftRightMovement * Time.deltaTime, 0, 0);
                playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, maxSpeed);
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                playerRb.AddForce(0, 0, -upDownMovement * Time.deltaTime);
                playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, maxSpeed);
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                playerRb.AddForce(-leftRightMovement * Time.deltaTime, 0, 0);
                playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, maxSpeed);
            } 
        */

        // Below is code for one keyboard 2 players for TESTING
        if (Input.GetKey(KeyCode.W))
        {
            playerRb.AddForce(0, 0, upDownMovement * Time.deltaTime);
            playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, maxSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerRb.AddForce(leftRightMovement * Time.deltaTime, 0, 0);
            playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, maxSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            playerRb.AddForce(0, 0, -upDownMovement * Time.deltaTime);
            playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, maxSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerRb.AddForce(-leftRightMovement * Time.deltaTime, 0, 0);
            playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, maxSpeed);
        }
    }

}
