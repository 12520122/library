﻿#pragma checksum "..\..\..\View\PhieuThuTienPhat.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "770941A33FDA6E9CD42CB3763BC043D8BD46E6277EA8DB98E749998462CD16B7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QuanLyThuVien;
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


namespace QuanLyThuVien {
    
    
    /// <summary>
    /// PhieuThuTienPhat
    /// </summary>
    public partial class PhieuThuTienPhat : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 74 "..\..\..\View\PhieuThuTienPhat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SoTienThu;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\View\PhieuThuTienPhat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btThuTien;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\View\PhieuThuTienPhat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btThoat;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\View\PhieuThuTienPhat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker NgayThu;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyThuVien;component/view/phieuthutienphat.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\PhieuThuTienPhat.xaml"
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
            this.SoTienThu = ((System.Windows.Controls.TextBox)(target));
            
            #line 75 "..\..\..\View\PhieuThuTienPhat.xaml"
            this.SoTienThu.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.SoTienThu_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btThuTien = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.btThoat = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\View\PhieuThuTienPhat.xaml"
            this.btThoat.Click += new System.Windows.RoutedEventHandler(this.btThoat_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NgayThu = ((System.Windows.Controls.DatePicker)(target));
            
            #line 99 "..\..\..\View\PhieuThuTienPhat.xaml"
            this.NgayThu.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NgayThu_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

