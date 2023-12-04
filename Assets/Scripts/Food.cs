using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{

    private float RotationSpeed = 30f;
    private Transform _compTransform;
    public Puntaje puntaje;
    public float Scores;
    void Awake()
    {
        _compTransform = GetComponent<Transform>();
    }
    void Start()
    {

    }
    void Update()
    {
        _compTransform.Rotate(0, 0, RotationSpeed * Time.deltaTime);
    }


     void OnTriggerEnter2D(Collider2D other)
     {
        if (other.gameObject.tag == "Walls" || other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);

        }
        if (other.gameObject.tag == "Player")
        {
            puntaje.SumaPuntos(Scores);
               
        }
     }

    
}



