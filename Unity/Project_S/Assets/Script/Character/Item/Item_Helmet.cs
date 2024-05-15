using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Helmet_Data", menuName = "ProjectS/CreateItem/Helmet", order = int.MaxValue)]

public class Item_Helmet : Item
{
    [Header("ġ��Ÿ Ȯ��")]
    public float CRI_Chance;
    [Header("ġ��Ÿ ������")]
    public float Damage_CRI;

    public void Add_ItemAbility(ref Player _player)
    {
        if (_player == null)
            return;

        _player.ability.cri_Chance += CRI_Chance;
        _player.ability.damage_CRI += Damage_CRI;
    }
}
