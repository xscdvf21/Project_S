using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Mgr : MonoBehaviour
{
    public List<Item_Weapon> wepons;
    public List<Item_Helmet> helmets;
    public List<Item_Armor> armors;
    public List<Item_Gloves> gloves;
    public List<Item_Foot> foots;
    public List<Item_Back> backs;

    //Item 오브젝트를 가져옴


    public Item_Weapon Get_Weapon(int _itemIndex = 0)
    {
        if (_itemIndex < wepons.Count)
            return wepons[_itemIndex];

        return null;
    }

    public Item_Helmet Get_Helmet(int _itemIndex = 0)
    {
        if (_itemIndex < helmets.Count)
            return helmets[_itemIndex];

        return null;
    }
    public Item_Armor Get_Armor(int _itemIndex = 0)
    {
        if (_itemIndex < armors.Count)
            return armors[_itemIndex];

        return null;
    }

    public Item_Gloves Get_Gloves(int _itemIndex = 0)
    {
        if (_itemIndex < gloves.Count)
            return gloves[_itemIndex];

        return null;
    }

    public Item_Foot Get_Foot(int _itemIndex = 0)
    {
        if (_itemIndex < foots.Count)
            return foots[_itemIndex];

        return null;
    }

    public Item_Back Get_Back(int _itemIndex = 0)
    {
        if (_itemIndex < backs.Count)
            return backs[_itemIndex];

        return null;
    }
}
