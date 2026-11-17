using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    public int alpha = 5; //adding a public variable to the class

    private int beta = 0; //adding a private variable to the class
    private int gamma = 5;

    private AnotherClass myOtherClass; //add access to another class

    // Start is called before the first frame update
    void Start()
    {
        alpha = 29; //change the starting value of alpha

        myOtherClass = new AnotherClass(); //I can change or access another class
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);

        // I am going to use the method in another class
    }

    void ExampleMethod(int pens, int crayons)
    {
        int answer = pens * crayons * alpha;
        Debug.Log("The answer is: " + answer); //print the answer to the console
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("The value of alpha is: " + alpha);
    }
}
