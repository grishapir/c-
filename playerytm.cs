using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerytm : MonoBehaviour
{
    GameObject net;
    int speed = 5;
    int score = 0;
    spawner schet;
    // Start is called before the first frame update
    void Start()
    {
        schet = GameObject.Find("spawner").GetComponent<spawner>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position -= new Vector3(0, 1, 0) * Time.deltaTime * speed;
        if (transform.position.y <= -20) 
        {
            schet.pol += 1;
            print(schet.pol);
            Destroy(gameObject);
        }
         
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
