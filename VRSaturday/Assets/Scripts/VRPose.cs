using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//World position of headset and controllers are referred to as "poses"

public class VRPose : MonoBehaviour
{
    class PoseTransform
    {
        public Quaternion rotation = Quaternion.identity;
        public Vector3 position = Vector3.zero;
    }

    //refers to an action in the InputSystem
    public InputActionReference positionAction;
    public InputActionReference rotationAction;

    bool isSetup;

    public void SetUp ()
    {
        isSetup = true;
    }

    void FixedUpdate()
    {
        if (!isSetup)
            return;

        PoseTransform pose = GetPose();
        transform.position = pose.position;
        transform.rotation = pose.rotation;
    }

    PoseTransform GetPose ()
    {
        PoseTransform pose = new PoseTransform();
        pose.position = positionAction.action.ReadValue<Vector3>();
        pose.rotation = rotationAction.action.ReadValue<Quaternion>();
        return pose;
    }
}
