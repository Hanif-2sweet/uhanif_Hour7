using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int count = 22;
        Debug.Log("This is my count" + count);
        if (count < 100)
        {
            while (count < 100)
            {
                count = count + 2;
                Debug.Log("This is my count" + count);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

        

    }
}
