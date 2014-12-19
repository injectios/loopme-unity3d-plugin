//
//  LoopMeManager.h
//  LoopMe
//
//  Copyright (c) 2013 LoopMe. All rights reserved.
//

#import "LoopMeManager.h"

void LoopMeBinding_createInterstitial(const char *appKey) {
    NSString *sAppKey = [NSString stringWithUTF8String:appKey];
    [[LoopMeManager sharedInstance] createInterstitialWithAppKey:sAppKey];
}

void LoopMeBinding_loadAds() {
    [[LoopMeManager sharedInstance] loadAds];
}

void LoopMeBinding_showAds() {
    [[LoopMeManager sharedInstance] showAds];
}

void LoopMeBinding_destroy() {
    [[LoopMeManager sharedInstance] destroy];
}