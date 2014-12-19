using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class LoopMeEventsManager : MonoBehaviour
{
	public static event Action interstitialDidLoadEvent;
	public static event Action interstitialDidFailToLoadAdEvent;
	public static event Action interstitialDidAppearEvent;	
	public static event Action interstitialDidDisappearEvent;
	public static event Action interstitialDidReceiveTapEvent;
	public static event Action interstitialWillLeaveApplicationEvent;
	public static event Action interstitialDidExpireEvent;
	public static event Action interstitialVideoDidReachEndEvent;
	
	void Awake()
	{
		gameObject.name = this.GetType().ToString();
		DontDestroyOnLoad( this );
	}
	
	public void interstitialDidLoadNotification()
	{
		Debug.Log("interstitialDidLoadNotification");
		if( interstitialDidLoadEvent != null )
			interstitialDidLoadEvent();
	}
	
	public void interstitialDidFailToLoadAdNotification() 
	{		
		Debug.Log("interstitialDidFailToLoadAdNotification");
		if( interstitialDidFailToLoadAdEvent != null )
			interstitialDidFailToLoadAdEvent();
	}
	
	public void interstitialDidAppearNotification()
	{
		Debug.Log("interstitialDidAppearNotification");
		if( interstitialDidAppearEvent != null )
			interstitialDidAppearEvent();
	}
	
	public void interstitialDidDisappearNotification()
	{
		Debug.Log("interstitialDidDisappearNotification");
		if( interstitialDidDisappearEvent != null )
			interstitialDidDisappearEvent();
	}
	
	public void interstitialDidReceiveTapNotification()
	{
		Debug.Log("interstitialDidReceiveTapNotification");
		if( interstitialDidReceiveTapEvent != null )
			interstitialDidReceiveTapEvent();
	}
	
	public void interstitialWillLeaveApplicationNotification()
	{
		Debug.Log("interstitialWillLeaveApplicationNotification");
		if( interstitialWillLeaveApplicationEvent != null )
			interstitialWillLeaveApplicationEvent();
	}
	
	public void interstitialDidExpireNotification()
	{
		Debug.Log("interstitialDidExpireNotification");
		if( interstitialDidExpireEvent != null )
			interstitialDidExpireEvent();
	}
		
	public void interstitialVideoDidReachEndNotification()
	{
		Debug.Log("interstitialVideoDidReachEndNotification");
		if( interstitialVideoDidReachEndEvent != null )
			interstitialVideoDidReachEndEvent();
	}
}