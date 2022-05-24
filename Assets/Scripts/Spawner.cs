using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] drums;
    public Transform[] spawns;
    public float beat = (60/130)*2;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beat)
        {
            GameObject drum = Instantiate(drums[Random.Range(0, 2)], spawns[Random.Range(0, 2)]);
            drum.transform.localPosition = Vector3.zero;
            timer -= beat;
        }
        timer += Time.deltaTime;
    }
    
}
