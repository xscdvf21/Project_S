using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect_Mgr : MonoBehaviour
{
    private static Effect_Mgr instance = null;

    public static Effect_Mgr Instance
    {
        get
        {
            return instance;
        }
    }
    public Dictionary<EFFECT_TYPE, EffectPool> dic_Effect;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Serializable]
    public class EffectPool
    {
        Queue<GameObject> qeueue;
    }


}
