using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Puntaje : MonoBehaviour
{

    public float Scores;
    public int currentLevel;
    public int maxLevelUnlocked;
    public Text textExample;
  
    void Awake()
    {
       
    }
    void Start()
    {
        currentLevel = PlayerPrefs.GetInt("CurrentLevel", 1);
        maxLevelUnlocked = PlayerPrefs.GetInt("MaxLevelUnlock", 1);   
    }
    void Update()
    {
        if (Scores > 99)
        {
            Win();

        }
    }
    public void SumaPuntos(float ScoreFood)
    {
        Scores = Scores + ScoreFood;
        textExample.text = Scores.ToString("0");
       
    }
   
    


    
    public void Win()
    {
        if (currentLevel >= maxLevelUnlocked)
        {
            PlayerPrefs.SetInt("MaxLevelUnlock", currentLevel + 1);

        }
        SceneManager.LoadScene("Victory");
    }
    public void reset()
    {
        PlayerPrefs.DeleteAll();
    }
}
