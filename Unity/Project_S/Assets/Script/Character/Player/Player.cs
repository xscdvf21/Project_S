using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Player_ItemData items;
    public Player_AbilityData ability;
    public Player_SkillData skill;
    public Player_BoneData bone;
    // Start is called before the first frame update
    private void Awake()
    {


    }

    private void OnEnable()
    {

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnUpdate()
    {
    
    }

    public void OnFixedUpdate()
    {
      
    }
    private void FixedUpdate()
    {


    }

    private void OnDisable()
    {


    }
    public void Init()
    {
        //keyInput = new Player_KeyInput();
        bone.SetItem();
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
    /// 현재 적용되어있는 스킬
    /// </summary>
    /// 같은것은 하나만 가능
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
        int level;

        public int damage;
        public float attackSpeed;

        public int exp;
        public int maxExp;

        public int hp;
        public int maxHp;

        public int mana;
        public int maxMana;

        public float moveSpeed;

        public void AddExp(int _exp)
        {
            exp += _exp;

            if (exp >= maxExp)
                LevelUp();
         
        }

        public void LevelUp()
        {
            if (exp < maxExp)
                return;

            level++;
            exp -= maxExp;
        }

    }


    [Serializable]
    public class Player_BoneData
    {
        public List<SpriteRenderer> itemBones;
       
        public void SetItem()
        {

        }
       
    }


    [Serializable]
    public class Player_ItemData
    {
        public Item_Weapon weapon;
        public Item_Helmet helmet;
        public Item_Armor armor;
        public Item_Back back;
        public Item_Gloves gloves;
        public Item_Foot foot;
    }
  
}
