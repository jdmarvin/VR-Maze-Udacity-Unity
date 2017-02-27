using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject poofAnimation;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
		Object.Instantiate(poofAnimation, transform.position, Quaternion.AngleAxis(90, Vector3.left));
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy (gameObject);
    }

	void Update() {
	
		transform.Rotate(Vector3.right * Time.deltaTime);
	}


}
//Camera.main.transform.position = gameObject.transform.position;