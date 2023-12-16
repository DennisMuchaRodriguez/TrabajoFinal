using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadFood : Food
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.speedX = player.speedX - 2;
            Controller.Life = Controller.Life - 1;
            player.musicController.PlayMusic();
            puntaje.SumaPuntos(Scores);
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Walls")
        { 
            Destroy(this.gameObject);
        }
    }
 
}