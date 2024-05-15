using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon_Data", menuName = "ProjectS/CreateItem/Weapon", order = int.MaxValue )]
public class Item_Weapon : Item
{
    [Header("����, ���Ÿ� ���� Ÿ��")]
    public WEAPON_TYPE _type;
    [Header("������")]
    public int atk;

    public void Add_ItemAbility(ref Player _player)
    {
        if (_player == null)
            return;

        _player.ability.atk += atk;
    }
}
