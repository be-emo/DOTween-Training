// ロードの円のモーション{

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class NowLoadingManager : MonoBehaviour
{
    /*---シングルトン開始---*/
    static public NowLoadingManager instance;
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
    
    [SerializeField] private Image image;
    
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadingEffect()
    {
        this.gameObject.SetActive(true);
        image.DOFillAmount(1f, 1.5f)
            .SetLoops(-1, LoopType.Restart)
            .SetEase(Ease.InQuart);
    }
}
