using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Ply2 : MonoBehaviour {

    public Rigidbody playerRb;
    public float upDownMovement, leftRightMovement, maxSpeed;

    void FixedUpdate () {

        // Below is code for one keyboard 2 players for TESTING
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRb.AddForce(0, 0, upDownMovement * Time.deltaTime);
            playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, maxSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRb.AddForce(leftRightMovement * Time.deltaTime, 0, 0);
            playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, maxSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRb.AddForce(0, 0, -upDownMovement * Time.deltaTime);
            playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, maxSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRb.AddForce(-leftRightMovement * Time.deltaTime, 0, 0);
            playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, maxSpeed);
        }
    }
}
