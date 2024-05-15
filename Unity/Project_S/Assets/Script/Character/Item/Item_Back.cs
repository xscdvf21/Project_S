using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Back_Data", menuName = "ProjectS/CreateItem/Back", order = int.MaxValue)]

public class Item_Back : Item
{
    [Header("���� �ӵ�")]
    public float Atk_Speed;
    [Header("�̵� �ӵ�")]
    public float Move_Speed;
    public void Add_ItemAbility(ref Player _player)
    {
        if (_player == null)
            return;

        _player.ability.atk_Speed += Atk_Speed;
        _player.ability.move_Speed += Move_Speed;
    }
}
