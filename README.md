# LoopMe-Unity3D-Plugin #

## Overview ##

LoopMe is the largest mobile video DSP and Ad Network, reaching over 1 billion consumers world-wide. LoopMe’s full-screen video and rich media ad formats deliver more engaging mobile advertising experiences to consumers on smartphones and tablets.

The `loopme-unity3d-plugin` is an extension for `Unity3d`, allowing app developers to monetize apps via the LoopMe ad network.

<p align="center">
<img align="center" src="images/ad_overview.jpg" alt="LoopMe Interstitial Ad">
</p>

If you have questions please contact us at support@loopmemedia.com. 

## Features ##

* Full-screen image interstitials
* Full-screen rich media interstitials
* Preloaded video ads
* In-app ad reward notifications, including video view completed

## Requirements ##

An appKey is required to use the `loopme-unity3d-plugin`. The appKey uniquely identifies your app to the LoopMe ad network. (Example appKey: 7643ba4d53.) To get an appKey visit the **[LoopMe Dashboard](http://loopme.me/)**. 

`loopme-unity3d-plugin` connects to native LoopMe `iOS` & `Android` libraries which control the interstitial ads, requires `Unity3D 3.5.7` or higher, supports a minimum of `Android 4.0 (API Level 14)` and `iOS 6.0` and above.

## Usage ##

Integrating the `loopme-unity3d-plugin` is very simple and should take less than 10 minutes. 

* Download || clone `loopme-unity3d-plugin`
* Open your project in the `Unity3D` editor and import the `loopme-unity3d-plugin.unitypackage`
* Use `loopme-unity3d-plugin`'s main **LoopMeInterstitial** class static methods to create and display interstitial ads:
   * `CreateInterstitial`: this method creates interstitial with specified appKey.
   * `LoadAds`: retrieves ads for previously specified appKey
   * `ShowAds`: makes ads visible on the screen
   * `Destroy`: use this if interstitial is no longer needed
* Add `LoopMeEventsManager.cs` script as a component to your game object in order to receive interstitial ad events:
   * `interstitialDidLoadEvent`: triggered when interstitial has been loaded the ad content
   * `interstitialDidFailToLoadAdEvent`: triggered when interstitial failed to load the ad content
   * `interstitialDidAppearEvent`: triggered when interstitial ad appeared on the screen
   * `interstitialDidDisappearEvent`: triggered when interstitial ad disappeared from the screen
   * `interstitialVideoDidReachEndEvent`: triggered when interstitial video ad has been completely watched
   * `interstitialDidReceiveTapEvent`: triggered when interstitial ad was clicked
* `interstitialDidExpireEvent`: triggered when interstitial ad is expired, it is recommended to re-load

### Android set-up ###

Update `androidManifest.xml` with permissions and activities:

`<activity android:name="com.loopme.AdActivity" android:configChanges="orientation|keyboardHidden|screenSize"
       android:hardwareAccelerated="true"/>        
<activity android:name="com.loopme.AdBrowserActivity" />        
<activity android:name="com.loopme.PlayerActivity" android:configChanges="orientation|keyboardHidden|screenSize"
       android:hardwareAccelerated="true"/>
<uses-permission android:name="android.permission.INTERNET" />
<uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
<uses-permission android:name="android.permission.ACCESS_WIFI_STATE" />
<uses-permission android:name="android.permission.ACCESS_COARSE_LOCATION" />
<uses-permission android:name="android.permission.ACCESS_FINE_LOCATION" />
<uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE" />
<uses-permission android:name="android.permission.VIBRATE" />`

### iOS set-up ###

`loopme-unity3d-plugin` requires **LoopMe iOS SDK** to be added to `XCode` project:

1. Copy the **loopme-ios** folder to the **Library** folder of your `XCode` project
2. Make sure following `frameworks` are added in `Xcode` project's `build phases`
 * `MessageUI.framework`
 * `StoreKit.framework`
 * `AVFoundation.framework`
 * `CoreMedia.framework`
 * `AudioToolbox.framework`
 * `AdSupport.framework`
 * `CoreTelephony.framework`
3. Add following flags to other linker flags in `XCode` project's `build settings`
 * `-ObjC`
 * `-all_load`

## Sample project ##

Check out our `loopme-unity3d-demo` as an example of `loopme-unity3d-plugin` integration:
* open `loopme-unity3d-demo` project in `Unity3d` editor
* assign scripts below to `Main Camera` game object:
  * `LoopMeEventsManager.cs`
  * `LoopMeEventsListener.cs`
  * `Demo.cs`
* Build & run

Note: for `iOS` you still need to perform some changes to just generated `XCode` project, see **iOS set-up** section.

## License ##
LICENSED UNDER THE TERMS OF THE BSD LICENSE, AS SPECIFIED BELOW.

DISCLAIMER: IMPORTANT: THIS LOOPME SOFTWARE IS SUPPLIED TO YOU BY LOOPME LTD. ("LOOPME") IN CONSIDERATION OF YOUR AGREEMENT TO THE TERMS FOUND ON OUR **[WEBSITE](http://www.loopmemedia.com/privacy/)**, 
AND YOUR USE, INSTALLATION, MODIFICATION OR REDISTRIBUTION OF THIS LOOPME SOFTWARE CONSTITUTES ACCEPTANCE OF THESE TERMS. 
IF YOU DO NOT AGREE WITH THESE TERMS, PLEASE DO NOT USE, INSTALL, MODIFY OR REDISTRIBUTE THIS LOOPME SOFTWARE.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, 
OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) 
HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

COPYRIGHT © 2012, LOOPME LTD, ALL RIGHTS RESERVED