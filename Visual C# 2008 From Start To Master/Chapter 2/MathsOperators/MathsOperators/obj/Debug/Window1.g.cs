﻿#pragma checksum "..\..\Window1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7E20D5D83A0266ABC0ED7873856DE863"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3603
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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


namespace MathsOperators {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label lhs;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label rhs;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\Window1.xaml"
        internal System.Windows.Controls.TextBox lhsOperand;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Window1.xaml"
        internal System.Windows.Controls.TextBox rhsOperand;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Window1.xaml"
        internal System.Windows.Controls.StackPanel operators;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Window1.xaml"
        internal System.Windows.Controls.RadioButton addition;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Window1.xaml"
        internal System.Windows.Controls.RadioButton subtraction;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Window1.xaml"
        internal System.Windows.Controls.RadioButton multiplication;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Window1.xaml"
        internal System.Windows.Controls.RadioButton division;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Window1.xaml"
        internal System.Windows.Controls.RadioButton remainder;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button calculate;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label expressionLabel;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Window1.xaml"
        internal System.Windows.Controls.TextBox expression;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label resultLabel;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Window1.xaml"
        internal System.Windows.Controls.TextBox result;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button quit;
        
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
            System.Uri resourceLocater = new System.Uri("/MathsOperators;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lhs = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.rhs = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lhsOperand = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.rhsOperand = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.operators = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.addition = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.subtraction = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.multiplication = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.division = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 10:
            this.remainder = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 11:
            this.calculate = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Window1.xaml"
            this.calculate.Click += new System.Windows.RoutedEventHandler(this.calculateClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.expressionLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.expression = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.resultLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            this.result = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.quit = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Window1.xaml"
            this.quit.Click += new System.Windows.RoutedEventHandler(this.quitClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}