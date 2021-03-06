using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VRRig : MonoBehaviour
{
    public VRController left;
    public VRController right;
    public VRPose HMD;
    public Transform PlayArea;

    void Start()
    {
        HMD.SetUp();

        left.SetUp();
        right.SetUp();
    }
}
