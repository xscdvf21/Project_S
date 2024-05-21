using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class InGame_PlayerUI : MonoBehaviour
{
    Player player;
    [SerializeField] INFO_UI info_UI;
    [SerializeField] SKILL_UI skill_UI;

    // Start is called before the first frame update
    private void Awake()
    {
        player = Object_Mgr.Instance.player_Mgr.Get_MainPlayer();

        info_UI.OnAwake(player);
        skill_UI.OnAwake(player);
    }

    void Start()
    {
    }

    private void OnEnable()
    {
        info_UI.OnEnter(player);
        skill_UI.OnEnter(player);

    }

    // Update is called once per frame
    void Update()
    {
        info_UI.OnUpdate(player);
        skill_UI.OnUpdate(player);
    }

    [Serializable]
    public class INFO_UI : PlayerUI
    {


        [SerializeField] Text text_level;
        [SerializeField] Slider slider_HP;
        [SerializeField] Slider slider_MP;
        [SerializeField] Slider slider_EXP;

        public override void OnAwake(Player _player)
        {
            text_level.text = _player.ability.level.ToString();

            slider_HP.minValue = 0f;
            slider_HP.maxValue = _player.ability.maxHp;

            slider_MP.minValue = 0f;
            slider_MP.maxValue = _player.ability.maxMp;

            slider_EXP.minValue = 0f;
            slider_EXP.maxValue = _player.ability.maxExp;
        }

        public override void OnEnter(Player _player)
        {
        }


        public override void OnUpdate(Player _player)
        {
            text_level.text = _player.ability.level.ToString();

            slider_HP.value = _player.ability.hp;
            slider_MP.value = _player.ability.mp;
            slider_EXP.value = _player.ability.exp;
            
        }

    }


    [Serializable]
    public class SKILL_UI : PlayerUI
    {
        public override void OnAwake(Player _player)
        {
        }

        public override void OnEnter(Player _player)
        {
        }

        public override void OnUpdate(Player _player)
        {
        }
    }

    public abstract class PlayerUI
    {
        //
        public abstract void OnAwake(Player _player);
        public abstract void OnEnter(Player _player);
        public abstract void OnUpdate(Player _player);


    }
}
