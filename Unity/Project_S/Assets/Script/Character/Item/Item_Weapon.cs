using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon_Data", menuName = "ProjectS/CreateItem/Weapon", order = int.MaxValue )]
public class Item_Weapon : Item
{
    [Header("근접, 원거리 무기 타입")]
    public WEAPON_TYPE _type;
    [Header("데미지")]
    public int atk;

    [Header("무기 사거리")]
    public float atk_ranger;

    [Header("뵤유 효과")]
    public int haveAtk;

    public void Add_ItemAbility(ref Player _player)
    {
        if (_player == null)
            return;

        _player.ability.atk += atk;
    }

}
