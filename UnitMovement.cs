using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMovement : MonoBehaviour
{
    Camera cam;
    UnityEngine.AI.NavMeshAgent agent;
    public LayerMask ground;

    
    private void Start()
    {
        cam = Camera.main;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, ground))
            {
                agent.SetDestination(hit.point);
            }
        }
        
    }
}
