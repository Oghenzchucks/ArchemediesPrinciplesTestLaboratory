using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragObject : MonoBehaviour
{
    CharacterController characterController;
    public float speed = 6.0f;
    private Vector3 moveDirection = Vector3.zero;
    //movement speed in units per second
    private float movementSpeed = 5f;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void move()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Mouse X");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Mouse Y");

        //update the position
        //transform.position = transform.position + new Vector3(0, verticalInput * movementSpeed * Time.deltaTime, horizontalInput * movementSpeed * Time.deltaTime);

        // moves with translate
        //transform.Translate(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0, Camera.main.transform);

        //characterController.Move(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0, Camera.main.transform);

        moveDirection = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
        moveDirection *= speed;

        characterController.Move(moveDirection * Time.deltaTime);

        //output to log the position change
        Debug.Log(transform.position);
    }

    void OnMouseDrag()
    {
        move();
    }

    // void Update()
    // {
    //     transform.Translate(0, 0, 0, Camera.main.transform);
    // }
}
