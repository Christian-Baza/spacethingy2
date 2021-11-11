using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneChanger : MonoBehaviour
{
    [SerializeField] GameObject dontDestroy;
    private void Start()
    {
        GameObject.DontDestroyOnLoad(dontDestroy);
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            dontDestroy.SetActive(true);
        }
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
}
