using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Skill_GuidedArrow : BaseSkill
{
    [SerializeField] PLAYER_SKILL eType;


    public override void OnAwakeState()
    {
        Debug.Log("���̵� �ַο� ��ų ����");
    }

    public override void OnEnterState()
    {
        Debug.Log("���̵� �ַο� ��ų ����");
    }

    public override void OnExitState()
    {
        Debug.Log("���̵� �ַο� ��ų ����");
    }

    public override void OnFixedUpdateState()
    {
        Debug.Log("���̵� �ַο� �Ƚõ� ������Ʈ");
    }

    public override void OnUpdateState()
    {
        Debug.Log("���̵� �ַο� ������Ʈ");
    }


}
