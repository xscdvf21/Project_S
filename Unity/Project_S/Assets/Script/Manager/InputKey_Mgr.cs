using System;
using UnityEngine;
public class InputKey_Mgr : MonoBehaviour
{
    private static InputKey_Mgr instance;

    public static InputKey_Mgr Instance
    {
        get
        {
            return instance;
        }
    }

    public Action keyAction = null;
    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (Input.anyKey == false)
            return;

        if (keyAction != null)
            keyAction.Invoke();
    }


}

