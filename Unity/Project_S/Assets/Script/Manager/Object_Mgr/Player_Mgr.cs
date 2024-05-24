using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Mgr : MonoBehaviour
{
    [Header("플레이어 목록 (프리팹)")]
    public Player playerPrefab;


    [SerializeField] Player mainPlayer;
    private void Awake()
    {
        
    }


    public void CreatePlayer()
    {
        if (mainPlayer != null)
            return;

        GameObject player = Instantiate(playerPrefab.gameObject);
        player.SetActive(false);

        DontDestroyOnLoad(player);


        mainPlayer = player.GetComponent<Player>();

        mainPlayer.saveData = Game_Mgr.Instance.Get_SaveData().Get_SaveData();
        Game_Mgr.Instance.SetDataLoad(true);

    }

    public Player Get_MainPlayer()
    {
        return mainPlayer;
    }

    public Vector2 Get_PlayerPos()
    {
        return mainPlayer.transform.position;
    }

    public void Set_PlayerPos(Transform _parent ,Vector2 _vPos)
    {
        mainPlayer.gameObject.SetActive(true);

        mainPlayer.transform.position = _vPos;
        mainPlayer.transform.SetParent(_parent, false);
    }
}
