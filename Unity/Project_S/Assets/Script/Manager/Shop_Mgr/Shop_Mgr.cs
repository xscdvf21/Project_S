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

    public Ability_Shop ability_Shop;
    public Weapon_Shop weapon_Shop;
    public Skill_Shop skill_Shop;


    private void Awake()
    {
        instance = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
