using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{

    public float RotationSpeed = 30f;
    private Transform _compTransform;
    private Rigidbody2D _compRigidbody;
    public Puntaje puntaje;
    public Player player;
    public LifeController Controller;
    public float SpeedY;
    public float Scores;
    void Awake()
    {
        _compTransform = GetComponent<Transform>();
        _compRigidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }
    void Update()
    {
        _compTransform.Rotate(0, 0, RotationSpeed * Time.deltaTime);
    }
    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(0, SpeedY);
    }

    void OnTriggerEnter2D(Collider2D other)
     {
        if (other.gameObject.tag == "Walls")
        {
            Controller.Life = Controller.Life - 1;
            puntaje.SumaPuntos(-Scores);
            Destroy(this.gameObject);

        }
        if (other.gameObject.tag == "Player")
        {
            player.musicController.PlayMusic();
            puntaje.SumaPuntos(Scores);
            Destroy(this.gameObject);
        }
     }
    public void SetPuntajeGameManaeger(Puntaje puntos)
    {
        puntaje = puntos;
    }

    public void SetLifeController(LifeController LifeController)
    {
        Controller = LifeController;
    }
    public void SetPlayerController(Player Player)
    {
        player = Player;
    }
}



