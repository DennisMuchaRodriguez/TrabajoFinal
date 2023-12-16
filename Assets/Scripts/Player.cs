using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    private Transform _compTransform;
    private SpriteRenderer _compSpriteRenderer;
   
    public int Score;
    public float speedX;
    public int directionX;
    public int directionY;
    private float teleportXPosition1 = 22.8f;
    private float newTeleportXPosition1 = -21.30f;
    private float teleportXPosition2 = -22.8f;
    private float newTeleportXPosition2 = 21.30f;
    private Animator _compAnimator;
    public LifeController Controller;
    public MusicController musicController;
    public static Player operator ++(Player a)
    {
        a.speedX = a.speedX + 3;
        return a;
    }
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _compTransform = GetComponent<Transform>();
        _compAnimator = GetComponent<Animator>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
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
            _compSpriteRenderer.flipX = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            directionX = -1;
            _compSpriteRenderer.flipX = true;
        }
        else
        {
            directionX = 0;
        }

        if (_compTransform.position.x > teleportXPosition1)
        {
            _compTransform.position = new Vector2(newTeleportXPosition1, _compTransform.position.y);
        }
        if (_compTransform.position.x < teleportXPosition2)
        {
            _compTransform.position = new Vector2(newTeleportXPosition2, _compTransform.position.y);
        }
        _compAnimator.SetInteger("isWalking", directionX);


       
        Controller.Vidas();
    }
     



}
