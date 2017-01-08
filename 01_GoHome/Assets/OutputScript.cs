using UnityEngine;
using System.Collections;

public class OutputScript : MonoBehaviour {

    public Vector2 location;
    public Vector2 homeLocation;

	// Use this for initialization
	void Start () {

        print("Welcome to Go Home!");
    }

    void PrintUpdate(KeyCode kc, Vector2 movementVector)
    {

        if (Input.GetKeyDown(kc)) {
            location = location + movementVector;
            Vector2 pathToHome = homeLocation - location;
            print("Distance to home: " + pathToHome.magnitude);

            if (location == homeLocation)
            {
                print("I am at home!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        PrintUpdate(KeyCode.LeftArrow, new Vector2(-1, 0));
        PrintUpdate(KeyCode.RightArrow, new Vector2(1.0f, 0));
        PrintUpdate(KeyCode.DownArrow, new Vector2(0, -1.0f));
        PrintUpdate(KeyCode.UpArrow, new Vector2(0, 1.0f));
       
    }
}
 
