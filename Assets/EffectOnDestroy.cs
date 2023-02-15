using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectOnDestroy : MonoBehaviour
{
    [SerializeField] GameObject _particleSystem;
    void PlayEffect()
    {
        GameObject newSystem = Instantiate(_particleSystem, transform.position, Quaternion.identity);
    }
    private void OnDisable()
    {
        PlayEffect();
    }
}
