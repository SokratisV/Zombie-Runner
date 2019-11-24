using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera m_camera;
    [SerializeField] float zoomInFOV = 20f, normalFOV = 60f, zoomInSensitivity = .5f, normalSensitivity = 2f;

    bool zoomToggle = false;
    RigidbodyFirstPersonController controller;

    private void Start()
    {
        m_camera = Camera.main;
        controller = GetComponent<RigidbodyFirstPersonController>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            ToggleZoom();
        }
    }

    private void ToggleZoom()
    {
        if (zoomToggle)
        {
            m_camera.fieldOfView = normalFOV;
            controller.mouseLook.XSensitivity = normalSensitivity;
            controller.mouseLook.YSensitivity = normalSensitivity;
        }
        else
        {
            m_camera.fieldOfView = zoomInFOV;
            controller.mouseLook.XSensitivity = zoomInSensitivity;
            controller.mouseLook.YSensitivity = zoomInSensitivity;
        }
        zoomToggle = !zoomToggle;
    }
}
