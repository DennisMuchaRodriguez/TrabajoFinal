using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerFood3 : Food
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

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
