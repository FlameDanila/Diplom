﻿#pragma checksum "..\..\AddEvent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9107FDA07D28447F0A5D2620BFD4E6C3A8D71568904F6AEC281C1BE91467BFF9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Diplom_2022;
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


namespace Diplom_2022 {
    
    
    /// <summary>
    /// AddEvent
    /// </summary>
    public partial class AddEvent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateText;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CostText;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ageText;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox proffessionText;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox timeText;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox venueCombo;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ticketsCount;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameText;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox typeCombo;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
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
            System.Uri resourceLocater = new System.Uri("/Diplom_2022;component/addevent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddEvent.xaml"
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
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\AddEvent.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.addButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DateText = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.CostText = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\AddEvent.xaml"
            this.CostText.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.DigitsTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ageText = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\AddEvent.xaml"
            this.ageText.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.DigitsTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.proffessionText = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\AddEvent.xaml"
            this.proffessionText.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.timeText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.venueCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.ticketsCount = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\AddEvent.xaml"
            this.ticketsCount.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.DigitsTextInput);
            
            #line default
            #line hidden
            return;
            case 9:
            this.nameText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.typeCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\AddEvent.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
