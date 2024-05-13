using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Skill_GuidedArrow : BaseSkill
{
    [SerializeField] PLAYER_SKILL eType;


    public override void OnAwakeState()
    {
        Debug.Log("가이드 애로우 스킬 생성");
    }

    public override void OnEnterState()
    {
        Debug.Log("가이드 애로우 스킬 진입");
    }

    public override void OnExitState()
    {
        Debug.Log("가이드 애로우 스킬 삭제");
    }

    public override void OnFixedUpdateState()
    {
        Debug.Log("가이드 애로우 픽시드 업데이트");
    }

    public override void OnUpdateState()
    {
        Debug.Log("가이드 애로우 업데이트");
    }


}
