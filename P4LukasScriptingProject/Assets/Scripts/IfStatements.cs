using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    //creating my variables for the script
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5.0f;
    }


    void TemperatureTest()
    {
        //this if statement checks if the coffee temperature is greater than the hot limit temperature
        if (coffeeTemperature > hotLimitTemperature)
        {
            Debug.Log("Coffee is too hot!");
        }
        //this else if statement checks if the coffee temperature is less than the cold limit temperature
        else if (coffeeTemperature < coldLimitTemperature)
        {
            Debug.Log("Coffee is too cold!");
        }
        //this else statement is used if the coffee temperature is neither too hot nor too cold
        else
        {
            Debug.Log("Coffee is just right.");
        }
    }
}
