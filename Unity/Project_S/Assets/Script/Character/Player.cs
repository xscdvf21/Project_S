using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    [SerializeField] List<Skill> list_Skill;
    // Start is called before the first frame update
    private void Awake()
    {
        InitSkill();

        foreach (var item in list_Skill)
            item.skill.OnAwakeState();
    }

    private void OnEnable()
    {
        foreach (var item in list_Skill)
            item.skill.OnEnterState();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        foreach (var item in list_Skill)
            item.skill.OnUpdateState();
    }

    private void FixedUpdate()
    {

        foreach (var item in list_Skill)
            item.skill.OnFixedUpdateState();
    }

    private void OnDisable()
    {
        foreach (var item in list_Skill)
            item.skill.OnExitState();

    }
    void InitSkill()
    {
        list_Skill = new List<Skill>();
        list_Skill.Add(Add_Skill(PLAYER_SKILL.GUIDED_ARROW));
       
    }

    Skill Add_Skill(PLAYER_SKILL _type)
    {
        GameObject clone = Instantiate(Skill_Mgr.Instance.player_Skill.GetSkill(_type).gameObject);
        clone.transform.SetParent(this.transform.Find("Skill"), false);
        
        Skill result = new Skill(_type, clone.GetComponent<BaseSkill>());
        return result;
    }

    /// <summary>
    /// 현재 적용되어있는 스킬
    /// </summary>
    [Serializable]
    public class Skill
    {
        public PLAYER_SKILL skillType;
        public BaseSkill skill;

        public Skill(PLAYER_SKILL _type, BaseSkill _skill)
        {
            skillType = _type;
            skill = _skill;
        }
    }

}
