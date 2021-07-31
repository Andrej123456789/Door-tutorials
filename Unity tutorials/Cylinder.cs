using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    //Active and Destory
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.active = true;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject);
    }
}
