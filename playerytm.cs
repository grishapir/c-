using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerytm : MonoBehaviour
{
    GameObject net;
    int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 1, 0) * Time.deltaTime * speed;
        if (transform.position.y <= -20) 
        {
            Destroy(gameObject);
        }
    }
}
