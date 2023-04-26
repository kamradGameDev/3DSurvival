using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private float speedScrollFieldOfView;
    [SerializeField] private float minViewField, maxViewField;
    public Camera Camera => mainCamera;
    [SerializeField] private Transform target;

    [SerializeField] private Vector3 offset;
    private void Start() =>
        SystemEvents.EventRotatePlayerHead += NewEulerRotateHeadPlayer;

    private void NewEulerRotateHeadPlayer(Vector3 newEulerRotateHeadPlayer) =>
        mainCamera.transform.eulerAngles = newEulerRotateHeadPlayer;

    private void LateUpdate()
    {
        Debug.Log("CameraController LateUpdate");
        mainCamera.transform.position = target.position + offset;

        float mouseScroll = Input.GetAxis("Mouse ScrollWheel");

        mainCamera.fieldOfView -= mouseScroll * speedScrollFieldOfView;

        if(mainCamera.fieldOfView > maxViewField)
            mainCamera.fieldOfView = maxViewField;

        else if(mainCamera.fieldOfView < minViewField)
            mainCamera.fieldOfView = minViewField;
    }
}
