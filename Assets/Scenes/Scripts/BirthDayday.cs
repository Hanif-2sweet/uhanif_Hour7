using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirthDayday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        //2nd Loop that output days of birthmonth
        //on separate lines when birthday print "It's my birthday"
        
        int day = 1;
           Debug.Log("Day"+ day);

           if (day < 30) {

            while (day <= 30)
        {

            if (day == 22)
            {
                Debug.Log("It's my birthday!!!" + day);
            }
            else { day++; }
        } 
        }
           Debug.Log("Day"+day);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
