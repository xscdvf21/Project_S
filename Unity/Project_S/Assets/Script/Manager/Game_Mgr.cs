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

}
