using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward + Vector3.right * variableJoystick.Horizontal;

        Debug.Log("J: " + variableJoystick.Horizontal);
        //Debug.Log("x: " + direction.x);
        //Debug.Log("y: " + direction.y);
        //Debug.Log("z: " + direction.z);
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
}