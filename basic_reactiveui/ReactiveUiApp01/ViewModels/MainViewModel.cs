using ReactiveUI;
using System.Reactive.Linq;
using System.Windows.Media;

namespace ReactiveUiApp01.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        #region Internal Field
        private byte _rValue;
        private byte _gValue;
        private byte _bValue;

        private ObservableAsPropertyHelper<Color> _color;
        private ObservableAsPropertyHelper<string> _colorText;
        private ObservableAsPropertyHelper<SolidColorBrush> _colorBrush;
        #endregion

        #region Properties
        public byte RValue
        {
            get => _rValue;
            set => this.RaiseAndSetIfChanged(ref _rValue, value);
        }
        public byte GValue
        {
            get => _gValue;
            set => this.RaiseAndSetIfChanged(ref _gValue, value);
        }
        public byte BValue
        {
            get => _bValue;
            set => this.RaiseAndSetIfChanged(ref _bValue, value);
        }

        public Color Color => _color.Value;
        public string ColorText => _colorText.Value;
        public SolidColorBrush ColorBrush => _colorBrush.Value;
        #endregion

        #region Constructor
        public MainViewModel()
        {
            // 1
            this.WhenAnyValue(x => x.RValue, x => x.GValue, x => x.BValue)
                .Select(p => Color.FromRgb(p.Item1, p.Item2, p.Item3))
                .ToProperty(this, x => x.Color, out _color);
            // 2
            this.WhenAnyValue(x => x.Color)
                .Select(c => c.ToString())
                .ToProperty(this, x => x.ColorText, out _colorText);
            // 3
            this.WhenAnyValue(x => x.Color)
                .Select(c => new SolidColorBrush(c))
                .ToProperty(this, x => x.ColorBrush, out _colorBrush);
        }
        #endregion
    }
}
