using System.Runtime.InteropServices;
using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Analog : MonoBehaviour
{
    // The clock hands work in degrees of rotation, so these statements are to rotate the arms by each period of time
    private const float HoursToDegree = 360f/ 12f;
    private const float MinutesToDegree = 360f/ 60f;
    private const float SecondsToDegree = 360f/ 60f;

    public Transform hours,minutes,seconds;

    // public bool analog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
        //gives access to fractional numbers for the time
        TimeSpan timespan = DateTime.Now.TimeOfDay;

        hours.localRotation = Quaternion.Euler((float)timespan.TotalHours * HoursToDegree,0f,0f);
        minutes.localRotation = Quaternion.Euler((float)timespan.TotalMinutes * MinutesToDegree,0f,0f);

        
        // this variable accesses the dateTime library and sets the time to the current local time
        
        //Each statement allows the clock to rotate based on the specific time
        // the degree conversion variable must be negative since the unity z axis uses a left handed coordinate system
        seconds.localRotation = Quaternion.Euler(time.Second * SecondsToDegree,0f,0f);
    }
}
