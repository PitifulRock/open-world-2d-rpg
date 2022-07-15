using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraight : MonoBehaviour
{
    public float speed;
    public float lifetime;

    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.right * speed);
        GetComponent<Animator>().speed = lifetime;
        GetComponent<AudioSource>().pitch = Random.Range(1f, 1.2f);
    }

    void DestroySelf()
    {
        Destroy(gameObject);
    }
}
