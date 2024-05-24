using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Mgr : MonoBehaviour
{

    private static Shop_Mgr instance = null;

    public static Shop_Mgr Instance
    {
        get
        {
            return instance;
        }
    }

    public Shop_AbilityData abilityShop;
    public Shop_ItemData itemShop;

    private void Awake()
    {
        instance = null;
    }

    // Start is called before the first frame update
    void Start()
    {
        //for(int i = 0; i < itemShop.wepons.Count; ++i)
        //{
        //    itemShop.wepons[i].atk = (i + 1) * 10;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
