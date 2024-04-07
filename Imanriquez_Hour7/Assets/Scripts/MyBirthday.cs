using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int month = 1;
        int day = 1;

        while (month <= 12)
        {
            if (month != 3)
            {
                print(month);
            }
            else if (month == 3)
            {
                while (day <= 31)
                {
                    if (day != 19)
                    {
                        print(day);
                    }
                    else if (day == 19)
                    {
                        print("It's my birthday");
                    }
                    day = day + 1;
                }
            }
            month = month + 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
