using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletE2 : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerManager.InstancePlayer.lifeVal--;
        }
        if (other.gameObject.CompareTag("brick2"))
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
