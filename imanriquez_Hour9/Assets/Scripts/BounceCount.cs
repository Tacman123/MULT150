using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCount : MonoBehaviour
{
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnTriggerEnter(Collider other)
    {
        count = count + 1;
        print(count);
    }
}
