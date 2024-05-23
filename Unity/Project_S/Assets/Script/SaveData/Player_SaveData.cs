using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Player_Save : SaveFile
{

    [SerializeField] Player_AbilityData ability;
    [SerializeField] Player_SkillData skill;
    [SerializeField] Player_ItemData items;
    [SerializeField] Player_Resource resource;
    

    public void Save()
    {
        SaveSystem.Save("Player_Save", this);
        Debug.Log("데이터 파일 저장");
    }

    public void Load()
    {
        if (!SaveSystem.Exists("Player_Save"))
        {
            Init();
            SaveSystem.Save("Player_Save", this);
        }

        SaveSystem.Load("Player_Save", out Player_Save temp);

        if (temp == null)
        {
            Debug.Log("세이브 데이터 없음, 1렙부터 시작");
            return;
        }

        DataSetting(temp);
    }

    private void Init()
    {
        if (Object_Mgr.Instance)
        {
            Debug.Log("데이터 파일이 존재하지 않아, 데이터 파일 생성 ");    
            
            Player playerTemp = Object_Mgr.Instance.player_Mgr.playerPrefab;
            InitDataSetting(playerTemp, GetSaveData());
        }
    }

    public Player_Save GetSaveData()
    {
        return this;
    }


    private void DataSetting(Player_Save temp)
    {
        Debug.Log("데이터 로드 및 셋팅 성공");

        ability.atk = temp.ability.atk;
        ability.atk_Dis = temp.ability.atk_Dis;
        ability.atk_Speed = temp.ability.atk_Speed;


        ability.hp = temp.ability.hp;
        ability.maxHp = temp.ability.maxHp;

        ability.mp = temp.ability.mp;
        ability.maxMp = temp.ability.maxMp;

        ability.move_Speed = temp.ability.move_Speed;

        ability.cri_Chance = temp.ability.cri_Chance;
        ability.damage_CRI = temp.ability.damage_CRI;


        resource.level = temp.resource.level;
        resource.exp = temp.resource.exp;
        resource.maxExp = temp.resource.maxExp;

        for (int i = 0; i < temp.skill.list_Skill.Count; ++i)
        {
            skill.list_Skill.Add(temp.skill.list_Skill[i]);
        }


        items.indexData.weponIndex = temp.items.indexData.weponIndex;
        items.indexData.helmetInex = temp.items.indexData.helmetInex;
        items.indexData.armorIndex = temp.items.indexData.armorIndex;
        items.indexData.glovesIndex = temp.items.indexData.glovesIndex;
        items.indexData.footIndex = temp.items.indexData.footIndex;
        items.indexData.backIndex = temp.items.indexData.backIndex;

    }

    private void InitDataSetting(Player _temp, Player_Save _player)
    {
        _player.ability.atk         = _temp.ability.atk;
        _player.ability.atk_Dis     = _temp.ability.atk_Dis;
        _player.ability.atk_Speed   = _temp.ability.atk_Speed;

        _player.ability.hp          = _temp.ability.hp;
        _player.ability.maxHp       = _temp.ability.maxHp;

        _player.ability.mp          = _temp.ability.mp;
        _player.ability.maxMp       = _temp.ability.maxMp;

        _player.ability.move_Speed  = _temp.ability.move_Speed;

        _player.ability.cri_Chance  = _temp.ability.cri_Chance;
        _player.ability.damage_CRI  = _temp.ability.damage_CRI;


        _player.resource.level = _temp.resource.level;
        _player.resource.exp = _temp.resource.exp;
        _player.resource.maxExp = _temp.resource.maxExp;

        for (int i = 0; i < _temp.skill.list_Skill.Count; ++i)
        {
            skill.list_Skill.Add(_temp.skill.list_Skill[i]);
        }


        items.indexData.weponIndex  = _temp.items.indexData.weponIndex;
        items.indexData.helmetInex  = _temp.items.indexData.helmetInex;
        items.indexData.armorIndex  = _temp.items.indexData.armorIndex;
        items.indexData.glovesIndex = _temp.items.indexData.glovesIndex;
        items.indexData.footIndex   = _temp.items.indexData.footIndex;
        items.indexData.backIndex   = _temp.items.indexData.backIndex;
    }

    public Player_ItemData GetItems ()
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

}
