using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerLevels : MonoBehaviour
{
    public GameObject optionsContainer;
    public int maxLevelUnlock;
    public GameObject[] Buttons;
    void Start()
    {
        maxLevelUnlock = PlayerPrefs.GetInt("MaxLevelUnlock", 1);
        CheckLevelsState();
    }
    void CheckLevelsState()
    {
        if(maxLevelUnlock < 3)
        {
            for (int i = 0; i < maxLevelUnlock; ++i)
            {
                Buttons[i].SetActive(true);
            }
            for (int i = maxLevelUnlock; i < Buttons.Length; ++i)
            {
                Buttons[i].SetActive(false);
            }
        }

    }

    void Update()
    {

    }
}