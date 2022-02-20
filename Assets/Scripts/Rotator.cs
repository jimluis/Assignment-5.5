using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    [SerializeField]
    [Tooltip("The axis around which the gameObject is rotating")]
    private Vector3 rotationAxis = Vector3.up;

    [SerializeField]
    [Tooltip("The speed which the gameObject is rotating. Measured in angles")]
    private float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed);
    }
}
