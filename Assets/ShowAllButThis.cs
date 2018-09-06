using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ShowAllButThis : MonoBehaviour, ITrackableEventHandler
{
    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
       
    }

    // Use this for initialization
    private TrackableBehaviour mTrackableBehaviour;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
