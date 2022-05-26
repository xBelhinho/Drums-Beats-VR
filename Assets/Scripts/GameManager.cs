using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private float _timeRemaining;
    private int _numpoints;
    
    public float TimeRemaining
    {
        get { return _timeRemaining; }
        set { _timeRemaining = value; }
    }

    public int NumPoints
    {
        get { return _numpoints; }
        set { _numpoints = value; }
    }

    private float minutes = 1 * 60; //number of minutes * 60 seconds

    // Start is called before the first frame update
    void Start()
    {
        TimeRemaining = minutes;
    }

    // Update is called once per frame
    void Update()
    {
        //Current time of the game
        TimeRemaining -= Time.deltaTime;

        if (TimeRemaining <= 0)
        {

            //Back to Main Menu
            Application.LoadLevel(0);
        }

    }
}
