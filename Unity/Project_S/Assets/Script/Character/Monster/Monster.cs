using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Monster : MonoBehaviour
{

    [SerializeField] protected MONSTER_TYPE _type;
    public Monster_AbilityData ability;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    [Serializable]
    public class Monster_AbilityData
    {
        public int dagame;
        public int hp;
        public int maxHp;
        public int moveSpeed;
    }
}
