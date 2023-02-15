using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAttack : MonoBehaviour
{
    public AnimationCurve curve;
    public AnimationClip clip;

    void Start()
    {
        AddKeys();
    }

    // Update is called once per frame
    void Update()
    {
        clip.SetCurve("",typeof(Transform),"position.x",curve);

    }

    void AddKeys()
    {
        curve.AddKey(0, 0);
        curve.AddKey(6, 2.3f);
        curve.AddKey(10, 2.5f);
        curve.AddKey(16, -0.27f);
        curve.AddKey(24, 0);
        curve.AddKey(32, 0.1f);
        curve.AddKey(40, 0);
    }
}
