using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birthday : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
    
     //Output month 1-12 seperate line & when birth month print
    // "It's my birthday month"
    for (int month = 1; month <=12; month++){

        if (month == 11)
            {
                Debug.Log("It's my birthday month!!!");
            }
            else { Debug.Log(month); }
    }

//2nd output days 1-30 when birth day print
         for (int days = 1; days <=30; days++){

            if (days == 22){
            Debug.Log("It's my birthday!!!" + days);}
            else 
            {
            Debug.Log(days);}
        }
       

    }





    



    // Update is called once per frame
    void Update()
    {
     
    }


}
