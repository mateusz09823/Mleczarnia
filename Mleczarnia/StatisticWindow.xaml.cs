using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Mleczarnia
{
    /// <summary>
    /// Interaction logic for StatisticWindow.xaml
    /// </summary>
    public partial class StatisticWindow : Window
    {
        MleczarniaDBEntities2 db = new MleczarniaDBEntities2();
        public StatisticWindow()
        {
            InitializeComponent();
            farmers.Content = db.Farm.Count(); //ilość gospodarzy
            deliveries.Content= db.Delivery.Count();//ilość dostaw
            products.Content = db.Product.Count();//ilość produktów
            productions.Content = db.Production.Count();//ilość produkcji
            sales.Content = db.Sale.Count();//ilość sprzedaży
            float money = 0;//obrot
            var sale = db.Sale;

            foreach (var item in sale)
            {
                money += (float)item.price;
            }
            cash.Content = money.ToString()+" zł";
            var tanks = db.Tank;
            float capacity = 0; ;
            float filling = 0;
            foreach (var item in tanks)
            {
                capacity = (float)item.tankCapacity;
                filling = (float)item.tankFilling;
                break;
            }
            tankProgressBar.Minimum = 0;
            tankProgressBar.Maximum = capacity;
            tankProgressBar.Value = filling;
            tankFilling.Content = filling.ToString()+"  /";
            maximumCapacity.Content = capacity.ToString();
        }

        private FlowDocument CreateFlowDocument()
        {
            FlowDocument doc = new FlowDocument();
            Section sec = new Section();

            Table mainTable = new Table();
            int numberOfColumns = 2;

            for (int x = 0; x < numberOfColumns; x++)
            {
                mainTable.Columns.Add(new TableColumn());
            }
            TableRow currentRow;
            int rowCounter = 0;

            mainTable.RowGroups.Add(new TableRowGroup());
            mainTable.RowGroups[0].Rows.Add(new TableRow());
            currentRow = mainTable.RowGroups[0].Rows[rowCounter];
            rowCounter++;
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Statystyki Mleczarni"))));
            currentRow.FontWeight = FontWeights.Bold;
            currentRow.Background = Brushes.Silver;
            currentRow.FontSize = 17;

            mainTable.RowGroups[0].Rows.Add(new TableRow());
            currentRow = mainTable.RowGroups[0].Rows[rowCounter];
            rowCounter++;
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Ilość gospodarzy"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run(db.Farm.Count().ToString()))));
            currentRow.FontSize = 14;

            mainTable.RowGroups[0].Rows.Add(new TableRow());
            currentRow = mainTable.RowGroups[0].Rows[rowCounter];
            rowCounter++;
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Ilość dostaw"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run(db.Delivery.Count().ToString()))));
            currentRow.FontSize = 14;

            mainTable.RowGroups[0].Rows.Add(new TableRow());
            currentRow = mainTable.RowGroups[0].Rows[rowCounter];
            rowCounter++;
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Ilość produktów"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run(db.Product.Count().ToString()))));
            currentRow.FontSize = 14;

            mainTable.RowGroups[0].Rows.Add(new TableRow());
            currentRow = mainTable.RowGroups[0].Rows[rowCounter];
            rowCounter++;
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Ilość produkcji"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run(db.Production.Count().ToString()))));
            currentRow.FontSize = 14;

            mainTable.RowGroups[0].Rows.Add(new TableRow());
            currentRow = mainTable.RowGroups[0].Rows[rowCounter];
            rowCounter++;
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Ilość sprzedaży"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run(db.Sale.Count().ToString()))));
            currentRow.FontSize = 14;

            float money = 0;//obrot
            var sale = db.Sale;

            foreach (var item in sale)
            {
                money += (float)item.price;
            }

            mainTable.RowGroups[0].Rows.Add(new TableRow());
            currentRow = mainTable.RowGroups[0].Rows[rowCounter];
            rowCounter++;
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Obrót"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run(money.ToString() + " zł"))));
            currentRow.FontSize = 14;

            var tanks = db.Tank;
            float capacity = 0; ;
            float filling = 0;
            foreach (var item in tanks)
            {
                capacity = (float)item.tankCapacity;
                filling = (float)item.tankFilling;
                break;
            }
     
            mainTable.RowGroups[0].Rows.Add(new TableRow());
            currentRow = mainTable.RowGroups[0].Rows[rowCounter];
            rowCounter++;
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Wykorzystanie zbiornika"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run(filling.ToString() + " / " +capacity.ToString()))));
            currentRow.FontSize = 14;

            doc.Blocks.Add(mainTable);
            FlowDocumentReader myFlowDocumentReader = new FlowDocumentReader();
            myFlowDocumentReader.Document = doc;

            return doc;
        }

        private void PrintButtonCLick(object sender, RoutedEventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            FlowDocument doc = CreateFlowDocument();
            doc.PageHeight = printDlg.PrintableAreaHeight;
            doc.PageWidth = printDlg.PrintableAreaWidth;
            doc.Name = "FlowDoc";
            IDocumentPaginatorSource idpSource = doc;
            bool? doPrint = printDlg.ShowDialog();
            if (doPrint != true)
            {
                return;
            }
            printDlg.PrintDocument(idpSource.DocumentPaginator, "Statystyki Mleczarni");
        }

        private void BackButtonCLick(object sender, RoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Show();
            this.Close();
        }

    }
}
