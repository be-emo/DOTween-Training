// オブジェクトをクリックした時、ウマ娘のフッターのような動作をさせたい
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject OnButton1;
    [SerializeField] private GameObject OnButton2;
    [SerializeField] private GameObject OnButton3;
    [SerializeField] private GameObject OnButton4;
    [SerializeField] private GameObject OnButton5;

    void Start()
    {
        OnButton1.SetActive(false);
        OnButton2.SetActive(false);
        OnButton4.SetActive(false);
        OnButton5.SetActive(false);
    }
}
