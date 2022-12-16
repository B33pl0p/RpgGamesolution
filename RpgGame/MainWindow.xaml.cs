using game_engine.ViewModel;
using System.Windows;
using System.Windows.Input;

namespace RpgGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public GameSession _gameSession;


        public MainWindow()
        {
            InitializeComponent();
            _gameSession = new GameSession();
            DataContext = _gameSession;
        }

        private void Onclick_MoveNorth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveNorth();
        }
        private void Onclick_MoveWest(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveWest();
        }
        private void Onclick_MoveEast(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveEast();

        }
        private void Onclick_MoveSouth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveSouth();
        }
    }
}
