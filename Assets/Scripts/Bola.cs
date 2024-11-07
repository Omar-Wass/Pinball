using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip audioClip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        switch(tag) {
            case "Perder":
                GameManager.instance.GameEnd();
                break;
            case "50_points":
                GameManager.instance.UpdateScore(50,1);
                break;
            case "25_points":
                GameManager.instance.UpdateScore(25,1);
                break;
            case "10_points":
                GameManager.instance.UpdateScore(10,1);
                break;
            case "Flipper":
                GameManager.instance.multiplier = 1;
                break;
            default:
                break;
        }
    }

}
