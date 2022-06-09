using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;

namespace Wpf.CartesianChart.Using_DateTime
{
    public partial class DateTime : UserControl
    {
        LineSeries charlesSeries = new LineSeries

        {
            Title = "Charles",
            Values = new ChartValues<int> { 10, 5 },
                       
        };


        LineSeries charlesSeries1 = new LineSeries

        {
            Title = "Charles1",
            Values = new ChartValues<int> { 10, 5 },
        };
        public int max_size = 500;
        public int min_size = 500;


        public DateTime()
        {
            InitializeComponent();

            //we create a new SeriesCollection
            Series = new SeriesCollection();
          
            //create some LineSeries

            for (int i = 0; i < 50; i++) {

                charlesSeries1.Values.Add(i);
            }

         

           
           

            //add our series to our SeriesCollection
            // charlesSeries.Values.Add(12);
            Series.Add(charlesSeries);
            Series.Add(charlesSeries1);
            


            //that's it, LiveCharts is ready and listening for your data changes.
            DataContext = this;
            xxx.MinValue = 0.0;
        }

  
        public SeriesCollection Series { get; }


        private void button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //Ограничиваем график 500 точек
            if (charlesSeries.Values.Count < max_size) { _ = my_func(); }
            
        }
       


        async Task my_func()
        {
            for (int j = 0; j < 10; j++)

            {

                for (int i = 0; i < 10; i++)

                {
                    if (i <= 5) { charlesSeries.Values.Add((i)); }

                    if (i > 5) { charlesSeries.Values.Add((10 - i)); }


                    //await Task.Delay(TimeSpan.FromMilliseconds(95));
                    
                }

                

            }
        }

       

        private void ZOOM_IN_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            xxx.MaxValue = xxx.MaxValue / 2;
        }

        private void ZOOM_OUT_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            if (xxx.MaxValue <= max_size) { xxx.MaxValue = xxx.MaxValue * 2; }
        }

        private void MOVE_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (xxx.MinValue <= 10) { xxx.MinValue = xxx.MinValue + 1; }
            if (xxx.MaxValue <= max_size) { if (xxx.MinValue > 10) { xxx.MinValue = xxx.MinValue + 10; } }
        }

        private void MOVE_MinUS_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (xxx.MinValue <= 10) { xxx.MinValue = xxx.MinValue - 1; }
            if (xxx.MinValue >= min_size) { if (xxx.MinValue > 10) { xxx.MinValue = xxx.MinValue - 10; } }

        }

        private void button1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (charlesSeries.Values.Count > 11)
                for (int j = 0; j < 10; j++)

                {
                    charlesSeries.Values.RemoveAt(j);

                }
        }

       
    }
}
    
