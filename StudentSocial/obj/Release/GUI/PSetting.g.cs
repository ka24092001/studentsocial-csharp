﻿#pragma checksum "..\..\..\GUI\PSetting.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "612670EE6244DEC8995BB3882DF6F68EEB30514C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using StudentSocial.GUI;
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


namespace StudentSocial.GUI {
    
    
    /// <summary>
    /// PSetting
    /// </summary>
    public partial class PSetting : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\GUI\PSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkStart;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\GUI\PSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkNoti;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\GUI\PSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label khoidong;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\GUI\PSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spnlAmThanh;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\GUI\PSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radMacDinh;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\GUI\PSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radGiongNoi;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\GUI\PSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radTuyChinh;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\GUI\PSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spnlChonFile;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\GUI\PSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAmThanh;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\GUI\PSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAmThanh2;
        
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
            System.Uri resourceLocater = new System.Uri("/StudentSocial;component/gui/psetting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GUI\PSetting.xaml"
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
            
            #line 10 "..\..\..\GUI\PSetting.xaml"
            ((StudentSocial.GUI.PSetting)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.chkStart = ((System.Windows.Controls.CheckBox)(target));
            
            #line 45 "..\..\..\GUI\PSetting.xaml"
            this.chkStart.Checked += new System.Windows.RoutedEventHandler(this.ChkStart_Checked);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\GUI\PSetting.xaml"
            this.chkStart.Unchecked += new System.Windows.RoutedEventHandler(this.ChkStart_Unchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.chkNoti = ((System.Windows.Controls.CheckBox)(target));
            
            #line 57 "..\..\..\GUI\PSetting.xaml"
            this.chkNoti.Checked += new System.Windows.RoutedEventHandler(this.ChkStart_Checked);
            
            #line default
            #line hidden
            
            #line 58 "..\..\..\GUI\PSetting.xaml"
            this.chkNoti.Unchecked += new System.Windows.RoutedEventHandler(this.ChkStart_Unchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.khoidong = ((System.Windows.Controls.Label)(target));
            
            #line 66 "..\..\..\GUI\PSetting.xaml"
            this.khoidong.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Khoidong_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.spnlAmThanh = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.radMacDinh = ((System.Windows.Controls.RadioButton)(target));
            
            #line 78 "..\..\..\GUI\PSetting.xaml"
            this.radMacDinh.Unchecked += new System.Windows.RoutedEventHandler(this.RadMacDinh_Unchecked);
            
            #line default
            #line hidden
            
            #line 78 "..\..\..\GUI\PSetting.xaml"
            this.radMacDinh.Checked += new System.Windows.RoutedEventHandler(this.RadMacDinh_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.radGiongNoi = ((System.Windows.Controls.RadioButton)(target));
            
            #line 79 "..\..\..\GUI\PSetting.xaml"
            this.radGiongNoi.Unchecked += new System.Windows.RoutedEventHandler(this.RadMacDinh_Unchecked);
            
            #line default
            #line hidden
            
            #line 79 "..\..\..\GUI\PSetting.xaml"
            this.radGiongNoi.Checked += new System.Windows.RoutedEventHandler(this.RadMacDinh_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.radTuyChinh = ((System.Windows.Controls.RadioButton)(target));
            
            #line 80 "..\..\..\GUI\PSetting.xaml"
            this.radTuyChinh.Unchecked += new System.Windows.RoutedEventHandler(this.RadMacDinh_Unchecked);
            
            #line default
            #line hidden
            
            #line 80 "..\..\..\GUI\PSetting.xaml"
            this.radTuyChinh.Checked += new System.Windows.RoutedEventHandler(this.RadMacDinh_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.spnlChonFile = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 10:
            this.txtAmThanh = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 99 "..\..\..\GUI\PSetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.txtAmThanh2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 117 "..\..\..\GUI\PSetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
