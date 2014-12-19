using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class LoopMeiOSBinding {
		
	[DllImport("__Internal")]	
	private static extern void LoopMeBinding_createInterstitial(string appKey);			
	
	public static void CreateInterstitial(string appKey) 
	{
#if UNITY_IPHONE && !UNITY_EDITOR
		LoopMeBinding_createInterstitial(appKey);
#endif
	}	

	[DllImport("__Internal")]	
	private static extern void LoopMeBinding_loadAds();
		
	public static void LoadAds()
	{
#if UNITY_IPHONE && !UNITY_EDITOR
		LoopMeBinding_loadAds();
#endif
	}	
	
	[DllImport("__Internal")]	
	private static extern void LoopMeBinding_showAds();			

	public static void ShowAds() 
	{
#if UNITY_IPHONE && !UNITY_EDITOR
		LoopMeBinding_showAds();
#endif
	}	

	[DllImport("__Internal")]	
	private static extern void LoopMeBinding_destroy();			
	
	public static void Destroy() 
	{
#if UNITY_IPHONE && !UNITY_EDITOR
		LoopMeBinding_destroy();
#endif
	}	
}