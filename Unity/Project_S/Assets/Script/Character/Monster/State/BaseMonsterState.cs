using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMonsterState
{

    public abstract void OnAwake();

    public abstract void OnEnter();

    public abstract void OnUpdate();

    public abstract void OnFixedUpdate();

    public abstract void OnExit();
    // Start is called before the first frame update

}
