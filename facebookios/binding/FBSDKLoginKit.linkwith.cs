using System;
using ObjCRuntime;

[assembly: LinkWith ("FBSDKLoginKit.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator | LinkTarget.Simulator64, LinkerFlags = "-ObjC", SmartLink = true, ForceLoad = true)]
