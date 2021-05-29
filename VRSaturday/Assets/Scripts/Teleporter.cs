using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    private VRRig rig;
    
    private void Start()
    {
        rig = FindObjectOfType<VRRig>();
        VRInput[] inputs = FindObjectsOfType<VRInput>();
        
        foreach(VRInput vrInput in inputs)
        {
            vrInput.onTeleported.AddListener(OnTeleported);
        }
    }

    private void OnTeleported(Vector3 _position)
    {
        rig.PlayArea.position = _position;
    }
}
