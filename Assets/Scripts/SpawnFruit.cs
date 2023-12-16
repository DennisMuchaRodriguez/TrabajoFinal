using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour
{
    public GameObject[] Food;
    public GameObject[] BadFood;
    public GameObject PowerFood;
    public GameObject PowerFood2;
    public GameObject PowerFood3;
    private Transform _compTransform;
    public float TimeSpawnFood;
    public float TimeSpawnBadFood;
    public float TimeSpawnPowerFood;
    public float TimeSpawnPowerFood2;
    public float TimeSpawnPowerFood3;
    public Puntaje puntaje;
    public LifeController LifeController;
    public Player Player;
   
    void Awake()
    {
        _compTransform = GetComponent<Transform>();
    }
    void Start()
    {
        Invoke("CreateFood", TimeSpawnFood);
        Invoke("CreateBadFood", TimeSpawnBadFood);
        Invoke("CreatePowerFood", TimeSpawnPowerFood);
        Invoke("CreatePowerFood2", TimeSpawnPowerFood2);
        Invoke("CreatePowerFood3", TimeSpawnPowerFood3);
    }

    void Update()
    {

    }
    void CreateFood()
    {
        int positionX = Random.Range(-21, 21);
        int positionY = Random.Range(12, 19);
        int randomNumberFood = Random.Range(0, 6);
        _compTransform.position = new Vector2(positionX, positionY);
       
        
        
        GameObject food = Instantiate(Food[randomNumberFood], _compTransform.position, _compTransform.rotation);
        food.GetComponent<Food>().SetPuntajeGameManaeger(puntaje);
        food.GetComponent<Food>().SetLifeController(LifeController);
        food.GetComponent<Food>().SetPlayerController(Player);

        Invoke("CreateFood", TimeSpawnFood);


    }
    void CreateBadFood()
    {
        int positionX = Random.Range(-21, 21);
        int positionY = Random.Range(12, 19);
        int randomNumberBadFood = Random.Range(0, 6);
        _compTransform.position = new Vector2(positionX, positionY);

        GameObject badfood = Instantiate(BadFood[randomNumberBadFood], _compTransform.position, _compTransform.rotation);
        badfood.GetComponent<BadFood>().SetLifeController(LifeController);
        badfood.GetComponent<BadFood>().SetPuntajeGameManaeger(puntaje);
        badfood.GetComponent<BadFood>().SetPlayerController(Player);

        Invoke("CreateBadFood", TimeSpawnBadFood);

    }
    void CreatePowerFood()
    {
        int positionX = Random.Range(-21, 21);
        int positionY = Random.Range(12, 19);
       
        _compTransform.position = new Vector2(positionX, positionY);

        GameObject powerfood = Instantiate(PowerFood, _compTransform.position, _compTransform.rotation);
        powerfood.GetComponent<PowerFood>().SetLifeController(LifeController);
        powerfood.GetComponent<PowerFood>().SetPuntajeGameManaeger(puntaje);
        powerfood.GetComponent<PowerFood>().SetPlayerController(Player);

        Invoke("CreatePowerFood", TimeSpawnPowerFood);
    }
    void CreatePowerFood2()
    {
        int positionX = Random.Range(-21, 21);
        int positionY = Random.Range(12, 19);
       
        _compTransform.position = new Vector2(positionX, positionY);

        GameObject powerfood2 = Instantiate(PowerFood2, _compTransform.position, _compTransform.rotation);
        powerfood2.GetComponent<PowerFood2>().SetLifeController(LifeController);
        powerfood2.GetComponent<PowerFood2>().SetPuntajeGameManaeger(puntaje);
        powerfood2.GetComponent<PowerFood2>().SetPlayerController(Player);

        Invoke("CreatePowerFood2", TimeSpawnPowerFood2);
    }
    void CreatePowerFood3()
    {
        int positionX = Random.Range(-21, 21);
        int positionY = Random.Range(12, 19);

        _compTransform.position = new Vector2(positionX, positionY);

        GameObject powerfood3 = Instantiate(PowerFood3, _compTransform.position, _compTransform.rotation);
        powerfood3.GetComponent<PowerFood3>().SetLifeController(LifeController);
        powerfood3.GetComponent<PowerFood3>().SetPuntajeGameManaeger(puntaje);
        powerfood3.GetComponent<PowerFood3>().SetPlayerController(Player);

        Invoke("CreatePowerFood3", TimeSpawnPowerFood3);
    }
}

