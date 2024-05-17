using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ActiveSKill_Data", menuName = "ProjectS/CreateSkill/Active", order = int.MaxValue)]
public class ActiveSKill_Object : ScriptableObject
{
    public ACTIVE_SKILL type;
    public float coolTime;

}
