using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteEffect : MonoBehaviour
{
    public int timer = 3;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timer);//Timer count down before destroying gameobject
    }

    
}
