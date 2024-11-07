using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lancador : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        collision.rigidbody.AddForce(-collision.contacts[0].normal*15, ForceMode2D.Impulse);
    }
}

