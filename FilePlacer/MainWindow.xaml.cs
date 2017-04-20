using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FilePlacer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            Rule r ;
            
            r= new Rule();
            r.Name="Naruto Dubbed #1";
            r.ScanPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.IncludeSubdirectories=true;
            r.DestinationPath=@"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.ScanPattern=@"[AnimeRG]+Naruto+Shippuden+*NUM0*+(Dub)+*STR0*+(1280x720)+[Phr0stY]-*STR9*.mp4";
            r.DestinationPattern=@"Naruto Shippuuden *NUM0* Dubbed - *STR0*.mp4";
            r.StringsToSpace = new string[] { "+" };
            Rule.AddRule(r);

            r = new Rule();
            r.Name = "Naruto Dubbed #2";
            r.ScanPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.IncludeSubdirectories = true;
            r.DestinationPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.ScanPattern = @"[AnimeRG]+Naruto+Shippuden+*NUM0*+*STR0*+(Dub)+(1280x720)+[Phr0stY]-*STR9*.mp4";
            r.DestinationPattern = @"Naruto Shippuuden *NUM0#3* Dubbed - *STR0*.mp4";
            r.StringsToSpace = new string[] { "+" };
            Rule.AddRule(r);

            r = new Rule();
            r.Name = "Naruto Dubbed #3";
            r.ScanPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.IncludeSubdirectories = true;
            r.DestinationPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.ScanPattern = @"[AnimeRG]+Naruto+Shippuden+*NUM0*+(Dub)+(1280x720)+[Phr0stY]-*STR9*.mp4";
            r.DestinationPattern = @"Naruto Shippuuden *NUM0* Dubbed.mp4";
            r.StringsToSpace = new string[] { "+" };
            Rule.AddRule(r);

            r = new Rule();
            r.Name = "Naruto Dubbed #4";
            r.ScanPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.IncludeSubdirectories = true;
            r.DestinationPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.ScanPattern = @"[AnimeRG]+Naruto+Shippuden+*NUM0*+(Dub)+(1280x720)+[Phr0sstY]-*STR9*.mp4";
            r.DestinationPattern = @"Naruto Shippuuden *NUM0* Dubbed.mp4";
            r.StringsToSpace = new string[] { "+" };
            Rule.AddRule(r);

            r = new Rule();
            r.Name = "Naruto Dubbed #5";
            r.ScanPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.IncludeSubdirectories = true;
            r.DestinationPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.ScanPattern = @"[AnimeRG]+Naruto+Shippuden+*NUM0*+(Dub)+720p+[Phr0stY]-*STR9*.mp4";
            r.DestinationPattern = @"Naruto Shippuuden *NUM0* Dubbed.mp4";
            r.StringsToSpace = new string[] { "+" };
            Rule.AddRule(r);

            r = new Rule();
            r.Name = "Naruto Dubbed #6";
            r.ScanPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.IncludeSubdirectories = true;
            r.DestinationPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.ScanPattern = @"[M@nI]+Naruto+Shippuden+-+*NUM0*+-+*STR0*+(Dual+Audio)[720p]-*STR9*.mp4";
            r.DestinationPattern = @"Naruto Shippuuden *NUM0#3* Dubbed - *STR0*.mp4";
            r.StringsToSpace = new string[] { "+" };
            Rule.AddRule(r);

            r = new Rule();
            r.Name = "Naruto Dubbed #7";
            r.ScanPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.IncludeSubdirectories = true;
            r.DestinationPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.ScanPattern = @"Naruto+Shippuuden+-+*NUM0*+-+*STR0*-r*STR9*.mp4";
            r.DestinationPattern = @"Naruto Shippuuden *NUM0#3* Dubbed - *STR0*.mp4";
            r.StringsToSpace = new string[] { "+" };
            Rule.AddRule(r);

            r = new Rule();
            r.Name = "Naruto Dubbed #8";
            r.ScanPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.IncludeSubdirectories = true;
            r.DestinationPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.ScanPattern = @"Naruto+Shippuden+-+*NUM0*+-+*STR0*-r*STR9*.mp4";
            r.DestinationPattern = @"Naruto Shippuuden *NUM0#3* Dubbed - *STR0*.mp4";
            r.StringsToSpace = new string[] { "+" };
            Rule.AddRule(r);

            r = new Rule();
            r.Name = "Naruto Dubbed #9";
            r.ScanPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.IncludeSubdirectories = true;
            r.DestinationPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.ScanPattern = @"Naruto+Shippuden+*NUM0*+*STR0*+(1280x720)+[Phr0stY]-*STR9*.mp4";
            r.DestinationPattern = @"Naruto Shippuuden *NUM0#3* Dubbed - *STR0*.mp4";
            r.StringsToSpace = new string[] { "+" };
            Rule.AddRule(r);

            r = new Rule();
            r.Name = "Naruto Dubbed #10";
            r.ScanPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.IncludeSubdirectories = true;
            r.DestinationPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.ScanPattern = @"[M@nI]+Naruto+Shippuden+-+*NUM0*+-+*STR0*-r*STR9*.mp4";
            r.DestinationPattern = @"Naruto Shippuuden *NUM0#3* Dubbed - *STR0*.mp4";
            r.StringsToSpace = new string[] { "+" };
            Rule.AddRule(r);

            r = new Rule();
            r.Name = "Naruto Dubbed #11";
            r.ScanPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.IncludeSubdirectories = true;
            r.DestinationPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.ScanPattern = @"[RPRip-ARRG]Naruto+Shippuden+*NUM0*+*STR0*[720p;Dub-Audio+x264]-*STR9*.mp4";
            r.DestinationPattern = @"Naruto Shippuuden *NUM0#3* Dubbed - *STR0*.mp4";
            r.StringsToSpace = new string[] { "+" };
            Rule.AddRule(r);

            r = new Rule();
            r.Name = "Naruto Dubbed #12";
            r.ScanPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.IncludeSubdirectories = true;
            r.DestinationPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.ScanPattern = @"Naruto+Shippuden+Episode+*NUM0*-r*STR9*.mp4";
            r.DestinationPattern = @"Naruto Shippuuden *NUM0#3* Dubbed.mp4";
            r.StringsToSpace = new string[] { "+" };
            Rule.AddRule(r);


            /*
            r = new Rule();
            r.Name = "Naruto Dubbed #0";
            r.ScanPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.IncludeSubdirectories = true;
            r.DestinationPath = @"\\mediaserver\AnimeRoot\Naruto\Dubbed";
            r.ScanPattern = @"Naruto Shippuuden *NUM0* Dubbed - *STR0*.mp4";
            r.DestinationPattern = @"Naruto Shippuuden *NUM0#3* Dubbed - *STR0*.mp4";
            r.StringsToSpace = new string[] { "+" };
            Rule.AddRule(r);
            */
            
            
            
            
            
            


            Rule.ScanAll();

            FileCopies.CopyAll();
        }
    }
}
