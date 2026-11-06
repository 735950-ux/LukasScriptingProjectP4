using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    public int numEnemies = 3; //creating the variable numEnemies and setting it to 3

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numEnemies; i++) //creating a for loop that will run as long as i is less than numEnemies
        {
            Debug.Log("Creating Enemy " + (i + 1)); //printing "Enemy Spawned" to the console
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
