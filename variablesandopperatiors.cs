using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variablesandopperatiors : MonoBehaviour {
    private const double PIE = 3.14159265;
    private double rad = 5,
        width = 7,
        length= 15,
        height = 5,
        tBase = 15,
        volume = 0,
        diameter = 0,
        circumference = 0,
        perimeter = 0,
        area = 0,
        rArea = 0,
        tArea = 0;
    /*
    here is my understanding of variables and opperators, pretty much the same as normal math with the exception of 
    the modulus opperator. create meaning variable names and then follow the order of opperations when doing math. that is about it.
    */

    // Use this for initialization
    void Start () {
        // find the diameter of a circle
        diameter = 2 * rad;
        print("The diameter of the circle with a radius of " + rad +" is " + diameter);

        // find the circumference of a circle
        circumference = 2 * PIE * rad;
        print("The circumference of a circle with a radius of " + rad + " is " + circumference);

        // area of a circle
        area = PIE * (rad * rad);
        print("the area of a circle with a radius of " + rad + " is " + area);

        //volume of a sphere
        volume = (4.0 / 3.0) * PIE * (rad * rad * rad);
        print("the volume of a sphere with a radius of " + rad + " is " + volume);

        //find perimeter of a rectangle
        perimeter = 2 * (length + width);
        print("the perimeter of a rectangle with a width of " + width + " and a length of " + length + " is " + perimeter);

        //find the area of a rectangle
        rArea = width * length;
        print("the area of a rectangle with a width of " + width + " and a length of " + length + " is " + rArea);

        //find the area of a triangle
        tArea = (tBase * height) / 2;
        print("the area of a triangle with a base of " + tBase + " and a height of " + height + " is " + tArea);
		
	}
	

}
