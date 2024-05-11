using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    private int turn = 10;

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
       for (int z=0; z<turn; ++z)
        {
            Instantiate(prefab, new Vector3(-3, 2.25f, z), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Whenever we hit the B key we will generate a prefab at the
        // position of the original prefab
        // Whenever we hit the space key, we will generate a prefab at the
        // position of the spawn object that this script is attached to
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
