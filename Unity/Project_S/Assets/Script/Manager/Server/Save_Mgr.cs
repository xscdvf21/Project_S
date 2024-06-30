using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 서버에 저장 할 플레이어의 세이브 데이터
/// </summary>
public class Save_Mgr : MonoBehaviour
{
    private static Save_Mgr instance;

    public static Save_Mgr Instance
    {
        get
        {
            return instance;
        }
    }


    [SerializeField] public byte[] key = SaveSystem.GenerateRandomKey(32);
    [SerializeField] public byte[] iv = SaveSystem.GenerateRandomKey(16);

    [SerializeField] Player_Save player_save = new Player_Save();

    [SerializeField] bool isDataLoad = false;
    public float autoSaveTime;
    private void Awake()
    {
        instance = this;
        autoSaveTime = 60;
    }


    // Start is called before the first frame update
    void Start()
    {
        player_save.Load();
    }

    // Update is called once per frame
    void Update()
    {
        //if (isDataLoad)
        //    AutoSave();
    }


    private void AutoSave()
    {

        autoSaveTime -= Time.deltaTime;
        if (autoSaveTime < 0)
        {
            //데이터 파일 자동 저창
            Save();
        }
    }

    private void Save()
    {
        Insert();

        player_save.Save();
        autoSaveTime = 60f;
    }

    //세이브 전에 인설트 해줘야함
    void Insert()
    {
        if (!Object_Mgr.Instance)
            return;

        Player mainPlayer = Object_Mgr.Instance.player_Mgr.Get_MainPlayer();
        player_save.Insert_Data(ref mainPlayer);

    }

    public void SetDataLoad(bool _b)
    {
        isDataLoad = _b;
    }


    private void OnApplicationQuit()
    {
        Save();
    }

    public Player_Save Get_SaveData()
    {
        return player_save;
    }
}
