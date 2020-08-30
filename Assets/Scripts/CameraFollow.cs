﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform _objectToFollow = null;

    Vector3 _objectOffset;

    private void Awake()
    {
        // Create an offset between this position and the object's position
        _objectOffset = this.transform.position - _objectToFollow.position;
    }

    // Happens after Update. Camera should ALWAYS move last
    private void LateUpdate()
    {
        // Apply yhe offset every frame, to reposition this object
        this.transform.position = _objectToFollow.position + _objectOffset;
    }
}