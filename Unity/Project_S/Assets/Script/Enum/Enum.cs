public enum PLAYER_SKILL
{
    NONE = -1,
    GUIDED_ARROW, //유도 화살
    END,
}

public enum PLAYER_STATE
{
    NONE = -1,
    IDLE,
    RUN,
    ATTACK,
    DEAD,
    END,

}

public enum PLAYER_ABILITY
{
    NONE = -1,
    ATTACK,
    ATTACK_SPEED,
    HP,
    MP,
    MOVE_SPEED,
    CRI_CHANCE,
    DAMAGE_CRI,
    END,
}

public enum ACTIVE_SKILL
{
    NONE = -1,
    ACTIVE_1,
    END,
}
public enum PASSIVE_SKILL
{
    NONE = -1,
    PASSIVE_1,
    END,
}



public enum CHARACTER_SPRITE
{
    NONE = -1,
    HAIR_SRPITE,
    FACEHAIR_SPRITE,
    CLOTH_SRPITE,
    PANT_SRPITE,
    HELMET_SRPITE,
    ARMOR_SRPITE,
    WEAPON_SRPITE,
    BACK_SRPITE,
    EYE_SRPITE,
    END,
}



/////////////////////////////////////////////////////////////////////////////////////////
/// <summary>
/// 캐릭 스프라이트
/// </summary>
public enum HAIR_SPRITE
{
    NONE = -1,
    HAIR_1,
    HAIR_2,
    HAIR_3,
    HAIR_4,
    HAIR_5,
    HAIR_6,
    HAIR_7,
    HAIR_8,
    HAIR_9,
    END,
}

public enum FACEHAIR_SPRITE
{
    NONE = -1,
    FACEHAIR_1,
    FACEHAIR_2,
    FACEHAIR_3,
    FACEHAIR_4,
    FACEHAIR_5,
    END,
}

public enum CLOTH_SPRITE
{
    NONE = -1,

    CLOTH_1,
    CLOTH_2,
    CLOTH_3,
    CLOTH_4,
    CLOTH_5,
    CLOTH_6,
    CLOTH_7,
    CLOTH_8,
    CLOTH_9,
    CLOTH_10,
    CLOTH_11,
    CLOTH_12,
    
    END
}
public enum PANT_SPRITE
{
    NONE = -1,
    FOOT_1,
    FOOT_2,
    FOOT_3,
    FOOT_4,
    END,
}

public enum HELMET_SPRITE
{
    NONE = 1,
    HELMET_1,
    HELMET_2,
    HELMET_3,
    HELMET_4,
    HELMET_5,
    HELMET_6,
    HELMET_7,
    HELMET_8,
    HELMET_9,
    END
}

public enum ARMOR_SPRITE
{
    NONE = -1,
    ARMOR_1,
    ARMOR_2,
    ARMOR_3,
    ARMOR_4,
    ARMOR_5,
    ARMOR_6,
    ARMOR_7,
    ARMOR_8,
    END,
}

public enum WEAPON_SPRITE
{
    NONE = -1,
    AXE_1,
    BOW_1,
    SHIELD_1,
    SPEAR_1,
    SPEAR_2,
    SWORD_1,
    SWORD_2,
    SWORD_3,
    SWORD_4,
    SWROD_5,
    SWROD_6,
    WARD_1,
    END,

}
public enum BACK_SPRITE
{
    NONE = -1,
    BACK_1,
    BACK_2,
    BACK_3,
    BOWBACK_1,
    SPEARBACK_1,
    END,
}

public enum GLOVES_SPRITE
{
    NONE = -1,
    END,
}

public enum EYE_SPRITE
{
    NONE = -1,
    EYE_1,
    END,
}
/////////////////////////////////////////////////////////////////////////////////////////
public enum MONSTER_TYPE
{
    NONE = -1,
    DEFAULT,
    BOSS,
    END
}

public enum MONSTER_KIND
{
    NONE = -1,
    SLIME_RED,
    SLIME_BLUE,
    SLIME_GREEN,
    END,
}


public enum ITEM
{
    NONE = -1,
    WEAPON,
    HELMET,
    ARMOR,
    GLOVE,
    FOOT,
    BACK,
    END,
}

public enum ITEM_RANK
{
    NONE = -1,
    D,
    C,
    B,
    A,
    S,
    SS,
    SSS,

    END,
}

public enum WEAPON_TYPE
{
    NONE = -1,
    MELEE,
    RANGER,
    END
}

public enum DAMAGE_FONT
{
    NONE = -1,
    DEFAULT,
    CRI,
    END,
}


public enum INGAME_MENU
{
    NONE = -1,
    STAGE,
    ABILITY,
    ITEM,
    SKILL,
    CASH,
    END,
}




