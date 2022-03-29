using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPresencePhysic : MonoBehaviour
{
    private Rigidbody _rb;
    public Transform target;
    public Renderer nonPhysicalHands;
    public float showNonPhysicalHandsDistance = 0.05f;
    private Collider[] handColliders;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        /*float distance = Vector3.Distance(transform.position, target.position);
        if (distance>showNonPhysicalHandsDistance)
        {
            nonPhysicalHands.enabled = true;
            
        }
        else
        {
            nonPhysicalHands.enabled = false;
            
        }*/
        
    }

    public void EnableHandCollider()
    {
        foreach (var collider in handColliders)
        {
            collider.enabled = true;
        }
    }

    public void DelayEnableCollider(float delay)
    {
        Invoke(nameof(EnableHandCollider),delay);
    }

    public void DisableHandCollider()
    {
        foreach (var collider in handColliders)
        {
            collider.enabled = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //position
    
        _rb.velocity = (target.position - transform.position) / Time.fixedDeltaTime;
        
        //rotation
        Quaternion differanceInRotation = target.rotation * Quaternion.Inverse(transform.rotation);
        differanceInRotation.ToAngleAxis(out float angleInDegree,out Vector3 rotationAxis);

        Vector3 rotationDifferanceInDegree = angleInDegree * rotationAxis;

        _rb.angularVelocity=(rotationDifferanceInDegree * Mathf.Deg2Rad / Time.fixedDeltaTime);



    }
}
