using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapss : MonoBehaviour
{

    public PlayerMovement Player;
    public void OnTriggerEnter2D(Collider c)
    {
        if(c.CompareTag("Player"))
        {
            Player.Die();
            Debug.Log("Mokad");
        }
    }
}
