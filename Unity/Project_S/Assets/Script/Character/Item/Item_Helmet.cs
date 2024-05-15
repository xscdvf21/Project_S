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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
