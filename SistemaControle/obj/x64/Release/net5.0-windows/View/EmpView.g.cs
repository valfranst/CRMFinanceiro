﻿#pragma checksum "..\..\..\..\..\View\EmpView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72BCBD4C39E87BC5003847E9B9A5C70E00895202"
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
using SistemaControle.Model;
using SistemaControle.View;
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


namespace SistemaControle.View {
    
    
    /// <summary>
    /// EmpView
    /// </summary>
    public partial class EmpView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 57 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer SV_EmprestimoView;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush btImagem;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nomeClienteTxt;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label cpfTxt;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label telefoneTxt;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label totalDividaTxt;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btVoltarClienteView;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btNovoEmprestimo;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DG_EmprestimoView;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn CodEmprestimoColumn;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn DataCadastroColumn;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn NomeAtendenteColumn;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn ValorColumn;
        
        #line default
        #line hidden
        
        
        #line 226 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn TaxaColumn;
        
        #line default
        #line hidden
        
        
        #line 239 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn FormaPagamentoColumn;
        
        #line default
        #line hidden
        
        
        #line 251 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn ValorTotalColumn;
        
        #line default
        #line hidden
        
        
        #line 264 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn StatusEmprestimoColumn;
        
        #line default
        #line hidden
        
        
        #line 292 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn TotalRefinanciadoColumn;
        
        #line default
        #line hidden
        
        
        #line 305 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn ComplementoColumn;
        
        #line default
        #line hidden
        
        
        #line 342 "..\..\..\..\..\View\EmpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn IdEmprestimoColumn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SistemaControle;component/view/empview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\EmpView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 13 "..\..\..\..\..\View\EmpView.xaml"
            ((SistemaControle.View.EmpView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SV_EmprestimoView = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 3:
            this.button = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.btImagem = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 5:
            this.nomeClienteTxt = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.cpfTxt = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.telefoneTxt = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.totalDividaTxt = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.btVoltarClienteView = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\..\..\..\View\EmpView.xaml"
            this.btVoltarClienteView.Click += new System.Windows.RoutedEventHandler(this.btVoltarClienteView_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btNovoEmprestimo = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\..\..\View\EmpView.xaml"
            this.btNovoEmprestimo.Click += new System.Windows.RoutedEventHandler(this.btNovoEmprestimo_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.DG_EmprestimoView = ((System.Windows.Controls.DataGrid)(target));
            
            #line 132 "..\..\..\..\..\View\EmpView.xaml"
            this.DG_EmprestimoView.LoadingRowDetails += new System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs>(this.DG_EmprestimoView_LoadingRowDetails);
            
            #line default
            #line hidden
            
            #line 133 "..\..\..\..\..\View\EmpView.xaml"
            this.DG_EmprestimoView.PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.dataGrid_MouseWheel);
            
            #line default
            #line hidden
            
            #line 133 "..\..\..\..\..\View\EmpView.xaml"
            this.DG_EmprestimoView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DG_EmprestimoView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.CodEmprestimoColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 13:
            this.DataCadastroColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 14:
            this.NomeAtendenteColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 15:
            this.ValorColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 16:
            this.TaxaColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 17:
            this.FormaPagamentoColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 18:
            this.ValorTotalColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 19:
            this.StatusEmprestimoColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 20:
            this.TotalRefinanciadoColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 21:
            this.ComplementoColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 24:
            this.IdEmprestimoColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 22:
            
            #line 321 "..\..\..\..\..\View\EmpView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AtualizarEmprestimo_Click);
            
            #line default
            #line hidden
            break;
            case 23:
            
            #line 333 "..\..\..\..\..\View\EmpView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExcluirEmprestimo_Click);
            
            #line default
            #line hidden
            break;
            case 25:
            
            #line 356 "..\..\..\..\..\View\EmpView.xaml"
            ((Syncfusion.UI.Xaml.Grid.SfDataGrid)(target)).QueryCoveredRange += new System.EventHandler<Syncfusion.UI.Xaml.Grid.GridQueryCoveredRangeEventArgs>(this.parcelaDG_QueryCoveredRange);
            
            #line default
            #line hidden
            
            #line 357 "..\..\..\..\..\View\EmpView.xaml"
            ((Syncfusion.UI.Xaml.Grid.SfDataGrid)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.parcelaDG_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 360 "..\..\..\..\..\View\EmpView.xaml"
            ((Syncfusion.UI.Xaml.Grid.SfDataGrid)(target)).CurrentCellEndEdit += new System.EventHandler<Syncfusion.UI.Xaml.Grid.CurrentCellEndEditEventArgs>(this.parcelaDG_CurrentCellEndEdit);
            
            #line default
            #line hidden
            break;
            case 26:
            
            #line 395 "..\..\..\..\..\View\EmpView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btAtualizarParcela_Click);
            
            #line default
            #line hidden
            break;
            case 27:
            
            #line 407 "..\..\..\..\..\View\EmpView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btExcluirParcela_Click);
            
            #line default
            #line hidden
            break;
            case 28:
            
            #line 420 "..\..\..\..\..\View\EmpView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btAnteciparRefi_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

