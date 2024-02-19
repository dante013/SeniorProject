using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build_base : MonoBehaviour
{
    public GameObject base_blueprint;
    
    public void spawn_base_blueprint()
    {
        Instantiate(base_blueprint);
    }
}
