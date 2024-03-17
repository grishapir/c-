using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerdvigaetsya : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public float speed = 0.6f;
    private Vector3 per;
    void Start()
    {
        
    }
    void Awake()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        per.x = Input.GetAxis("Horizontal");
        per.z = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + per * speed * Time.deltaTime);







        
    }

}
