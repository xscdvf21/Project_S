using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// �Ŵ������� �����ϰ��ִ� ��ü
/// �Ŵ��� ��ü ������ �����ϱ� ����
/// </summary>
public class Manager : MonoBehaviour
{

    private static Manager instacne = null;

    [SerializeField] GameObject[] managers;
    // Start is called before the first frame update


    private void Awake()
    {
        if(instacne == null)
        {
            instacne = this;

            for(int i = 0; i < managers.Length; ++i)
            {
                int iIndex = i;
                managers[iIndex].SetActive(true);
            }

            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }


    }
    void Start()
    {
        SceneManager.LoadScene("Lobby");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
