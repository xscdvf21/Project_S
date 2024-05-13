using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_Mgr : MonoBehaviour
{


    [SerializeField] List<SpriteComponent> list_Sprite;

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


    

}
