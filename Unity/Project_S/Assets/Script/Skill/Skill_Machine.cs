using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 플레이어가 선택한 스킬들 보관 및 삭제
/// </summary>
public class Skill_Machine
{
    
    public Dictionary<PLAYER_SKILL, BaseSkill> dic_Skill = new Dictionary<PLAYER_SKILL, BaseSkill>();

    public Skill_Machine()
    {

    }
    public void AddSkill(PLAYER_SKILL _key, BaseSkill _skill)
    {
        if(!dic_Skill.ContainsKey(_key))
        {
            dic_Skill.Add(_key, _skill);
            _skill.OnAwakeState();
        }
    }

    public void DeleteSkill(PLAYER_SKILL _key)
    {
        if (dic_Skill.ContainsKey(_key))
            dic_Skill.Remove(_key);
    }
}
