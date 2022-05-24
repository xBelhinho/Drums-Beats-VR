using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public LayerMask layer;
    private Vector3 PrevPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward,  out hit, 1, layer))
        {
            Destroy(hit.transform.gameObject);
        }
        PrevPos = transform.position;
    }
}