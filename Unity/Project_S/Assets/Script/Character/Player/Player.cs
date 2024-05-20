using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Player : MonoBehaviour
{
    public Player_ItemData items = new Player_ItemData();
    public Player_AbilityData ability = new Player_AbilityData();
    public Player_SkillData skill = new Player_SkillData();

    // Start is called before the first frame update
    private void Awake()
    {


    }

    private void OnEnable()
    {

    }
    void Start()
    {
        items.Init();

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
        for (int i = 0; i < list_Skill.Count; ++i)
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
    public int level;

    public int atk;
    public float atk_Dis;
    public float atk_Speed;

    public int exp;
    public int maxExp;

    public int hp;
    public int maxHp;

    public int mp;
    public int maxMp;

    public float move_Speed;

    public float cri_Chance;
    public float damage_CRI;

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

/// <summary>
/// �÷��̾�� ������ �������� ����
/// </summary>
[Serializable]
public class Player_ItemData : SaveFile
{
    [Header("�÷��̾� ������ �ִ� �ر� �ε���")]
    public Item_ClearIndexData indexData;

    [Header("�ִ� �ر� ���������")]
    public Item_Weapon weapon;
    public Item_Helmet helmet;
    public Item_Armor armor;
    public Item_Gloves gloves;
    public Item_Foot foot;
    public Item_Back back;


    public void Init()
    {
        Item_Init();
        Add_ItemAbility();
    }

    /// <summary>
    /// �÷��̾��� �������� ����������
    /// </summary>
    void Item_Init()
    {
        weapon = Object_Mgr.Instance.item_Mgr.Get_Weapon(indexData.weponIndex);
        helmet = Object_Mgr.Instance.item_Mgr.Get_Helmet(indexData.helmetInex);
        armor = Object_Mgr.Instance.item_Mgr.Get_Armor(indexData.armorIndex);
        gloves = Object_Mgr.Instance.item_Mgr.Get_Gloves(indexData.glovesIndex);
        foot = Object_Mgr.Instance.item_Mgr.Get_Foot(indexData.footIndex);
        back = Object_Mgr.Instance.item_Mgr.Get_Back(indexData.backIndex);

    }
    /// <summary>
    /// ������ �������� �ɷ�ġ�� ĳ�� ���ݿ� ������
    /// </summary>
    void Add_ItemAbility()
    {
        Player player = Object_Mgr.Instance.player_Mgr.Get_MainPlayer();

        if (player == null)
            return;

        weapon.Add_ItemAbility(ref player);
        helmet.Add_ItemAbility(ref player);
        armor.Add_ItemAbility(ref player);
        back.Add_ItemAbility(ref player);
        gloves.Add_ItemAbility(ref player);
        foot.Add_ItemAbility(ref player);
    }

    //�÷��̾� ������ �ִ� �ر� �ε���
    [Serializable]
    public class Item_ClearIndexData
    {
        public int weponIndex;
        public int helmetInex;
        public int armorIndex;
        public int glovesIndex;
        public int footIndex;
        public int backIndex;
    }
}
