﻿#pragma checksum "..\..\Zakaz.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3C3E85EE4DE2F6584E3BACD81F57A86AD46AA829284318B0490010DFAEE41F41"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Sport_Lend;
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


namespace Sport_Lend {
    
    
    /// <summary>
    /// Zakaz
    /// </summary>
    public partial class Zakaz : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 62 "..\..\Zakaz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\Zakaz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock sum_TextBlock;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Zakaz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock discount_TextBlock;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\Zakaz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label OrderLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/Sport_Lend;component/zakaz.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Zakaz.xaml"
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
            
            #line 52 "..\..\Zakaz.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.sum_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.discount_TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 84 "..\..\Zakaz.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ClearBasket_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.OrderLabel = ((System.Windows.Controls.Label)(target));
            
            #line 85 "..\..\Zakaz.xaml"
            this.OrderLabel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Zakaz_Oformlen_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
