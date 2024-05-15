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

    public void Add_ItemAbility(ref Player _player)
    {
        if (_player == null)
            return;

        _player.ability.atk += atk;
    }
}
