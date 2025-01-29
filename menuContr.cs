using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menuContr : MonoBehaviour
{
    string sceneName;
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }
\
    void Update()
    {
        if(Input.GetKeyDown("escape")){
            PlayerPrefs.SetString("nameLevel1", sceneName);
            SceneManager.LoadScene("menu");
        }        
    }
    public void GameScene(){
        SceneManager.LoadScene("SampleScene");
    }
    public void ContinueGame(){
        SceneManager.LoadScene(PlayerPrefs.GetString("nameLevel1"));
    }
}
