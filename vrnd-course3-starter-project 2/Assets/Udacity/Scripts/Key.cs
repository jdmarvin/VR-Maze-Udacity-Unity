using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public bool keyCollected;
	public GameObject buildingDoor;

	void Update()
	{
		//Key Floating Animation
		transform.Translate (0, 0.02f * Mathf.Sin(Time.time * 4.0f), 0, Space.World);
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
		Object.Instantiate(keyPoof, transform.position, Quaternion.AngleAxis(90, Vector3.left));

        // Call the Unlock() method on the Door
		buildingDoor.GetComponent<Door>().Unlock();

        // Set the Key Collected Variable to true
		keyCollected = true;

        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy (gameObject);
    }

}
