using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    [Header("아이템 타입")]
    public ITEM type;
    [Header("아이템 랭크")]
    public ITEM_RANK rank;
    [Header("아이템 이미지(Sprite)")]
    public Sprite img;


}
