using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.name);
        Destroy(obj: gameObject);
        Instantiate(impactEffect, transform.position, transform.rotation);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject, 2);
    }


}
