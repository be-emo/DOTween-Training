using System.Collections;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] private GameObject OnButton;
    
    // 表示させないOnButton
    [SerializeField] private GameObject OnButton_other1;
    [SerializeField] private GameObject OnButton_other2;
    [SerializeField] private GameObject OnButton_other3;
    [SerializeField] private GameObject OnButton_other4;
    public void OnClick()
    {
        OnButton.SetActive(true);
        OnButton_other1.SetActive(false);
        OnButton_other2.SetActive(false);
        OnButton_other3.SetActive(false);
        OnButton_other4.SetActive(false);
    }
}
