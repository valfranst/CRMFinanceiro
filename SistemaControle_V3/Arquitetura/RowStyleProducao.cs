using Syncfusion.UI.Xaml.Grid;
using System.Windows;
using System.Windows.Controls;

namespace SistemaControle_V3
{
    class RowStyleProducao : StyleSelector
    {

        public override Style SelectStyle(object item, DependencyObject container)
        {
            var row = (item as DataRowBase).RowData;
            var data = row as ViewProducao;

            if (data.Marcado == true)
                return App.Current.Resources["rowStyleBlack2"] as Style;
            if (data.Marcado == false)
                return App.Current.Resources["rowStyleBlack"] as Style;

            return App.Current.Resources["rowStyleBlack"] as Style;
        }

    }
}
