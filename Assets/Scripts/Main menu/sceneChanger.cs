using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneChanger : MonoBehaviour
{

    public int SceneIndex = 2;
    private void Update()
    {
        
        SceneManager.LoadScene(SceneIndex);
    }
}
