using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armor_Data", menuName = "ProjectS/CreateItem/Armor", order = int.MaxValue)]

public class Item_Armor : Item
{
    [Header("최대 HP")]
    public int maxHp;

    [Header("최대 MP")]
    public int maxMp;
    // Start is called before the first frame update
    public void Add_ItemAbility(ref Player _player)
    {
        if (_player == null)
            return;

        _player.ability.maxHp += maxHp;
        _player.ability.maxMp += maxMp;
    }


}
