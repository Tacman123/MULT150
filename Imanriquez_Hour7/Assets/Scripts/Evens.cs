using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sum = 22;

        while (sum <=100)
        {
            print(sum);
            sum = sum + 2;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
