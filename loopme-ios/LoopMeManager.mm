//
//  LoopMeManager.m
//  LoopMe
//
//
//  Copyright (c) 2013 LoopMe. All rights reserved.
//

#import "LoopMeManager.h"

UIViewController *UnityGetGLViewController();
void UnityPause( bool shouldPause );
void UnitySendMessage( const char * className, const char * methodName, const char * param );

@class LoopMeManager;
static LoopMeManager *_sharedInstance;

@implementation LoopMeManager

+ (LoopMeManager *)sharedInstance {
    if (_sharedInstance == nil) {
        _sharedInstance = [LoopMeManager new];
    }
    return _sharedInstance;
}

- (void)createInterstitialWithAppKey:(NSString *)appKey {
    self.interstitial = [LoopMeInterstitial interstitialWithAppKey:appKey delegate:self];
}

- (void)loadAds {
    [self.interstitial loadAd];
}

- (void)showAds {
    if (self.interstitial.isReady) {
        [self.interstitial showFromViewController:UnityGetGLViewController()];
    }
}

- (void)destroy {
    [LoopMeInterstitial removeSharedInterstitial:self.interstitial];
    self.interstitial = nil;
}

#pragma mark - LoopMe Interstitial delegate methods

- (void)loopMeInterstitialDidLoadAd:(LoopMeInterstitial *)interstitial {
    UnitySendMessage("LoopMeEventsManager", "interstitialDidLoadNotification", "");
}

- (void)loopMeInterstitialDidAppear:(LoopMeInterstitial *)interstitial {
    UnitySendMessage("LoopMeEventsManager", "interstitialDidAppearNotification", "");
    UnityPause(YES);
}

- (void)loopMeInterstitialDidDisappear:(LoopMeInterstitial *)interstitial {
    UnityPause(NO);
    UnitySendMessage("LoopMeEventsManager", "interstitialDidDisappearNotification", "");
}

- (void)loopMeInterstitial:(LoopMeInterstitial *)interstitial didFailToLoadAdWithError:(NSError *)error {
    UnitySendMessage("LoopMeEventsManager", "interstitialDidFailToLoadAdNotification", "");
}

- (void)loopMeInterstitialDidReceiveTapEvent:(LoopMeInterstitial *)interstitial {
    UnitySendMessage("LoopMeEventsManager", "interstitialDidReceiveTapNotification", "");
}

- (void)loopMeInterstitialWillLeaveApplication:(LoopMeInterstitial *)interstitial {
    UnitySendMessage("LoopMeEventsManager", "interstitialWillLeaveApplicationNotification", "");
}

- (void)loopMeInterstitialDidExpire:(LoopMeInterstitial *)interstitial {
    UnitySendMessage("LoopMeEventsManager", "interstitialDidExpireNotification", "");
}

- (void)loopMeInterstitialVideoDidReachEnd:(LoopMeInterstitial *)interstitial {
    UnitySendMessage("LoopMeEventsManager", "interstitialVideoDidReachEndNotification", "");
}

@end