using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseRotation : MonoBehaviour
{
    [SerializeField] private float mouseSensivity = 100f;
    [SerializeField] private Transform player;
    [SerializeField] private float xRotation = 0f;
    [SerializeField] private Transform mainCamera;

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        mainCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
} 


