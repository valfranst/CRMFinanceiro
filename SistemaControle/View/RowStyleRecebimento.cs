using SistemaControle.Model;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Windows;
using System.Windows.Controls;

namespace SistemaControle.View
{
    class RowStyleRecebimento : StyleSelector
    {
        public override Style SelectStyle(object item, DependencyObject container)
        {
            var row = (item as DataRowBase).RowData;
            var data = row as ViewRecebimento;              
            
            if (data.Paga == true && data.Marcado == false)
                return App.Current.Resources["rowStyleGreem"] as Style;
            if (data.Paga == true && data.Marcado == true)
                return App.Current.Resources["rowStyleGreem2"] as Style;


            if (data.Paga == false && data.Vencimento < DateTime.Now && data.Marcado == false)
                return App.Current.Resources["rowStyleRed"] as Style;
            if (data.Paga == false && data.Vencimento < DateTime.Now && data.Marcado == true)
                return App.Current.Resources["rowStyleRed2"] as Style;

            if (data.Vencimento >= DateTime.Now && data.Marcado == false)
                return App.Current.Resources["rowStyleBlack"] as Style;
            if (data.Vencimento >= DateTime.Now && data.Marcado == true)
                return App.Current.Resources["rowStyleBlack2"] as Style;


            return App.Current.Resources["rowStyleBlack"] as Style;
        }
    }
}
