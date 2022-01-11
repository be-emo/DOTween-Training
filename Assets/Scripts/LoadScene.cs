using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public string SceneName;
    // public Text m_text;
    public GameObject LoadCanvas;
    void Start()
    {
        
    }
    
    public IEnumerator Load_Scene()
    {
        FadeManager.instance.FadeOut();   // フェードアウト
        
        // フェードアウトアニメーションのために待つ
        yield return new WaitForSeconds(0.2f);
        NowLoadingManager.instance.LoadingEffect();    // NowLoadingパネルの出現
        
        // yield return null;
        
        // 自身が特定するシーンをロードし始める
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(SceneName);
        
        // 自身が許可するまでシーンをアクティベートさせない
        asyncOperation.allowSceneActivation = false;

        // ロードが進行中の時，テキストとプログレスバーを出力する
        while (!asyncOperation.isDone)
        {
            // ロードが終了したかどうか確認する
            if (asyncOperation.progress >= 0.9f)
            {
                // ロードのアニメーションを見せるために2秒待つ
                // 本実装では0.2f
                yield return new WaitForSeconds(2.0f);
                FadeManager.instance.FadeIn();
                LoadCanvas.SetActive(false);
                asyncOperation.allowSceneActivation = true;
            }
            // yield return null;
        }
    }
}