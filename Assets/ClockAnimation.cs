using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockAnimation : MonoBehaviour {

    public Transform hours, minutes, seconds;
    public bool analog;
    private const float 
        hoursRotation = 360 / 12f,
        minutesRotation = 360 / 60f,
        secondsRotation = 360 / 60f;
	
	// Update is called once per frame
	void Update () {
        if (analog)
        {
            TimeSpan timeSpan = DateTime.Now.TimeOfDay;
            hours.localRotation = Quaternion.Euler(0f, 0f, (float)timeSpan.TotalHours * -hoursRotation);
            minutes.localRotation = Quaternion.Euler(0f, 0f, (float)timeSpan.TotalMinutes * -minutesRotation);
            seconds.localRotation = Quaternion.Euler(0f, 0f, (float)timeSpan.TotalSeconds * -secondsRotation);
        }
        else
        {
            DateTime time = DateTime.Now;
            hours.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -hoursRotation);
            minutes.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -minutesRotation);
            seconds.localRotation = Quaternion.Euler(0f, 0f, time.Second * -secondsRotation);
        }
    }
}
