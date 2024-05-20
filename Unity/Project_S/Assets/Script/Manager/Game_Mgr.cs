using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���� �� �����͸� ������ ��ü
/// �ɼ�, �ھ���� ���
/// </summary>
public class Game_Mgr : MonoBehaviour
{
    private static Game_Mgr instance = null;

    public static Game_Mgr Instance
    {
        get
        {
            return instance;
        }
    }

    [SerializeField] public byte[] key = SaveSystem.GenerateRandomKey(32);
    [SerializeField] public byte[] iv = SaveSystem.GenerateRandomKey(16);

    public Player_Save player_save = new Player_Save();

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
        if(isDataLoad)
            AutoSave();
    }


    private void AutoSave()
    {
        
        autoSaveTime -= Time.deltaTime;
        if (autoSaveTime < 0)
        {
            //������ ���� �ڵ� ��â
            Save();
        }
    }

    public void Save()
    {
        player_save.Save();
        autoSaveTime = 60f;
    }

    public void SetDataLoad(bool _b)
    {
        isDataLoad = _b;
    }

}
