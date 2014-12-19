using UnityEngine;
using System.Collections.Generic;

public class Demo : MonoBehaviour
{
	// Test appKey, replace it with your own from the LoopMe dashboard
	private string appKey = "3ee6fc7a45";
	
 	void Start() {
		LoopMeInterstitial.Create(appKey);
	}
	
	void OnGUI()
 	{  
		if (GUI.Button (new Rect(10.0f, 10.0f, 400, 100), "Load Interstitial")) {
			LoopMeInterstitial.LoadAds();
		}
  
 		if (GUI.Button (new Rect(10.0f, 150.0f, 400, 100), "Show Interstitial")) {   
			LoopMeInterstitial.ShowAds();
  		}
 	} 
}
