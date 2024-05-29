using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Player_Save : SaveFile
{
    [SerializeField] Player_AbilityIndex ability = new Player_AbilityIndex();
    [SerializeField] Player_ItemIndex items = new Player_ItemIndex();
    [SerializeField] Player_SkillIndex skill = new Player_SkillIndex();
    [SerializeField] Player_ResourceIndex resource = new Player_ResourceIndex();



    public void Save()
    {
        SaveSystem.Save("Player_Save", this);
        Debug.Log("데이터 파일 저장");
    }

    public void Load()
    {
        if (!SaveSystem.Exists("Player_Save"))
        {
             ability = new Player_AbilityIndex();
             items = new Player_ItemIndex();
             skill = new Player_SkillIndex();
             resource = new Player_ResourceIndex();

            SaveSystem.Save("Player_Save", this);
        }

        SaveSystem.Load("Player_Save", out Player_Save temp);

        if (temp == null)
        {
            Debug.Log("세이브 데이터 없음, 1렙부터 시작");
            return;
        }

        DataLoad(temp);
        //DataSetting(temp);
    }


    private void DataLoad(Player_Save _temp)
    {
        Debug.Log("데이터 로드 및 셋팅 성공");

        //어빌리티
        ability.atkIndex         = _temp.ability.atkIndex;
        ability.atk_SpeedIndex = _temp.ability.atk_SpeedIndex;
        ability.hpIndex = _temp.ability.hpIndex;
        ability.mpIndex = _temp.ability.mpIndex;
        ability.move_SpeedIndex = _temp.ability.move_SpeedIndex;
        ability.cri_ChanceIndex = _temp.ability.cri_ChanceIndex;
        ability.damage_CRIIndex = _temp.ability.damage_CRIIndex;
        
        //장비
        items.DeepCopy(_temp.items);

        //스킬               

        //자원
        resource.level = _temp.resource.level;
        resource.exp = _temp.resource.exp;
        resource.gold = _temp.resource.gold;
    }

    public Player_Save Get_SaveData()
    {
        return this;
    }
    public Player_ItemIndex GetItems()
    {
        return items;
    }

    public Player_AbilityIndex GetAbility()
    {
        return ability;
    }

    public Player_SkillIndex GetSkill()
    {
        return skill;
    }

    public Player_ResourceIndex Get_Resource()
    {
        return resource;
    }

    public void Insert_Data(ref Player player)
    {
        resource.level = player.resource.level;
        resource.exp = player.resource.exp;
        resource.gold = player.resource.gold;
    }

}


/// <summary>
/// 어빌리티 해금 인덱스 (상점에 이용)
/// </summary>
[Serializable]
public class Player_AbilityIndex
{
    public int atkIndex;
    public int atk_SpeedIndex;
    public int hpIndex;
    public int mpIndex;
    public int move_SpeedIndex;
    public int cri_ChanceIndex;
    public int damage_CRIIndex;

    public void Add_Index(PLAYER_ABILITY _type)
    {
        switch (_type)
        {
            case PLAYER_ABILITY.ATTACK:
                atkIndex++;
                break;
            case PLAYER_ABILITY.ATTACK_SPEED:
                atk_SpeedIndex++;
                break;
            case PLAYER_ABILITY.HP:
                hpIndex++;
                break;
            case PLAYER_ABILITY.MP:
                mpIndex++;
                break;
            case PLAYER_ABILITY.MOVE_SPEED:
                move_SpeedIndex++;
                break;
            case PLAYER_ABILITY.CRI_CHANCE:
                cri_ChanceIndex++;
                break;
            case PLAYER_ABILITY.DAMAGE_CRI:
                damage_CRIIndex++;
                break;
        }
    }
}


/// <summary>
/// 아이템 해금 인덱스 (상점에 이용)
/// </summary>
[Serializable]
public class Player_ItemIndex
{
    public List<item> wepons;
    public List<item> helmets;
    public List<item> armors;
    public List<item> goloves;
    public List<item> foots;
    public List<item> backs;    

    public Player_ItemIndex()
    {
        wepons = new List<item>();
        helmets = new List<item>();
        armors = new List<item>();
        goloves = new List<item>();
        foots = new List<item>();
        backs = new List<item>();

    }


    public void DeepCopy(Player_ItemIndex _copy)
    {
        for (int i = 0; i < _copy.wepons.Count; ++i)
        {
            int iIndex = i;
            wepons.Add(_copy.wepons[iIndex]);
        }
        for (int i = 0; i < _copy.helmets.Count; ++i)
        {
            int iIndex = i;
            wepons.Add(_copy.helmets[iIndex]);
        }
        for (int i = 0; i < _copy.armors.Count; ++i)
        {
            int iIndex = i;
            wepons.Add(_copy.armors[iIndex]);
        }
        for (int i = 0; i < _copy.goloves.Count; ++i)
        {
            int iIndex = i;
            wepons.Add(_copy.goloves[iIndex]);
        }
        for (int i = 0; i < _copy.foots.Count; ++i)
        {
            int iIndex = i;
            wepons.Add(_copy.foots[iIndex]);
        }
        for (int i = 0; i < _copy.backs.Count; ++i)
        {
            int iIndex = i;
            wepons.Add(_copy.backs[iIndex]);
        }
    }


    [Serializable]
    public struct item
    {
        public int itemCount;

    }



}

/// <summary>
/// 스킬 해금 인덱스
/// </summary>
[Serializable]
public class Player_SkillIndex
{

}

[Serializable]
public class Player_ResourceIndex
{
    public int level = 1;
    public int exp;
    public int gold;
}



