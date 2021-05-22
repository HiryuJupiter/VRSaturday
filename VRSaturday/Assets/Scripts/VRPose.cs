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

    void FixedUpdate()
    {
        
    }

    
}
