using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    [SerializeField] private GameObject bt1_off;
    [SerializeField] private GameObject bt2_off;
    [SerializeField] private GameObject bt3_off;
    [SerializeField] private GameObject bt4_off;
    [SerializeField] private GameObject bt5_off;
    
    [SerializeField] private GameObject bt1_on;
    [SerializeField] private GameObject bt2_on;
    [SerializeField] private GameObject bt3_on;
    [SerializeField] private GameObject bt4_on;
    [SerializeField] private GameObject bt5_on;
    
    // Start is called before the first frame update
    // オブジェクトをクリックした時、ウマ娘のフッターのような動作をさせたい
    void Start()
    {
        bt1_off.SetActive(true);
        bt2_off.SetActive(true);
        bt3_off.SetActive(false);
        bt4_off.SetActive(true);
        bt5_off.SetActive(true);
        
        bt1_on.SetActive(false);
        bt2_on.SetActive(false);
        bt3_on.SetActive(true);
        bt4_on.SetActive(false);
        bt5_on.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
