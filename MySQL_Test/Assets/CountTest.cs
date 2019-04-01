using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountTest : MonoBehaviour {

	void Start () {
        int x = 0;
        for (int i = 1; i < 100; i = i + 2)
        {
            x = x + i;
        }
        Debug.Log(x+"數學公式:"+ (1 + 99) * 50 / 2);

        //*****************************************************************

        int a = 0;
        int b = 0;
        if (a == 1)
        {
            b = 2;       
        }
        else if (a == 4)
        {
            b = 8;
        }
        else if (a == 7)
        {
            b = 14;
        }
        switch (a){
            case 1:
                b = 2;
                break;
            case 4:
                b = 8;
                break;
            case 7:
                b = 14;
                break;
        }

      
    }
}
