using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class LoopMeAndroidBinding {
	
	private static IntPtr LoopMeClass;	
	private static IntPtr LoadPtr;	
	private static IntPtr ShowPtr;	
	private static IntPtr DestroyPtr;
	private static int SetAppKeyPtr;
	
	public static void CreateInterstitial(String appKey) {
		
		#if UNITY_ANDROID && !UNITY_EDITOR	
		JavaVM.AttachCurrentThread();        
		//Get current activity
		IntPtr cls_Activity     = JNI.FindClass("com/unity3d/player/UnityPlayer");
		int fid_Activity        = JNI.GetStaticFieldID(cls_Activity, "currentActivity", "Landroid/app/Activity;");
		IntPtr obj_Activity     = JNI.GetStaticObjectField(cls_Activity, fid_Activity);
		
		
		//Create LoopMeUnity instance
		IntPtr cls_LoopMeClass    = JNI.FindClass("com/loopme/LoopMeInterstitialUnity");  
		int constructor_LoopMe    = JNI.GetMethodID(cls_LoopMeClass, "<init>", "(Landroid/app/Activity;)V");
		
		IntPtr obj_LoopMeClass    = JNI.NewObject(cls_LoopMeClass, constructor_LoopMe, obj_Activity);
		LoopMeClass               = JNI.NewGlobalRef(obj_LoopMeClass);
		
		LoadPtr = AndroidJNI.GetMethodID(cls_LoopMeClass, "load", "()V");
		SetAppKeyPtr = JNI.GetMethodID(cls_LoopMeClass, "setAppKey", "(Ljava/lang/String;)V");
		ShowPtr = AndroidJNI.GetMethodID(cls_LoopMeClass, "show", "()V");
		DestroyPtr = AndroidJNI.GetMethodID(cls_LoopMeClass, "destroy", "()V");
		
		JNI.CallVoidMethod(LoopMeClass, SetAppKeyPtr, AndroidJNI.NewStringUTF(appKey));	
		
		#endif
	}
	
	public static void ShowAds()
	{
		
		#if UNITY_ANDROID && !UNITY_EDITOR
		JavaVM.AttachCurrentThread();
		jvalue[] args = new jvalue[] {};
		AndroidJNI.CallVoidMethod(LoopMeClass, ShowPtr, args);
		#endif
	}
	
	public static void LoadAds() {
		
		#if UNITY_ANDROID && !UNITY_EDITOR
		JavaVM.AttachCurrentThread();
		jvalue[] args = new jvalue[] {};
		AndroidJNI.CallVoidMethod(LoopMeClass, LoadPtr, args);
		#endif			
	}
	
	public static void Destroy() {
		
		#if UNITY_ANDROID && !UNITY_EDITOR
		JavaVM.AttachCurrentThread();
		jvalue[] args = new jvalue[] {};
		AndroidJNI.CallVoidMethod(LoopMeClass, DestroyPtr, args);
		#endif			
	}
	
	
	#if UNITY_ANDROID && !UNITY_EDITOR
	public static jvalue ConvertStringToJvalue(string str)
	{
		jvalue val = new jvalue();
		val.l = AndroidJNI.NewStringUTF(str);
		return val;
	}
	#endif		
}