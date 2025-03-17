using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTrailPainter : MonoBehaviour
{
    private Camera mainCamera;
    private TrailRenderer trail;

    void Start()
    {
        mainCamera = Camera.main;
        trail = GetComponent<TrailRenderer>();
        trail.emitting = false; // Start with trail disabled
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button pressed
        {
            trail.emitting = true;
        }
        else if (Input.GetMouseButtonUp(0)) // Left mouse button released
        {
            trail.emitting = false;
        }

        if (trail.emitting)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f; // Distance from camera
            Vector3 worldPos = mainCamera.ScreenToWorldPoint(mousePos);
            transform.position = worldPos;
        }
    }
}

