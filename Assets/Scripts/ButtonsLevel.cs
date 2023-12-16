using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsLevel : MonoBehaviour
{
    public string Level;
    public int levelToLoad;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadGame()
    {
        PlayerPrefs.SetInt("CurrentLevel", levelToLoad);
        SceneManager.LoadScene(Level);
    }
}
