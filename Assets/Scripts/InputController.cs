using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private Attack _playerAttack;
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            _playerAttack.ToAttack();
        }
    }
    
}
