using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Foot_Data", menuName = "ProjectS/CreateItem/Foot", order = int.MaxValue)]

public class Item_Foot : Item
{
    [Header("�̵��ӵ�")]
    public float Move_Speed;
    // Start is called before the first frame update
    public void Add_ItemAbility(ref Player _player)
    {
        if (_player == null)
            return;

        _player.ability.move_Speed += Move_Speed;
    }
}
