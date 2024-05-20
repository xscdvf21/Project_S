using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Lobby_Mgr : MonoBehaviour
{
    private static Lobby_Mgr instance = null;

    public static Lobby_Mgr Instance
    {
        get
        {
            return instance;
        }
    }

    [SerializeField] Button startBtn;
    [SerializeField] Button optionBtn;
    [SerializeField] Button quitBtn;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
            return;
        }
        instance = this;


        startBtn.onClick.AddListener(OnClickStartBtn);
        optionBtn.onClick.AddListener(OnClickOptionBtn);
        quitBtn.onClick.AddListener(OnClickQuitBtn);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnClickStartBtn()
    {
        Loading_Mgr.Instance.NextScene("InGame");
    }

    void OnClickOptionBtn()
    {

    }

    void OnClickQuitBtn()
    {
        Application.Quit();
    }
}
