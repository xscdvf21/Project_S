using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Skill : MonoBehaviour
{
    public List<BaseSkill> skills;

    private void Awake()
    {
        
    }


    public BaseSkill GetSkill(PLAYER_SKILL _type)
    {
        if ((int)_type > skills.Count - 1)
            return null;

        return skills[(int)_type];
    }
}
