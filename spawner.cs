using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject net;
    int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a++;
        if (a == 40)
        {
            a = 0;
            Instantiate(net, new Vector3(-3, 7, Random.Range(-5, 12)), Quaternion.identity);
        }
        
    }
}
