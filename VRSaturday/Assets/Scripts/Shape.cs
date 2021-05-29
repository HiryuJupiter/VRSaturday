using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public int width = 5;
    public int height = 6;

    void Start()
    {
        transform.localScale = new Vector3(width, height, 1);
    }
}
