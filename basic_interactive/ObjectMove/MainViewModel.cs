using CommunityToolkit.Mvvm.ComponentModel;

namespace ObjectMove
{
    public partial class MainViewModel : ObservableObject
    {
        private double x = 100;

        public double X
        {
            get => x;
            set => SetProperty(ref x, value);
        }

        private double y = 100;

        public double Y
        {
            get => y;
            set => SetProperty(ref y, value);
        }

        public void Move(string direction)
        {
            const double step = 10;
            switch (direction)
            {
                case "Left":
                    this.X -= step;
                    break;
                case "Right":
                    X += step;
                    break;
                case "Up":
                    Y -= step;
                    break;
                case "Down":
                    Y += step;
                    break;
            }
        }
    }
}
