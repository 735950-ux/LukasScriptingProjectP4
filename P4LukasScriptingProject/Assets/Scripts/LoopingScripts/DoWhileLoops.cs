using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool shouldContinue = false; //creating a boolean variable to use in my loop
        do
        {
            print("Hello World");
        }
        while (shouldContinue == true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
