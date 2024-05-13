using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSkill : MonoBehaviour
{
    //최초 한번
    public abstract void OnAwakeState();
    //진입 시 작동
    public abstract void OnEnterState();
    //업데이트 매 프레임 
    public abstract void OnUpdateState();
    //물리 기반, 매 프레임
    public abstract void OnFixedUpdateState();
    //상태 종료 시 
    public abstract void OnExitState();


}
