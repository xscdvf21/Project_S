using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSkill : MonoBehaviour
{
    //���� �ѹ�
    public abstract void OnAwakeState();
    //���� �� �۵�
    public abstract void OnEnterState();
    //������Ʈ �� ������ 
    public abstract void OnUpdateState();
    //���� ���, �� ������
    public abstract void OnFixedUpdateState();
    //���� ���� �� 
    public abstract void OnExitState();


}
