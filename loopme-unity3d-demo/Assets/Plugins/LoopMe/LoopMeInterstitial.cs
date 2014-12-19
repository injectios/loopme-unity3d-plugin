using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
[System.Serializable]

public class LoopMeInterstitial : MonoBehaviour {
	
	public static void Create(String appKey) {				
		#if UNITY_ANDROID && !UNITY_EDITOR
			LoopMeAndroidBinding.CreateInterstitial(appKey);
		#elif UNITY_IOS && !UNITY_EDITOR
			LoopMeiOSBinding.CreateInterstitial(appKey);
		#endif	
	}

	/*
	 * Retrieve ads for specified appKey
	 */
	public static void LoadAds() {		
		#if UNITY_ANDROID && !UNITY_EDITOR
			LoopMeAndroidBinding.LoadAds();		
		#elif UNITY_IOS && !UNITY_EDITOR
			LoopMeiOSBinding.LoadAds();
		#endif
	}

	/*
	 * Show ads in case it was sucessfully retrieved
	 */
	public static void ShowAds() {		
		#if UNITY_ANDROID && !UNITY_EDITOR
			LoopMeAndroidBinding.ShowAds();		
		#elif UNITY_IOS && !UNITY_EDITOR
			LoopMeiOSBinding.ShowAds();
		#endif
	}

	/*
	 * Destroy if it is no longer needed  
	 */
	public static void Destroy() {		
		#if UNITY_ANDROID && !UNITY_EDITOR
			LoopMeAndroidBinding.Destroy();
		#elif UNITY_IOS && !UNITY_EDITOR
			LoopMeiOSBinding.Destroy();
		#endif
	}
	
}