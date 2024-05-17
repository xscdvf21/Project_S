using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Text = TMPro.TMP_Text;
public class DamageText : MonoBehaviour
{
    [SerializeField] DAMAGE_FONT type;
    [SerializeField] Text text;
    [SerializeField] float duration;
    [SerializeField] float timer;

    private void OnEnable()
    {
        timer = duration;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
            ReturnObj();
    }

    public void ShowText(string _text)
    {
        gameObject.SetActive(true);
        text.text = _text;
    }

    private void ReturnObj()
    {
        gameObject.SetActive(false);
        Object_Mgr.Instance.text_Mgr.ReturnObj(type, this);
    }
}
