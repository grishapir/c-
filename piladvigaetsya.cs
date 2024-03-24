using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class piladvigaetsya : MonoBehaviour
{
    GameObject player;
    public GameObject pila;
    GameObject[] a;
    int speed;
    Vector3[] vectora;
    // Start is called before the first frame update
    void Start()
    {
        a = new GameObject[10];
        vectora = new Vector3[10];
        for (int i = 0; i < 10; i ++) 
        {
            a[i] = Instantiate(pila, new Vector3(i * 2, 0.5f, -4), Quaternion.identity);
            speed = Random.Range(1, 10);
            vectora[i] = Vector3.forward * Time.deltaTime * speed;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        for (int j = 0;j < a.Length;j ++) 
        {
            
            a[j].transform.position += vectora[j];
            if (a[j].transform.position.z < -7 || a[j].transform.position.z > -2) 
            {
                vectora[j] *= -1;
            }
            
        }
    }
}

