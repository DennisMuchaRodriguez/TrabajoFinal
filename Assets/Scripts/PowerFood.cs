using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerFood : Food
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            player++;
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
