using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject net;
    public GameObject player;
    int a = 0;
    public int pol = 0;
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
        if (pol == 5) 
        {
            print("game over");
            Destroy(player);
        }

    }
}
