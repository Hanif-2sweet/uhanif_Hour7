using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birthday : MonoBehaviour
{
    // Start is called before the first frame update
    // Output month 1-12 seperate line & when birth month print
    // "It's my birthday month"
    void Start()
    {
        //1
        int count = 1;
          Debug.Log(count);

       while (count < 12)
        {
            if (count == 11)
            {
                Debug.Log("It's my birthday month!!!");
            }
            else { count++; }
        }
          Debug.Log(count);


    }



    // Update is called once per frame
    void Update()
    {
     
    }


}
