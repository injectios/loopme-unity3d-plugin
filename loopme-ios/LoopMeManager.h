//
//  LoopMeManager.h
//  LoopMe
//
//  Copyright (c) 2013 LoopMe. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "LoopMeInterstitial.h"

@interface LoopMeManager : NSObject <LoopMeInterstitialDelegate>
@property (nonatomic, strong) LoopMeInterstitial *interstitial;

+ (LoopMeManager *)sharedInstance;
- (void)createInterstitialWithAppKey:(NSString *)appKey;
- (void)loadAds;
- (void)showAds;
- (void)destroy;

@end
