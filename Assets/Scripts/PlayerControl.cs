using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody rb;

    Vector3 moveVal;
    public float moveS;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        moveVal =  Time.deltaTime * moveS* moveDir ;

    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVal);
    }

   
}

