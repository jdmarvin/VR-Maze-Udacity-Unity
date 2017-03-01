using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	private bool locked = true;

	// Create a boolean value called "opening" that can be checked in Update()
	private bool opening;

	//Create array for sound clips and sound source
	public AudioClip[] soundFiles;
	public AudioSource soundSource;

    void Update() {
		float doorPositionYAxis = transform.position.y;

		// If the door is opening and it is not fully raised
		if (opening && doorPositionYAxis < 8.0f) {
			//play door opening audio clip
			soundSource.clip = soundFiles [1];
			soundSource.Play();

			//animate door opening
			transform.Translate(0, 1.5f * Time.deltaTime, 0);
		}
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
		if (!locked) {
			// Set the "opening" boolean to true
			opening = true;
		} else {
			// Play a sound to indicate the door is locked
			soundSource.clip = soundFiles [0];
			soundSource.Play ();
		}

    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
		locked = false;
    }
}
