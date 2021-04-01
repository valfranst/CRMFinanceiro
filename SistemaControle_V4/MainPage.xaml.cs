using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x416

namespace SistemaControle_V4
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        private NavigationViewItem _lastItem;

        private readonly List<(string Tag, Type Page)> _pages = new List<(string Tag, Type Page)>
        {
            ("ClienteListView", typeof(ClienteListView)),
            ("ProducaoView", typeof(ProducaoView)),
            ("RecebimentoView", typeof(RecebimentoView)),
            ("RefinanciamentoView", typeof(RefinanciamentoView)),

            ("ClienteCadastroView", typeof(ClienteCadastroView)),
            ("ClienteAplicacaoView", typeof(ClienteAplicacaoView)),
            ("CameraView", typeof(CameraView)),
            ("ListasView", typeof(ListasView)),
            ("ParcelaAddView", typeof(ParcelaAddView)),
        };


        public MainPage()
        {               
            this.InitializeComponent();              
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //iniciarClientes();
            Conteudo.Navigated += On_Navigated;
            Navegacao.SelectedItem = Navegacao.MenuItems[0];
            Navegacao_Navigate("ClienteListView", new Windows.UI.Xaml.Media.Animation.EntranceNavigationTransitionInfo());
        }


        //private void Navegacao_OnItemInvoked(NavigationView sender,  NavigationViewItemInvokedEventArgs args)
        //{
        //    var item = args.InvokedItemContainer as NavigationViewItem;

        //    if (item == null || item == _lastItem) return;

        //    var clickedView = item.Tag?.ToString() ?? "SettingsView";
        //    _lastItem = item;

        //    if (args.IsSettingsInvoked) Conteudo.Navigate(typeof(SettingsView));             
        //    else
        //    {   Parametro parametro = new Parametro(this, 0, 0, 0);
        //        switch (clickedView)
        //        {
        //            case "ClienteListView":                         
        //                Conteudo.Navigate(typeof(ClienteListView), parametro);
        //                break;
        //            case "ProducaoView":
        //                Conteudo.Navigate(typeof(ProducaoView), parametro);
        //                break;
        //            case "RecebimentoView":
        //                Conteudo.Navigate(typeof(RecebimentoView), parametro);
        //                break;
        //            case "RefinanciamentoView":
        //                Conteudo.Navigate(typeof(RefinanciamentoView), parametro);
        //                break;
        //            case "ClienteCadastroView":
        //                Conteudo.Navigate(typeof(ClienteCadastroView), parametro);
        //                break;
        //        } 
        //    }
        //}
        private void Navegacao_OnBackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if (Conteudo.CanGoBack)
                Conteudo.GoBack();
        }

        //private void iniciarClientes()
        //{
        //    Parametro p = new Parametro(this, 0, 0, 0);
        //    Conteudo.Navigate(typeof(ClienteListView), p);
        //}

        private void Navegacao_OnItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked == true)
            {
                Navegacao_Navigate("settings", args.RecommendedNavigationTransitionInfo);
            }
            else if (args.InvokedItemContainer != null)
            {
                var navItemTag = args.InvokedItemContainer.Tag.ToString();
                Navegacao_Navigate(navItemTag, args.RecommendedNavigationTransitionInfo);
            }
        }
        private void Navegacao_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected == true)
            {
                Navegacao_Navigate("settings", args.RecommendedNavigationTransitionInfo);
            }
            else if (args.SelectedItemContainer != null)
            {
                var navItemTag = args.SelectedItemContainer.Tag.ToString();
                Navegacao_Navigate(navItemTag, args.RecommendedNavigationTransitionInfo);
            }
        }

        private void Navegacao_Navigate(string navItemTag, NavigationTransitionInfo transitionInfo)
        {
            Type _page = null;
            if (navItemTag == "settings")
            {
                _page = typeof(SettingsView);
            }
            else
            {
                var item = _pages.FirstOrDefault(p => p.Tag.Equals(navItemTag));
                _page = item.Page;
            }
            // Get the page type before navigation so you can prevent duplicate
            // entries in the backstack.
            var preNavPageType = Conteudo.CurrentSourcePageType;

            // Only navigate if the selected page isn't currently loaded.
            if (!(_page is null) && !Type.Equals(preNavPageType, _page))
            {
                Conteudo.Navigate(_page, null, transitionInfo);
            }
        }

        private void On_Navigated(object sender, NavigationEventArgs e)
        {
            Navegacao.IsBackEnabled = Conteudo.CanGoBack;

            if (Conteudo.SourcePageType == typeof(SettingsView))
            {
                // SettingsItem is not part of NavView.MenuItems, and doesn't have a Tag.
                Navegacao.SelectedItem = (NavigationViewItem)Navegacao.SettingsItem;
                Navegacao.Header = "Settings";
            }
            else if (Conteudo.SourcePageType != null)
            {
                var item = _pages.FirstOrDefault(p => p.Page == e.SourcePageType);

                Navegacao.SelectedItem = Navegacao.MenuItems
                    .OfType<NavigationViewItem>()
                    .First(n => n.Tag.Equals(item.Tag));

                Navegacao.Header = ((NavigationViewItem)Navegacao.SelectedItem)?.Content?.ToString();
            }
        }




























        private void Conteudo_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }
    } //*******************************
}
