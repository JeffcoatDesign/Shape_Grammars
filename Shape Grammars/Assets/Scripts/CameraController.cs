using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 10f;
    public float sprintSpeed = 100f;
    public float sensitivity;
    private bool isLooking = false;

    // Update is called once per frame
    void Update()
    {
        bool sprint = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        float movementSpeed = sprint ? sprintSpeed : speed;
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + (-transform.right * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + (transform.right * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + (-transform.forward * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + (transform.forward * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position = transform.position + (transform.up * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.position = transform.position + (-transform.up * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.position = transform.position + (Vector3.up * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.position = transform.position + (-Vector3.up * movementSpeed * Time.deltaTime);
        }
        if (isLooking)
        {
            float newRotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
            float newRotationY = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * sensitivity;
            transform.localEulerAngles = new Vector3(newRotationY, newRotationX, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            StartLooking();
        }
        else if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            StopLooking();
        }
    }

    private void StopLooking()
    {
        isLooking = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void StartLooking()
    {
        isLooking = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
