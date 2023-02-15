using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour, IMovable
{
    [SerializeField] float _rotationSpeed = 5f;
    public void Move()
    {
        transform.Rotate(Vector3.forward*_rotationSpeed*Time.deltaTime);
    }
    private void Update()
    {
        Move();
    }
}
