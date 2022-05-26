using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Needed for UI functions

public class UpdateUI : MonoBehaviour
{
    [SerializeField]
    private Text pointLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get the poins and converted to string for the text
        pointLabel.text = GameManager.Instance.NumPoints.ToString();
    }
}
