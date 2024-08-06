using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _acceleration; // Beschleunigung
    private float _steering; // Drehung

    public float AccelerationSpeed = 3f;
    public float Steeringspeed = 3;

    public Rigidbody2D Rigidbody;

    private void Update()
    {
        _acceleration = Mathf.Max(0, Input.GetAxis("Vertical"));
        _steering = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Rigidbody.AddRelativeForce(new Vector2(0, _acceleration * AccelerationSpeed));
        Rigidbody.AddTorque(-_steering * Steeringspeed);
    }
}
