using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Final : MonoBehaviour
{
    

    // Use this for initialization


    float trainASpeed,
     trainBSpeed;
    
    
    


    void Start()
    {
        
        Greetings();
        Calculate(5, 9);
        Convert(12, "feet"); //please use "feet" to convert to feet and "inches" to convert to inches
        Trains(5, 15, 3); // first two are mph, last is time;
        GetAverage();
    }

    public void Greetings()
    {
        string greeting = ("Hello my name is Brandon Miller and the current time is ") + System.DateTime.Now;
        print(greeting);
    }

    public void Calculate(float a, float b)
    {
        float num1 = a,
            num2 = b,
            multiply,
            add,
            subtract,
            devide;


        print(add = num1 + num2);
        print(subtract = num1 - num2);
        print(multiply = num1 * num2);
        print(devide = num1 / num2);
    
    }

    public void GetAverage()
    {
        int sum = 0,
            ave = 0;
        List<int> numbers = new List<int>(new[] { 5, 7, 3, 9, 2 });
        foreach (int x in numbers)
        {
            sum += x;
        }
        ave = sum / numbers.Count;
        print(ave);
         
    }

    public void Convert(float a, string t)
    {
        float num = a;
        string type = t;
        

        if(type == "inches" )
        {
            num = num * 12;
        }
        if (type == "feet")
        {
            num = num / 12;
        }
        print(num);
    }

    public void Trains(float a, float b, float h)
    {
        float west = a,
            east = b,
            hours = h,
            total;


        total = (west * hours) + (east * hours);
        print(total);
    }


}
