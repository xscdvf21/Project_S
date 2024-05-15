using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Helmet_Data", menuName = "ProjectS/CreateItem/Helmet", order = int.MaxValue)]

public class Item_Helmet : Item
{
    [Header("치명타 확률")]
    public float CRI_Chance;
    [Header("치명타 데미지")]
    public float Damage_CRI;

    public void Add_ItemAbility(ref Player _player)
    {
        if (_player == null)
            return;

        _player.ability.cri_Chance += CRI_Chance;
        _player.ability.damage_CRI += Damage_CRI;
    }
}
