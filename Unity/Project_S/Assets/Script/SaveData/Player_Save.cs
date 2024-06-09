using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Player_Save : SaveFile
{

    Player_AbilityData ability;
    Player_ItemData items;
    Player_SkillData skill;
    Player_Resource resource;

    public void Save()
    {
        SaveSystem.Save("Player_Save", this);
        Debug.Log("데이터 파일 저장");
    }

    public void Load()
    {
        if (!SaveSystem.Exists("Player_Save"))
        {
             ability = new Player_AbilityData();
             items = new Player_ItemData();
             skill = new Player_SkillData();
             resource = new Player_Resource();

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


    private void DataLoad(Player _player)
    {
        Debug.Log("데이터 로드 및 셋팅 성공");

        //어빌리티
        ability.atk = _player.ability.atk;
        ability.atk_Dis = _player.ability.atk_Dis;
        ability.atk_Speed = _player.ability.atk_Speed;
        ability.hp = _player.ability.hp;
        ability.mp = _player.ability.mp;
        ability.move_Speed = _player.ability.move_Speed;
        ability.cri_Chance = _player.ability.cri_Chance;
        ability.damage_CRI = _player.ability.damage_CRI;
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



