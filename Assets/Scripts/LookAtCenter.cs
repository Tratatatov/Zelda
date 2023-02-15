using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCenter : MonoBehaviour
{
    void Update()
    {
        transform.up = Vector3.zero - transform.position;
    }
}
