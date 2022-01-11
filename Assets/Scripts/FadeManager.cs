using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class FadeManager : MonoBehaviour
{
    /*---シングルトン開始---*/
    [SerializeField] private CanvasGroup canvasGroup;
    static public FadeManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }
    /*---シングルトン終了---*/
    
    void Start()
    {  
        
    }
    
    void Update()
    {
        
    }

    public void FadeIn()
    {
        canvasGroup.DOFade(0, 0.5f);
    }

    public void FadeOut()
    {
        canvasGroup.DOFade(1, 0.5f);
    }

    public void FadeOutToIn(TweenCallback action)
    {
        canvasGroup.DOFade(1, 0.5f)
            .OnComplete(() =>
            {
                action();
                FadeIn();
            });
    }
}
