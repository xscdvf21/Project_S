using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Player_AbilityData ability;
    public Player_SkillData skill;
    public Player_BoneData bone;
    public Player_KeyInput keyInput;
    // Start is called before the first frame update
    private void Awake()
    {
        keyInput = new Player_KeyInput();
        Init();

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
        keyInput.KeyCheck();
    }
    private void FixedUpdate()
    {


    }

    private void OnDisable()
    {


    }
    void Init()
    {

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
       
        public void SetItem()
        {

        }
       
    }

    public class Player_Animation
    {

    }
    public class Player_KeyInput
    {
        public float moveDelay = 0.2f;
        public void KeyCheck()
        {
            
            //오른쪽으로 걷기
            if(Input.GetKey(KeyCode.RightArrow))
            {
                Object_Mgr.Instance.mainPlayer.transform.Translate(Vector3.right *1f * Time.deltaTime);
            }
            //왼쪽 걷기
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                Object_Mgr.Instance.mainPlayer.transform.Translate(Vector3.left * 1f * Time.deltaTime);

            }
            //위로걷기
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Object_Mgr.Instance.mainPlayer.transform.Translate(Vector3.up * 1f * Time.deltaTime);

            }
            //아래로걷기
            if (Input.GetKey(KeyCode.DownArrow))
            {
                Object_Mgr.Instance.mainPlayer.transform.Translate(Vector3.down * 1f * Time.deltaTime);

            }
        }
    }
}
