using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flee : MonoBehaviour
{
    public Kinematic character;
    public GameObject target;

    float maxAcceleration;

    public SteeringOutput getSteering()
    {
        SteeringOutput result = new SteeringOutput();

        // Get the direction to the target
        result.linear = character.transform.position - target.transform.position;

        return result;
    }
}
