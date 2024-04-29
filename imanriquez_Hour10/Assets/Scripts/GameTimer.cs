using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public float totalTime = 180;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (totalTime > 0)
        {
            totalTime -= Time.deltaTime;
        }
        else
        {
            print("Time's up!");
            totalTime = 0;
        }
    }
}
