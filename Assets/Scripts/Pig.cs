﻿using UnityEngine;

public class Pig : MonoBehaviour
{
    public GameObject Smoke;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 5f)
        {
            Destroy();
        }
    }

    private void Destroy()
    {
        GameObject smoke = Instantiate(Smoke, transform.position, Quaternion.identity);
        Destroy(smoke, 3);
        Destroy(gameObject);
    }
}