using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Gloves_Data", menuName = "ProjectS/CreateItem/Gloves", order = int.MaxValue)]

public class Item_Gloves : Item
{
    [Header("공격 속도")]
    public float Atk_Speed;

    [Header("치명타 확률")]
    public float CRI_Chance;

    [Header("치명타 공격력 ")]
    public float Damage_CRI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
