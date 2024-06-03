using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_Mgr : MonoBehaviour
{


    [SerializeField] List<SpriteComponent> list_Sprite;

    [SerializeField] List<Sprites> list_Sprites;


    [SerializeField] Dictionary<SPRITE_TYPE, Sprites> dic_Sprites;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Sprite GetSprite(CHARACTER_SPRITE _spriteType, int _iIndex)
    {
        if (_iIndex > list_Sprite[(int)_spriteType].sprites.Count - 1)
            return null;


        return list_Sprite[(int)_spriteType].sprites[_iIndex];
    }

    [Serializable]
    public class SpriteComponent
    {
        public CHARACTER_SPRITE spriteType;
        public List<Sprite> sprites;
    }


    [Serializable]
    public class Sprites
    {
        public SPRITE_TYPE sprite_Type;
        public List<SpritesComponent> lists;

        [Serializable]
        public class SpritesComponent
        {
            public List<Sprite> sprites;
        }
    }



    

}
