using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armor_Data", menuName = "ProjectS/CreateItem/Armor", order = int.MaxValue)]

public class Item_Armor : Item
{
    [Header("�ִ� HP")]
    public int maxHp;

    [Header("�ִ� MP")]
    public int maxMp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
