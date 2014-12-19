/**
 * Example of using LoopMeEventsManager events notifications 
 * 
*/

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class EventsListener : MonoBehaviour
{
	void OnEnable()
	{
		LoopMeEventsManager.interstitialDidLoadEvent += interstitialDidLoadEvent;		
		LoopMeEventsManager.interstitialDidFailToLoadAdEvent += interstitialDidFailToLoadAdEvent;
		LoopMeEventsManager.interstitialDidAppearEvent += interstitialDidAppearEvent;
		LoopMeEventsManager.interstitialDidDisappearEvent += interstitialDidDisappearEvent;
		LoopMeEventsManager.interstitialDidReceiveTapEvent += interstitialDidReceiveTapEvent;
		LoopMeEventsManager.interstitialWillLeaveApplicationEvent += interstitialWillLeaveApplicationEvent;
		LoopMeEventsManager.interstitialDidExpireEvent += interstitialDidExpireEvent;
		LoopMeEventsManager.interstitialVideoDidReachEndEvent += interstitialVideoDidReachEndEvent;
	}

	void OnDisable()
	{
		LoopMeEventsManager.interstitialDidLoadEvent -= interstitialDidLoadEvent;
		LoopMeEventsManager.interstitialDidFailToLoadAdEvent -= interstitialDidFailToLoadAdEvent;
		LoopMeEventsManager.interstitialDidAppearEvent -= interstitialDidAppearEvent;
		LoopMeEventsManager.interstitialDidDisappearEvent -= interstitialDidDisappearEvent;		
		LoopMeEventsManager.interstitialDidReceiveTapEvent -= interstitialDidReceiveTapEvent;		
		LoopMeEventsManager.interstitialWillLeaveApplicationEvent -= interstitialWillLeaveApplicationEvent;		
		LoopMeEventsManager.interstitialDidExpireEvent -= interstitialDidExpireEvent;
		LoopMeEventsManager.interstitialVideoDidReachEndEvent -= interstitialVideoDidReachEndEvent;
	}

	void interstitialDidLoadEvent()
	{
		Debug.Log( "LoopMe Interstitial did load ad sucessfully");
	}	
	
	void interstitialDidAppearEvent()
	{
		Debug.Log("LoopMe Interstitial did appear");
	}	
	
	void interstitialDidDisappearEvent()
	{
		Debug.Log("LoopMe Interstitial did disappear");
	}	
	
	void interstitialDidReceiveTapEvent()
	{
		Debug.Log("LoopMe Interstitial did receive tap event");
	}	
	
	void interstitialWillLeaveApplicationEvent()
	{
		Debug.Log("LoopMe Interstitial will leave application");
	}	
	
	void interstitialDidFailToLoadAdEvent() 
	{
		Debug.Log("LoopMe Interstitial did fail to load ad");	
	}

	void interstitialDidExpireEvent() 
	{
		Debug.Log("LoopMe Interstitial expired");	
	}
	
	void interstitialVideoDidReachEndEvent() 
	{
		Debug.Log("LoopMe Interstitial did reach end");	
	}
}