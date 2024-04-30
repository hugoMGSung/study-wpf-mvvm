using Caliburn.Micro;

namespace CaliburnStartup.ViewModels
{
    public class MainViewModel : Conductor<object>
    {
        public string Greeting => "헬로, 칼리번!";
    }
}
