using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour
{
    public GameObject[] Food;
    private Transform _compTransform;
    public float TimeSpawnFood;
   

    void Awake()
    {
        _compTransform = GetComponent<Transform>();
    }
    void Start()
    {
        Invoke("CreateFood", TimeSpawnFood);
    }

    void Update()
    {

    }
    void CreateFood()
    {

        int positionX = Random.Range(-23, 23);
        int positionY = Random.Range(12, 19);
        
        int randomNumber = Random.Range(0, 3);
        _compTransform.position = new Vector3(positionX, positionY);
       
        
        
            Instantiate(Food[randomNumber], _compTransform.position, _compTransform.rotation);
          
        

        Invoke("CreateFood", TimeSpawnFood);


    }
}

