using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    private Transform _compTransform;
    public int Life;
    public int Score;
    public float speedX;
    public int directionX;
    public int directionY;
    private float teleportXPosition1 = 22.8f;
    private float newTeleportXPosition1 = -21.30f;
    private float teleportXPosition2 = -22.8f;
    private float newTeleportXPosition2 = 21.30f;
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _compTransform = GetComponent<Transform>();
    }
    void Start()
    {
      
    }
    void Update()
    {
        _compTransform.position = new Vector2(_compTransform.position.x + speedX * directionX * Time.deltaTime, _compTransform.position.y);
        
        if (Input.GetKey(KeyCode.D))
        {
            directionX = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            directionX = -1;
        }
        else
        {
            directionX = 0;
        }
        
        if(_compTransform.position.x > teleportXPosition1)
        {
            _compTransform.position = new Vector2(newTeleportXPosition1, _compTransform.position.y);
        }
        if (_compTransform.position.x < teleportXPosition2)
        {
            _compTransform.position = new Vector2(newTeleportXPosition2, _compTransform.position.y);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "FoodBad")
        {
            Life = Life - 1;
            speedX = speedX - 2;
        }
        if (other.gameObject.tag == "Food")
        {
            Score = Score + 1;
        }
    }

   
    
}
