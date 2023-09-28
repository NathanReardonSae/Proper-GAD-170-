using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
   //Define range of stats.
   public int minInt = 1;
   public int maxInt = 20;
    

    
    public int myStatPool = 20;
    public int myStrength = Random.Range(1, 20);
    public int myAgility = Random.Range(1, 20);
    public int myIntelligence = Random.Range(1, 20);
    
       

    // Start is called before the first frame update
    void Start()
    {
        int myStrenght = Random.Range(1, 20);
        {
            Debug.Log("My strengh stat is " + myStrength);
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
