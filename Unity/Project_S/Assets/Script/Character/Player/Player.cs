using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Player : MonoBehaviour
{
    public Player_AbilityData ability = new Player_AbilityData();
    public Player_ItemData items = new Player_ItemData();
    public Player_SkillData skill = new Player_SkillData();
    public Player_Resource resource = new Player_Resource();
    // Start is called before the first frame update
    private void Awake()
    {
    }

    private void OnEnable()
    {

    }

    void Start()
    {

        //items.Init(saveData);
        //skill.Init(saveData);

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


public abstract class Data
{
    public abstract void Load(Player_Save _saveData);
}

[Serializable]
public class Player_AbilityData : Data
{

    public int atk;
    public float atk_Dis;
    public float atk_Speed;

    public int hp;
    public int maxHp;

    public int mp;
    public int maxMp;

    public float move_Speed;

    public float cri_Chance;
    public float damage_CRI;

    public Player_AbilityData()
    {
        
    }
    public override void Load(Player_Save _saveData)
    {
        var _ability = _saveData.GetAbility();

        if (_ability == null)
            return;

        atk += _ability.atk;
        atk_Speed += _ability.atk_Speed;

        hp += _ability.hp;

        mp += _ability.mp;

        move_Speed += _ability.move_Speed;

        cri_Chance += _ability.cri_Chance;
        damage_CRI += _ability.damage_CRI;


        maxHp = hp;
        maxMp = mp;
    }


    public void Add_Ability(PLAYER_ABILITY _abilityType, int _addValue)
    {
        switch (_abilityType)
        {
            case PLAYER_ABILITY.ATTACK:
                atk += _addValue;
                break;
            case PLAYER_ABILITY.ATTACK_SPEED:
                atk_Speed += _addValue;
                break;
            case PLAYER_ABILITY.HP:
                hp += _addValue;
                break;
            case PLAYER_ABILITY.MP:
                break;
            case PLAYER_ABILITY.MOVE_SPEED:
                move_Speed += _addValue;
                break;
            case PLAYER_ABILITY.CRI_CHANCE:
                cri_Chance += _addValue;
                break;
            case PLAYER_ABILITY.DAMAGE_CRI:
                damage_CRI += _addValue;
                break;
        }
    }
}
/// <summary>
/// 현재 적용되어있는 스킬
/// </summary>
/// 같은것은 하나만 가능
[Serializable]
public class Player_SkillData : Data
{
    public List<Skill> list_Skill;
    public override void Load(Player_Save _saveData)
    {

    }

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


/// <summary>
/// 플레이어에게 장착된 아이템을 관리
/// </summary>
[Serializable]
public class Player_ItemData : Data
{
    [Header("최대 해금 착용아이템")]
    public Item_Weapon weapon;
    public Item_Helmet helmet;
    public Item_Armor armor;
    public Item_Gloves gloves;
    public Item_Foot foot;
    public Item_Back back;

    public override void Load(Player_Save _saveData)
    {

        Add_ItemAbility();
    }

    /// <summary>
    /// 장착된 아이템의 능력치를 캐릭 스텟에 더해줌
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


}

//플레이어 아이템 최대 해금 인덱스

//경험치, 골드량 등등 플레이어의 자원을 표시함
[Serializable]
public class Player_Resource : Data
{

    public int level;

    public int exp;
    public int maxExp;

    public int gold;

    public Player_Resource()
    {
        level = 1;
        exp = 0;
        maxExp = 100;
        gold = 0;
    }
    public override void Load(Player_Save _saveData)
    {
        level = _saveData.Get_Resource().level;
        exp = _saveData.Get_Resource().exp;        
        gold = _saveData.Get_Resource().gold;

        maxExp = level * 100;
    }



    public void Add_Resource(int _exp, int _gold)
    {
        AddExp(_exp);
        AddGold(_gold);
    }

    private void AddExp(int _exp)
    {
        exp += _exp;

        if (exp >= maxExp)
            LevelUp();

    }

    private void AddGold(int _gold)
    {
        gold += _gold;
    }

    private void LevelUp()
    {
        if (exp < maxExp)
            return;

        level++;
        exp -= maxExp;
        maxExp = maxExp * level;
    }

    public void UseGold(int _gold)
    {
        if (gold > _gold)
            return;

        gold -= _gold;
    }

}


//플레이어의 아이템 해금 인덱스 들고있는 아이템은 저장 할 필요가 없기 때문에 인덱스만 들고있어도 될듯
//스킬도 마찬가지로 될 예정

