using Module.Services;
using Module.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Module;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            int magicicans = Convert.ToInt32(MagicianInput.Text);
            int crossbowman = Convert.ToInt32(CrossbowmanInput.Text);
            int catapults = Convert.ToInt32(CatapultsInput.Text);

            var storage = new ArmyStorage(magicicans, crossbowman, catapults);
            FillTable(storage);
            var armyService = new ArmyService(storage);
            SpeedOutput.Text = $"{Math.Round(armyService.CalculateArmySpeed(), 3)} км/г";
            PriceOutput.Text = $"{armyService.CalculateArmyPrice()} злотих";
        }
        catch (Exception)
        {
            MessageBox.Show("Invalid input");
        }
    }

    private void FillTable(IArmyStorage storage)
    {
        ArmyOutput.Items.Clear();
        foreach (var item in storage.Army) 
        {
            ArmyOutput.Items.Add($"{item}. Ціна: {item.Price} злотих. Швидкість: {item.Speed} км/г.");
        }
    }
}
