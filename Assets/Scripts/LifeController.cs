using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeController : MonoBehaviour
{
    public int Life;
    public GameObject[] Lifes;

    void Start()
    {
    
        ActivateLives();
    }

    void Update()
    {
      
    }

    public void Vidas()
    {
    
        for (int i = 0; i < Lifes.Length; i++)
        {
            Lifes[i].SetActive(false);
        }

        
        for (int i = 0; i < Life; i++)
        {
            Lifes[i].SetActive(true);
        }

       
        if (Life < 1)
        {
            SceneManager.LoadScene("GameOver");
        }
    }


    void ActivateLives()
    {
        for (int i = 0; i < Lifes.Length; i++)
        {
            Lifes[i].SetActive(true);
        }
    }
}
