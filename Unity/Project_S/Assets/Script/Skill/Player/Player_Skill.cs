using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Skill : MonoBehaviour
{
    public List<ActiveSKill_Object> actives;
    public List<PassiveSkill_Object> passives;

    public Dictionary<ACTIVE_SKILL, ActiveSKill_Object> dic_Active;
    public Dictionary<PASSIVE_SKILL, PassiveSkill_Object> dic_Passive;


    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        for(int i = 0; i < actives.Count; ++i)
        {
            int iIndex = i;

            if (!dic_Active.ContainsKey(actives[iIndex].type))
                dic_Active.Add(actives[iIndex].type, actives[iIndex]);
        }

        for(int i = 0; i < passives.Count; ++i)
        {
            int iIndex = i;

            if (!dic_Passive.ContainsKey(passives[iIndex].type))
                dic_Passive.Add(passives[iIndex].type, passives[iIndex]);
        }


    }

    public ActiveSKill_Object GetActive(ACTIVE_SKILL _type)
    {
        if (dic_Active.TryGetValue(_type, out ActiveSKill_Object _result))
            return _result;

        return null;
    }

    public PassiveSkill_Object GetPassive(PASSIVE_SKILL _type)
    {
        if (dic_Passive.TryGetValue(_type, out PassiveSkill_Object _result))
            return _result;

        return null;
    }

}
