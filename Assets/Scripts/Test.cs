using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField] Spawner spawner;
    [SerializeField] Text testText;
    [SerializeField] LineRenderer _lineRenderer;
    [SerializeField] Attack _attack;
    [SerializeField] PlayerMovement _playerMovement;

    // Target Debug
    [SerializeField] Transform _firepoint;
    [SerializeField] Vector2 target;
    void Start()
    {
        
    }

    void Update()
    {
        Detect();
        DrawLine();
    }
    void DrawLine()
    {
            _lineRenderer.SetPosition(0, _attack.Firepoint.position);
            _lineRenderer.SetPosition(1, target);
    }
    void Detect()
    {
        RaycastHit2D hit = Physics2D.Raycast(_firepoint.position, _firepoint.up,_playerMovement.Radius);
        if (hit.collider != null)
        {
            //target = hit.collider.transform.position;
            target = hit.point;
            testText.text = hit.collider.name;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(Vector3.zero, spawner.Radius);
    }
}
