using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option_i_rolling : MonoBehaviour
{
    public float rotate_s = 1.0f;
    void Update()
    {
        transform.Rotate(0, 0, this.rotate_s);
    }
}
