using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drum : MonoBehaviour
{
    public LayerMask layer;

    //Check for collision and the layer that hit it
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.layer == layer)
        {
            Point();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 2;
    }

    private void Point()
    {
        GameManager.Instance.NumPoints++;
        Destroy(gameObject);
    }
}
