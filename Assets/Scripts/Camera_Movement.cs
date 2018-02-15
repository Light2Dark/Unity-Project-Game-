using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour {
    // Camera control to be the center of 2 players
    // TODO: Center it within 3/4 players

    public Transform player1, player2;
    public Vector3 offset;
	
	// Update is called once per frame
	void LateUpdate () {
       
        Vector3 center = (player2.position - player1.position) / 2;
        this.transform.position = player1.position + center + offset;
	}
}
