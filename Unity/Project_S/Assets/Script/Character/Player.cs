using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Player_AbilityData ability;
    public Player_SkillData skill;
    public Player_BoneData bone;

    // Start is called before the first frame update
    private void Awake()
    {
        InitSkill();

    }

    private void OnEnable()
    {

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {


    }

    private void OnDisable()
    {


    }
    void InitSkill()
    {
         
       
    }

    public void Add_Skill(PLAYER_SKILL _type)
    {
        if (skill == null)
            skill = new Player_SkillData();

        GameObject clone = Instantiate(Skill_Mgr.Instance.player_Skill.GetSkill(_type).gameObject);
        clone.transform.SetParent(this.transform.Find("Skill"), false);

        skill.AddSkill(_type, clone.GetComponent<BaseSkill>());

    }

    /// <summary>
    /// ���� ����Ǿ��ִ� ��ų
    /// </summary>
    /// �������� �ϳ��� ����
    [Serializable]
    public class Player_SkillData
    {

        public List<Skill> list_Skill;

        public void AddSkill(PLAYER_SKILL _type, BaseSkill _skill)
        {
            for(int i = 0; i < list_Skill.Count; ++i)
            {
                if (list_Skill[i].skillType == _type)
                    return;
            }

            Skill skill = new Skill();

            skill.skillType = _type;
            skill.skill = _skill;

            list_Skill.Add(skill);
        }

        public void RemoveSkill(PLAYER_SKILL _type)
        {
            for (int i = 0; i < list_Skill.Count; ++i)
            {
                if (list_Skill[i].skillType == _type)
                {
                    list_Skill.RemoveAt(i);
                    return;
                }
            }

        }


        [Serializable]
        public class Skill
        {
            public PLAYER_SKILL skillType;
            public BaseSkill skill;
        }
    }



    [Serializable]
    public class Player_AbilityData
    {
        public int attack;
        public int hp;
        public int maxHp;
        public int mana;
        public int maxMana;
        public float moveSpeed;
    }


    [Serializable]
    public class Player_BoneData
    {
        public List<SpriteRenderer> itemBones;
        

       
    }
}