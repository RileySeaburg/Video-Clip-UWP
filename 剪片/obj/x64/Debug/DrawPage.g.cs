﻿#pragma checksum "C:\Users\于梦凡\Visual studio\有趣的测试\剪片\Video-Clip-UWP\剪片\DrawPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "96737C997AE97F45595FB0A64A26D310"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace 剪片
{
    partial class DrawPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // DrawPage.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    ((global::Windows.UI.Xaml.Controls.Page)element1).SizeChanged += this.Page_SizeChanged;
                }
                break;
            case 2: // DrawPage.xaml line 17
                {
                    this.LeftSplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // DrawPage.xaml line 21
                {
                    this.RootGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // DrawPage.xaml line 201
                {
                    this.RightSplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 5: // DrawPage.xaml line 287
                {
                    this.GridSplitter = (global::Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)(target);
                }
                break;
            case 6: // DrawPage.xaml line 294
                {
                    this.CanvasControl = (global::剪片.Control.MainCanvasControl)(target);
                    ((global::剪片.Control.MainCanvasControl)this.CanvasControl).DragEnter += this.CanvasControl_DragEnter;
                    ((global::剪片.Control.MainCanvasControl)this.CanvasControl).DragOver += this.MainCanvasControl_DragOver;
                    ((global::剪片.Control.MainCanvasControl)this.CanvasControl).Drop += this.CanvasControl_Drop;
                }
                break;
            case 7: // DrawPage.xaml line 302
                {
                    this.TranscoderControl = (global::剪片.Control.TranscoderControl2)(target);
                }
                break;
            case 8: // DrawPage.xaml line 251
                {
                    this.PlayControl = (global::剪片.Control.PlayControl)(target);
                }
                break;
            case 9: // DrawPage.xaml line 253
                {
                    this.ZoomSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 10: // DrawPage.xaml line 258
                {
                    this.SplitButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SplitButton).Tapped += this.SplitButton_Tapped;
                }
                break;
            case 11: // DrawPage.xaml line 260
                {
                    this.SplitShow = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 12: // DrawPage.xaml line 278
                {
                    this.SplitIcon = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
                }
                break;
            case 13: // DrawPage.xaml line 204
                {
                    this.MediaPlayerElement = (global::Windows.UI.Xaml.Controls.MediaPlayerElement)(target);
                }
                break;
            case 14: // DrawPage.xaml line 209
                {
                    this.MediaList = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)this.MediaList).DragItemsStarting += this.MediaList_DragItemsStarting;
                    ((global::Windows.UI.Xaml.Controls.GridView)this.MediaList).SelectionChanged += this.MediaList_SelectionChanged;
                }
                break;
            case 15: // DrawPage.xaml line 240
                {
                    this.RightText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // DrawPage.xaml line 34
                {
                    this.MenuButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.MenuButton).Tapped += this.MenuButton_Tapped;
                }
                break;
            case 17: // DrawPage.xaml line 141
                {
                    this.AddButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 18: // DrawPage.xaml line 145
                {
                    this.AddVideoButton = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.AddVideoButton).Tapped += this.AddVideoButton_Tapped;
                }
                break;
            case 19: // DrawPage.xaml line 150
                {
                    this.AddMusicButton = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.AddMusicButton).Tapped += this.AddMusicButton_Tapped;
                }
                break;
            case 20: // DrawPage.xaml line 155
                {
                    this.AddPicturesButton = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.AddPicturesButton).Tapped += this.AddPicturesButton_Tapped;
                }
                break;
            case 21: // DrawPage.xaml line 161
                {
                    this.AddColorButton = (global::Windows.UI.Xaml.Controls.MenuFlyoutSubItem)(target);
                }
                break;
            case 22: // DrawPage.xaml line 165
                {
                    this.AddColorWhiteButton = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.AddColorWhiteButton).Tapped += this.AddColorWhiteButton_Tapped;
                }
                break;
            case 23: // DrawPage.xaml line 170
                {
                    this.AddColorBlackButton = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.AddColorBlackButton).Tapped += this.AddColorBlackButton_Tapped;
                }
                break;
            case 24: // DrawPage.xaml line 175
                {
                    this.AddColorRedButton = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.AddColorRedButton).Tapped += this.AddColorRedButton_Tapped;
                }
                break;
            case 25: // DrawPage.xaml line 180
                {
                    this.AddColorGreenButton = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.AddColorGreenButton).Tapped += this.AddColorGreenButton_Tapped;
                }
                break;
            case 26: // DrawPage.xaml line 185
                {
                    this.AddColorBlueButton = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.AddColorBlueButton).Tapped += this.AddColorBlueButton_Tapped;
                }
                break;
            case 27: // DrawPage.xaml line 39
                {
                    this.TrimButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.TrimButton).Tapped += this.TrimButton_Tapped;
                }
                break;
            case 28: // DrawPage.xaml line 42
                {
                    this.CopyButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.CopyButton).Tapped += this.CopyButton_Tapped;
                }
                break;
            case 29: // DrawPage.xaml line 45
                {
                    this.RemoveButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.RemoveButton).Tapped += this.RemoveButton_Tapped;
                }
                break;
            case 30: // DrawPage.xaml line 51
                {
                    this.PropertyButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 31: // DrawPage.xaml line 125
                {
                    this.EffectButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.EffectButton).Tapped += this.EffectButton_Tapped;
                }
                break;
            case 32: // DrawPage.xaml line 129
                {
                    this.AudioButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AudioButton).Tapped += this.AudioButton_Tapped;
                }
                break;
            case 33: // DrawPage.xaml line 133
                {
                    this.LayerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.LayerButton).Tapped += this.LayerButton_Tapped;
                }
                break;
            case 34: // DrawPage.xaml line 54
                {
                    this.PropertyFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                    ((global::Windows.UI.Xaml.Controls.Flyout)this.PropertyFlyout).Opened += this.PropertyFlyout_Opened;
                    ((global::Windows.UI.Xaml.Controls.Flyout)this.PropertyFlyout).Closed += this.PropertyFlyout_Closed;
                }
                break;
            case 35: // DrawPage.xaml line 57
                {
                    this.PropertyNullGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 36: // DrawPage.xaml line 61
                {
                    this.PropertyMediaGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 37: // DrawPage.xaml line 68
                {
                    this.PropertyOverlayGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 38: // DrawPage.xaml line 113
                {
                    this.PropertyAudioGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 39: // DrawPage.xaml line 116
                {
                    this.PropertyAudioVolumeSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.PropertyAudioVolumeSlider).ValueChanged += this.PropertyAudioVolumeSlider_ValueChanged;
                }
                break;
            case 40: // DrawPage.xaml line 103
                {
                    this.OverlayUpButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.OverlayUpButton).Tapped += this.OverlayUpButton_Tapped;
                }
                break;
            case 41: // DrawPage.xaml line 106
                {
                    this.OverlayDownButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.OverlayDownButton).Tapped += this.OverlayDownButton_Tapped;
                }
                break;
            case 42: // DrawPage.xaml line 93
                {
                    this.OverlayOpacitySlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.OverlayOpacitySlider).ValueChanged += this.OverlayOpacitySlider_ValueChanged;
                }
                break;
            case 43: // DrawPage.xaml line 89
                {
                    this.OverlayVolumeSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.OverlayVolumeSlider).ValueChanged += this.OverlayVolumeSlider_ValueChanged;
                }
                break;
            case 44: // DrawPage.xaml line 85
                {
                    this.OverlayAudioSlider = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.OverlayAudioSlider).Checked += this.OverlayAudioSlider_Checked;
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.OverlayAudioSlider).Unchecked += this.OverlayAudioSlider_Unchecked;
                }
                break;
            case 45: // DrawPage.xaml line 79
                {
                    this.PropertyOverlayWNumberPicker = (global::剪片.Picker.NumberPicker)(target);
                    ((global::剪片.Picker.NumberPicker)this.PropertyOverlayWNumberPicker).ValueChange += this.PropertyWNumberPicker_ValueChange;
                }
                break;
            case 46: // DrawPage.xaml line 81
                {
                    this.PropertyOverlayHNumberPicker = (global::剪片.Picker.NumberPicker)(target);
                    ((global::剪片.Picker.NumberPicker)this.PropertyOverlayHNumberPicker).ValueChange += this.PropertyHNumberPicker_ValueChange;
                }
                break;
            case 47: // DrawPage.xaml line 73
                {
                    this.PropertyOverlayXNumberPicker = (global::剪片.Picker.NumberPicker)(target);
                    ((global::剪片.Picker.NumberPicker)this.PropertyOverlayXNumberPicker).ValueChange += this.PropertyXNumberPicker_ValueChange;
                }
                break;
            case 48: // DrawPage.xaml line 75
                {
                    this.PropertyOverlayYNumberPicker = (global::剪片.Picker.NumberPicker)(target);
                    ((global::剪片.Picker.NumberPicker)this.PropertyOverlayYNumberPicker).ValueChange += this.PropertyYNumberPicker_ValueChange;
                }
                break;
            case 49: // DrawPage.xaml line 64
                {
                    this.PropertyMediaVolumeSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.PropertyMediaVolumeSlider).ValueChanged += this.PropertyMediaVolumeSlider_ValueChanged;
                }
                break;
            case 50: // DrawPage.xaml line 407
                {
                    this.TranscoderButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.TranscoderButton).Tapped += this.TranscoderButton_Tapped;
                }
                break;
            case 51: // DrawPage.xaml line 337
                {
                    this.HomeButton = (global::Windows.UI.Xaml.Controls.ListViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.ListViewItem)this.HomeButton).Tapped += this.HomeButton_Tapped;
                }
                break;
            case 52: // DrawPage.xaml line 348
                {
                    this.NewButton = (global::Windows.UI.Xaml.Controls.ListViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.ListViewItem)this.NewButton).Tapped += this.NewButton_Tapped;
                }
                break;
            case 53: // DrawPage.xaml line 359
                {
                    this.OpenButton = (global::Windows.UI.Xaml.Controls.ListViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.ListViewItem)this.OpenButton).Tapped += this.OpenButton_Tapped;
                }
                break;
            case 54: // DrawPage.xaml line 370
                {
                    this.SaveButton = (global::Windows.UI.Xaml.Controls.ListViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.ListViewItem)this.SaveButton).Tapped += this.SaveButton_Tapped;
                }
                break;
            case 55: // DrawPage.xaml line 381
                {
                    this.SaveAdButton = (global::Windows.UI.Xaml.Controls.ListViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.ListViewItem)this.SaveAdButton).Tapped += this.SaveAdButton_Tapped;
                }
                break;
            case 56: // DrawPage.xaml line 392
                {
                    this.ExportButton = (global::Windows.UI.Xaml.Controls.ListViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.ListViewItem)this.ExportButton).Tapped += this.ExportButton_Tapped;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

