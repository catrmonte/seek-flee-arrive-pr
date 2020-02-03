using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek
{
    public Kinematic character; 
    public GameObject target; 

    float maxAcceleration;

    public SteeringOutput getSteering()
    {
        SteeringOutput result = new SteeringOutput();

        // Get the direction to the target
        result.linear = target.transform.position - character.transform.position;

        return result;
    }
}
