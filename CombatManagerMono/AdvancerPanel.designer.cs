// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace CombatManagerMono
{
    [Register ("AdvancerPanel")]
    partial class AdvancerPanel
    {
        [Outlet]
        CombatManagerMono.GradientButton OtherButton6 { get; set; }


        [Outlet]
        CombatManagerMono.GradientButton OtherButton5 { get; set; }


        [Outlet]
        CombatManagerMono.GradientButton AddMonsterButton { get; set; }


        [Outlet]
        CombatManagerMono.GradientView RacialView { get; set; }


        [Outlet]
        CombatManagerMono.GradientView SimpleView { get; set; }


        [Outlet]
        CombatManagerMono.GradientView OtherView { get; set; }


        [Outlet]
        CombatManagerMono.GradientView SimpleHeaderView { get; set; }


        [Outlet]
        CombatManagerMono.GradientView RacialHeaderView { get; set; }


        [Outlet]
        CombatManagerMono.GradientView OtherHeaderView { get; set; }


        [Outlet]
        CombatManagerMono.GradientButton AdvancedButton { get; set; }


        [Outlet]
        CombatManagerMono.GradientButton SimpleSizeButton { get; set; }


        [Outlet]
        CombatManagerMono.GradientButton OutsiderButton { get; set; }


        [Outlet]
        CombatManagerMono.GradientButton AugmentSummoningButton { get; set; }


        [Outlet]
        CombatManagerMono.GradientButton RacialHitDieButton { get; set; }


        [Outlet]
        CombatManagerMono.GradientButton RacialBonusButton { get; set; }


        [Outlet]
        CombatManagerMono.GradientButton RacialSizeButton { get; set; }


        [Outlet]
        CombatManagerMono.GradientButton OtherTemplateButton { get; set; }


        [Outlet]
        CombatManagerMono.GradientView AdvancerHeaderView { get; set; }


        [Outlet]
        CombatManagerMono.GradientButton ResetButton { get; set; }


        [Outlet]
        UIKit.UIView OtherTemplateOptionView { get; set; }


        [Outlet]
        CombatManagerMono.GradientButton OtherButton1 { get; set; }


        [Outlet]
        CombatManagerMono.GradientButton OtherButton2 { get; set; }


        [Outlet]
        CombatManagerMono.GradientButton OtherButton3 { get; set; }


        [Outlet]
        CombatManagerMono.GradientButton OtherButton4 { get; set; }


        [Action ("AddMonsterButtonTouchUpInside:")]
        partial void AddMonsterButtonTouchUpInside (Foundation.NSObject sender);


        [Action ("AdvancerHeaderButtonTouchUpInside:")]
        partial void AdvancerHeaderButtonTouchUpInside (Foundation.NSObject sender);


        [Action ("ResetButtonTouchUpInside:")]
        partial void ResetButtonTouchUpInside (Foundation.NSObject sender);

        void ReleaseDesignerOutlets ()
        {
            if (AddMonsterButton != null) {
                AddMonsterButton.Dispose ();
                AddMonsterButton = null;
            }

            if (AdvancedButton != null) {
                AdvancedButton.Dispose ();
                AdvancedButton = null;
            }

            if (AdvancerHeaderView != null) {
                AdvancerHeaderView.Dispose ();
                AdvancerHeaderView = null;
            }

            if (AugmentSummoningButton != null) {
                AugmentSummoningButton.Dispose ();
                AugmentSummoningButton = null;
            }

            if (OtherButton1 != null) {
                OtherButton1.Dispose ();
                OtherButton1 = null;
            }

            if (OtherButton2 != null) {
                OtherButton2.Dispose ();
                OtherButton2 = null;
            }

            if (OtherButton3 != null) {
                OtherButton3.Dispose ();
                OtherButton3 = null;
            }

            if (OtherButton4 != null) {
                OtherButton4.Dispose ();
                OtherButton4 = null;
            }

            if (OtherButton5 != null) {
                OtherButton5.Dispose ();
                OtherButton5 = null;
            }

            if (OtherButton6 != null) {
                OtherButton6.Dispose ();
                OtherButton6 = null;
            }

            if (OtherHeaderView != null) {
                OtherHeaderView.Dispose ();
                OtherHeaderView = null;
            }

            if (OtherTemplateButton != null) {
                OtherTemplateButton.Dispose ();
                OtherTemplateButton = null;
            }

            if (OtherTemplateOptionView != null) {
                OtherTemplateOptionView.Dispose ();
                OtherTemplateOptionView = null;
            }

            if (OtherView != null) {
                OtherView.Dispose ();
                OtherView = null;
            }

            if (OutsiderButton != null) {
                OutsiderButton.Dispose ();
                OutsiderButton = null;
            }

            if (RacialBonusButton != null) {
                RacialBonusButton.Dispose ();
                RacialBonusButton = null;
            }

            if (RacialHeaderView != null) {
                RacialHeaderView.Dispose ();
                RacialHeaderView = null;
            }

            if (RacialHitDieButton != null) {
                RacialHitDieButton.Dispose ();
                RacialHitDieButton = null;
            }

            if (RacialSizeButton != null) {
                RacialSizeButton.Dispose ();
                RacialSizeButton = null;
            }

            if (RacialView != null) {
                RacialView.Dispose ();
                RacialView = null;
            }

            if (ResetButton != null) {
                ResetButton.Dispose ();
                ResetButton = null;
            }

            if (SimpleHeaderView != null) {
                SimpleHeaderView.Dispose ();
                SimpleHeaderView = null;
            }

            if (SimpleSizeButton != null) {
                SimpleSizeButton.Dispose ();
                SimpleSizeButton = null;
            }

            if (SimpleView != null) {
                SimpleView.Dispose ();
                SimpleView = null;
            }
        }
    }
}