﻿#pragma checksum "..\..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A2C12F1EC32F847812A4BA298D2E94139B8A3890"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using SistemaControle;
using Syncfusion;
using Syncfusion.SfSkinManager;
using Syncfusion.UI.Xaml.Controls.DataPager;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.RowFilter;
using Syncfusion.UI.Xaml.NavigationDrawer;
using Syncfusion.UI.Xaml.TextInputLayout;
using Syncfusion.UI.Xaml.TreeGrid;
using Syncfusion.UI.Xaml.TreeGrid.Filtering;
using Syncfusion.Windows;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Layout;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace SistemaControle {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel Menu;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btCliente;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btProducao;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btRecebimento;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btRefinanciamento;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAddCliente;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border btResetBorder;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btReset;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Tools.Controls.ColorPickerPalette colorPickerPalette;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Tools.Controls.RibbonTextBox txtPesquisa;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btExtra;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btConfiguracao;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMain;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SistemaControle;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 19 "..\..\..\..\MainWindow.xaml"
            ((SistemaControle.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\..\MainWindow.xaml"
            ((SistemaControle.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Menu = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 3:
            this.btCliente = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\MainWindow.xaml"
            this.btCliente.Click += new System.Windows.RoutedEventHandler(this.btCliente_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btProducao = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\MainWindow.xaml"
            this.btProducao.Click += new System.Windows.RoutedEventHandler(this.btProducao_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btRecebimento = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\MainWindow.xaml"
            this.btRecebimento.Click += new System.Windows.RoutedEventHandler(this.btRecebimento_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btRefinanciamento = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\MainWindow.xaml"
            this.btRefinanciamento.Click += new System.Windows.RoutedEventHandler(this.btRefinanciamento_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btAddCliente = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\MainWindow.xaml"
            this.btAddCliente.Click += new System.Windows.RoutedEventHandler(this.btAddCliente_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btResetBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 9:
            this.btReset = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\..\MainWindow.xaml"
            this.btReset.Click += new System.Windows.RoutedEventHandler(this.btReset_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.colorPickerPalette = ((Syncfusion.Windows.Tools.Controls.ColorPickerPalette)(target));
            
            #line 94 "..\..\..\..\MainWindow.xaml"
            this.colorPickerPalette.SelectedBrushChanged += new System.EventHandler<Syncfusion.Windows.Tools.Controls.SelectedBrushChangedEventArgs>(this.colorPickerPalette_SelectedBrushChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtPesquisa = ((Syncfusion.Windows.Tools.Controls.RibbonTextBox)(target));
            
            #line 102 "..\..\..\..\MainWindow.xaml"
            this.txtPesquisa.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtPesquisa_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btExtra = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\..\MainWindow.xaml"
            this.btExtra.Click += new System.Windows.RoutedEventHandler(this.btExtra_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btConfiguracao = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\..\..\MainWindow.xaml"
            this.btConfiguracao.Click += new System.Windows.RoutedEventHandler(this.btConfiguracao_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.GridMain = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

