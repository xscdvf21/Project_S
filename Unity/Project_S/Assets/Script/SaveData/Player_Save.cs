using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Player_Save : SaveFile
{

    [SerializeField]Player_AbilityData ability;
    [SerializeField]Player_ItemData items;
    [SerializeField]Player_SkillData skill;
    [SerializeField]Player_Resource resource;

    public void Save()
    {
        SaveSystem.Save("Player_Save", this);
        Debug.Log("데이터 파일 저장");
    }

    public void Load()
    {
        if (!SaveSystem.Exists("PlayerData"))
        {
             ability = new Player_AbilityData();
             items = new Player_ItemData();
             skill = new Player_SkillData();
             resource = new Player_Resource();

            SaveSystem.Save("PlayerData", this);
        }

        SaveSystem.Load("PlayerData", out Player _result);

        if (_result == null)
        {
            Debug.Log("세이브 데이터 없음, 1렙부터 시작");
            return;
        }
        DataLoad(_result);
        
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


        //리소스
        resource.exp = _player.resource.exp;
        resource.gold = _player.resource.gold;

    }

    public Player_Save Get_SaveData()
    {
        return this;
    }
    public Player_ItemData GetItems()
    {
        return items;
    }

    public Player_AbilityData GetAbility()
    {
        return ability;
    }

    public Player_SkillData GetSkill()
    {
        return skill;
    }

    public Player_Resource Get_Resource()
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


