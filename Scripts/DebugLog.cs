using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Generate a float withing a specific range.
       
        float randomfloat = Random.Range(1f, 10f);
        {
            Debug.Log("Random Float:" + randomfloat);
        }

        if (randomfloat == 1) // if random float is exactly one display this message.
        {
            Debug.Log("The Number was exactly one");
        }
        if (randomfloat >3)
        {
            Debug.Log("The Number was greater than 3");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
