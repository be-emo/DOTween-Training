using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Cysharp.Threading.Tasks;

public class TransBG : MonoBehaviour
{
    [SerializeField] private GameObject obj_bg1;
    [SerializeField] private GameObject obj_bg2;
    [SerializeField] private GameObject obj_bg3;

    [SerializeField] private float span;

    // 背景切替のための時間管理
    private float timeCount = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        obj_bg2.SetActive(false);
        obj_bg3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        //StartCoroutine("BGManagementTime");
        
        if (timeCount <= span)
        {
            obj_bg1.SetActive(true);
            obj_bg3.SetActive(false);
            obj_bg3.transform.Translate(0, -0.02f, 0);
            obj_bg1.transform.Translate(-0.02f, 0, 0);
        }
        else if (timeCount <= span*2)
        {
            obj_bg2.SetActive(true);
            obj_bg1.SetActive(false);
            obj_bg1.transform.Translate(0.02f, 0, 0);
            obj_bg2.transform.Translate(0.02f, 0, 0);
        }
        else if (timeCount <= span*3)
        {
            obj_bg3.SetActive(true);
            obj_bg2.SetActive(false);
            obj_bg2.transform.Translate(-0.02f, 0, 0);
            obj_bg3.transform.Translate(0, 0.02f, 0);
            
        }
        else
        {
            timeCount = 0;
        }
    }
    
    /*
    private IEnumerator BGManagementTime()
    {
        obj_bg1.SetActive(true);
        obj_bg3.SetActive(false);
        bg1.transform.Translate(-0.05f, 0, 0);

        yield return new WaitForSeconds(7.0f);
        
        obj_bg2.SetActive(true);
        obj_bg1.SetActive(false);
        bg2.transform.Translate(0.05f, 0, 0);

        yield return new WaitForSeconds(7.0f);
        
        obj_bg3.SetActive(true);
        obj_bg2.SetActive(false);
        bg3.transform.Translate(0, 0.05f, 0);

        yield return new WaitForSeconds(7.0f);
    }
    */
}
