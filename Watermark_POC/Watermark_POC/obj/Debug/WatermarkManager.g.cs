﻿#pragma checksum "..\..\WatermarkManager.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5EF1FC64564F348626DC6D1E02B5EBD7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Watermark_POC {
    
    
    /// <summary>
    /// WatermarkManager
    /// </summary>
    public partial class WatermarkManager : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgWm;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtWaterMarkText;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbtnTopLeft;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbtnBottomRight;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbtnBottomLeft;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbtnTopRight;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFontSize;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker Font_Color;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPreview;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTxt;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblOrientation;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblColor;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblFontSize;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider_Opacity;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblOpacity;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblOpacityValue;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbtnCenter;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbtnTop;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbtnLeft;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbtnRight;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbtnBottom;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFontFamily;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\WatermarkManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblFontFamily;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Watermark_POC;component/watermarkmanager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WatermarkManager.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ImgWm = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.txtWaterMarkText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.rdbtnTopLeft = ((System.Windows.Controls.RadioButton)(target));
            
            #line 13 "..\..\WatermarkManager.xaml"
            this.rdbtnTopLeft.Checked += new System.Windows.RoutedEventHandler(this.rdbtn_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rdbtnBottomRight = ((System.Windows.Controls.RadioButton)(target));
            
            #line 14 "..\..\WatermarkManager.xaml"
            this.rdbtnBottomRight.Checked += new System.Windows.RoutedEventHandler(this.rdbtn_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rdbtnBottomLeft = ((System.Windows.Controls.RadioButton)(target));
            
            #line 15 "..\..\WatermarkManager.xaml"
            this.rdbtnBottomLeft.Checked += new System.Windows.RoutedEventHandler(this.rdbtn_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.rdbtnTopRight = ((System.Windows.Controls.RadioButton)(target));
            
            #line 16 "..\..\WatermarkManager.xaml"
            this.rdbtnTopRight.Checked += new System.Windows.RoutedEventHandler(this.rdbtn_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmbFontSize = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.Font_Color = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            return;
            case 9:
            this.btnPreview = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\WatermarkManager.xaml"
            this.btnPreview.Click += new System.Windows.RoutedEventHandler(this.btnPreview_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\WatermarkManager.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.lblTxt = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.lblOrientation = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.lblColor = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.lblFontSize = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            this.slider_Opacity = ((System.Windows.Controls.Slider)(target));
            
            #line 41 "..\..\WatermarkManager.xaml"
            this.slider_Opacity.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slider_Opacity_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 16:
            this.lblOpacity = ((System.Windows.Controls.Label)(target));
            return;
            case 17:
            this.lblOpacityValue = ((System.Windows.Controls.Label)(target));
            return;
            case 18:
            this.rdbtnCenter = ((System.Windows.Controls.RadioButton)(target));
            
            #line 48 "..\..\WatermarkManager.xaml"
            this.rdbtnCenter.Checked += new System.Windows.RoutedEventHandler(this.rdbtn_Checked);
            
            #line default
            #line hidden
            return;
            case 19:
            this.rdbtnTop = ((System.Windows.Controls.RadioButton)(target));
            
            #line 49 "..\..\WatermarkManager.xaml"
            this.rdbtnTop.Checked += new System.Windows.RoutedEventHandler(this.rdbtn_Checked);
            
            #line default
            #line hidden
            return;
            case 20:
            this.rdbtnLeft = ((System.Windows.Controls.RadioButton)(target));
            
            #line 50 "..\..\WatermarkManager.xaml"
            this.rdbtnLeft.Checked += new System.Windows.RoutedEventHandler(this.rdbtn_Checked);
            
            #line default
            #line hidden
            return;
            case 21:
            this.rdbtnRight = ((System.Windows.Controls.RadioButton)(target));
            
            #line 51 "..\..\WatermarkManager.xaml"
            this.rdbtnRight.Checked += new System.Windows.RoutedEventHandler(this.rdbtn_Checked);
            
            #line default
            #line hidden
            return;
            case 22:
            this.rdbtnBottom = ((System.Windows.Controls.RadioButton)(target));
            
            #line 52 "..\..\WatermarkManager.xaml"
            this.rdbtnBottom.Checked += new System.Windows.RoutedEventHandler(this.rdbtn_Checked);
            
            #line default
            #line hidden
            return;
            case 23:
            this.cmbFontFamily = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 24:
            this.lblFontFamily = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

