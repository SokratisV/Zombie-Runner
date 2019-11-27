using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera m_camera;
    [SerializeField] RigidbodyFirstPersonController controller;
    [SerializeField] float zoomInFOV = 20f, normalFOV = 60f, zoomInSensitivity = .5f, normalSensitivity = 2f;

    bool zoomToggle = false;

    private void OnDisable()
    {
        ZoomOut();
        zoomToggle = false;
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
            ZoomOut();
        }
        else
        {
            ZoomIn();
        }
        zoomToggle = !zoomToggle;
    }

    private void ZoomIn()
    {
        m_camera.fieldOfView = zoomInFOV;
        controller.mouseLook.XSensitivity = zoomInSensitivity;
        controller.mouseLook.YSensitivity = zoomInSensitivity;
    }

    private void ZoomOut()
    {
        m_camera.fieldOfView = normalFOV;
        controller.mouseLook.XSensitivity = normalSensitivity;
        controller.mouseLook.YSensitivity = normalSensitivity;
    }
}
