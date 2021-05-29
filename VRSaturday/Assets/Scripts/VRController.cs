using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(VRInput))]
[RequireComponent(typeof(VRPose))]
public class VRController : MonoBehaviour
{
    public InputActionReference velocityAction;
    public InputActionReference angularVelocityAction;

    public Vector3 velocity;
    public Vector3 angularVelocity;

    public VRInput input;
    public VRPose pose;

    bool isSetUp;

    public void SetUp()
    {
        isSetUp = true;

        input = GetComponent<VRInput>();
        pose = GetComponent<VRPose>();
        input.Setup();
        pose.SetUp();
    }

    void FixedUpdate()
    {
        if(isSetUp)
        {
            velocity = velocityAction.action.ReadValue<Vector3>();
            angularVelocity= angularVelocityAction.action.ReadValue<Vector3>();
        }
    }
}
