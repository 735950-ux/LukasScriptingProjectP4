using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{

    public int cupsInTheSink = 67; //creating the variable cupsInTheSink and setting it to 67

    // Start is called before the first frame update
    void Start()
    {
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup");
            cupsInTheSink--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
