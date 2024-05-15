using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Back_Data", menuName = "ProjectS/CreateItem/Back", order = int.MaxValue)]

public class Item_Back : Item
{
    [Header("공격 속도")]
    public float Atk_Speed;
    [Header("이동 속도")]
    public float Move_Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
