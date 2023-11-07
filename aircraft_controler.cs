using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1.0f;  
    public float rotationSpeed = 3.0f;
    public float verticalSpeed = 1.0f;
    public float pitchSpeed = 20.0f;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 forwardMovement = transform.forward * moveSpeed * Time.deltaTime;
        transform.Translate(forwardMovement);

        float turnMovement = horizontalInput * rotationSpeed * Time.deltaTime;
        Vector3 newTurnPosition = transform.position + new Vector3(turnMovement, 0, 0);
        transform.position = newTurnPosition;

        float verticalMovement = verticalInput * verticalSpeed * Time.deltaTime;
        Vector3 newPosition = transform.position + new Vector3(0, verticalMovement, 0);
        transform.position = newPosition;

        float pitchAmount = -verticalInput * pitchSpeed * Time.deltaTime;
        float pitchTurn = -horizontalInput * pitchSpeed * Time.deltaTime;
        Vector3 newEulerAngles = transform.eulerAngles + new Vector3(pitchAmount, 0, pitchTurn);
        transform.eulerAngles = newEulerAngles;
    }
}