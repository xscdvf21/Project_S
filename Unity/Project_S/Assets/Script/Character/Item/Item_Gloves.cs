using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Gloves_Data", menuName = "ProjectS/CreateItem/Gloves", order = int.MaxValue)]

public class Item_Gloves : Item
{
    [Header("���� �ӵ�")]
    public float Atk_Speed;

    [Header("ġ��Ÿ Ȯ��")]
    public float CRI_Chance;

    [Header("ġ��Ÿ ���ݷ� ")]
    public float Damage_CRI;
    // Start is called before the first frame update
    public void Add_ItemAbility(ref Player _player)
    {
        if (_player == null)
            return;

        _player.ability.atk_Speed += Atk_Speed;
        _player.ability.cri_Chance += CRI_Chance;
        _player.ability.damage_CRI += Damage_CRI;

    }
}
