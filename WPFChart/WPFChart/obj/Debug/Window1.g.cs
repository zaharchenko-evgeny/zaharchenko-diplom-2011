﻿#pragma checksum "..\..\Window1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2033E5D7246233DF38F8ACE0450EE40B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
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


namespace WPFChart3D {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Viewport3D mainViewport;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Media3D.OrthographicCamera camera;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Media3D.ModelVisual3D Light1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Media3D.ModelVisual3D Light2;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Media3D.ModelVisual3D Light3;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvasOn3D;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock statusPane;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas controlPane;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox gridNo;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button surfaceButton;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dataNo;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxShape;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button scatterButton;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelVertNo;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelTriNo;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFChart;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\Window1.xaml"
            ((WPFChart3D.Window1)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.OnKeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mainViewport = ((System.Windows.Controls.Viewport3D)(target));
            return;
            case 3:
            this.camera = ((System.Windows.Media.Media3D.OrthographicCamera)(target));
            return;
            case 4:
            this.Light1 = ((System.Windows.Media.Media3D.ModelVisual3D)(target));
            return;
            case 5:
            this.Light2 = ((System.Windows.Media.Media3D.ModelVisual3D)(target));
            return;
            case 6:
            this.Light3 = ((System.Windows.Media.Media3D.ModelVisual3D)(target));
            return;
            case 7:
            this.canvasOn3D = ((System.Windows.Controls.Canvas)(target));
            
            #line 52 "..\..\Window1.xaml"
            this.canvasOn3D.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.OnViewportMouseUp);
            
            #line default
            #line hidden
            
            #line 53 "..\..\Window1.xaml"
            this.canvasOn3D.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnViewportMouseDown);
            
            #line default
            #line hidden
            
            #line 54 "..\..\Window1.xaml"
            this.canvasOn3D.MouseMove += new System.Windows.Input.MouseEventHandler(this.OnViewportMouseMove);
            
            #line default
            #line hidden
            return;
            case 8:
            this.statusPane = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.controlPane = ((System.Windows.Controls.Canvas)(target));
            return;
            case 10:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.gridNo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.surfaceButton = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\Window1.xaml"
            this.surfaceButton.Click += new System.Windows.RoutedEventHandler(this.surfaceButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.dataNo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.checkBoxShape = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 16:
            this.scatterButton = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\Window1.xaml"
            this.scatterButton.Click += new System.Windows.RoutedEventHandler(this.scatterButton_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.labelVertNo = ((System.Windows.Controls.Label)(target));
            return;
            case 18:
            this.labelTriNo = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

