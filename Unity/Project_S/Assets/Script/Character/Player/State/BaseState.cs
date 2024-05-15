using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState
{
    public abstract void OnAwake();

    public abstract void OnEnter();

    public abstract void OnUpdate();

    public abstract void OnFixedUpdate();

    public abstract void OnExit();
}
