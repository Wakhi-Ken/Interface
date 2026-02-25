using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IShape trapezium = new Trapezium();
        IShape circle = new Circle();
        IShape nonagon = new Nonagon();

        Debug.Log("Trapezium Area: " + trapezium.CalculateArea());
        Debug.Log("Trapezium Perimeter: " + trapezium.CalculatePerimeter());

        Debug.Log("Circle Area: " + circle.CalculateArea());
        Debug.Log("Circle Perimeter: " + circle.CalculatePerimeter());

        Debug.Log("Nonagon Area: " + nonagon.CalculateArea());
        Debug.Log("Nonagon Perimeter: " + nonagon.CalculatePerimeter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public interface IShape
{
    float CalculateArea();
    float CalculatePerimeter();
}

public class Trapezium : IShape
{

    float base1 = 10f;
    float base2 = 7f;
    float height = 9f;
    float side1 = 4f;
    float side2 = 7f;

    public void CalculateUnknownSides()
    {
        Debug.Log("CalculatingUnknownSides");
    }

    public float CalculateArea()
    {
        return ((base1 + base2) / 2) * height;
    }

    public float CalculatePerimeter()
    {
        return base1 + base2 + side1 + side2;
    }
}

public class Circle : IShape
{

    float radius = 5f;

    public float CalculateArea()
    {
        return Mathf.PI * radius * radius;
    }

    public void CalculateRadius()
    {
        Debug.Log("Calculated Radius is: " + radius);
    }

    public float CalculatePerimeter()
    {
        return 2 * Mathf.PI * radius;
    }
}

public class Nonagon : IShape
{
    int numberOfSides = 9;
    float sideLength = 6f;

    public float CalculateArea()
    {
        return 150f;
    }

    public float CalculatePerimeter()
    {
        return numberOfSides * sideLength;
    }

    public int CalculateNumberOfSides()
    {
        return numberOfSides;
    }
}
