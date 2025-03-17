using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailThickness : MonoBehaviour
{
    public float minWidth = 0.2f;
    public float maxWidth = 0.6f;

    private TrailRenderer trail;

    void Start()
    {
        trail = GetComponent<TrailRenderer>();

        AnimationCurve curve = new AnimationCurve();
        curve.AddKey(0f, Random.Range(minWidth, maxWidth)); // Start width
        curve.AddKey(1f, Random.Range(minWidth, maxWidth)); // End width
        trail.widthCurve = curve;
    }
    
}
