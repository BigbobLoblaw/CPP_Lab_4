using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PowerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Mario")
        {
            Debug.Log("POWERUP GET!");
            Destroy(this.gameObject);
        }
    }
}
