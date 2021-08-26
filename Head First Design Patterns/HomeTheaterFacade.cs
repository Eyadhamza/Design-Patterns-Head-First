using System;

namespace Head_First_Design_Patterns
{
    public class HomeTheaterFacade
    {
        private Amplifier _amplifier;
        private Tuner _tuner;
        private StreamingPlayer _streamingPlayer;
        private Projector _projector;
        private TheaterLights _theaterLights;
        private Screen _screen;
        private PopcornPopper _popcornPopper;

        public HomeTheaterFacade(PopcornPopper popcornPopper,
            Screen screen,
            TheaterLights theaterLights,
            Projector projector,
            StreamingPlayer streamingPlayer,
            Tuner tuner,
            Amplifier amplifier)
        {
            _popcornPopper = popcornPopper;
            _screen = screen;
            _theaterLights = theaterLights;
            _projector = projector;
            _streamingPlayer = streamingPlayer;
            _tuner = tuner;
            _amplifier = amplifier;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get Ready to watch movie");

            _popcornPopper.On();
            _popcornPopper.Pop();
            _theaterLights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amplifier.On();
            _amplifier.SetStreamingPlayer(_streamingPlayer);
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);
            _streamingPlayer.On();
            _streamingPlayer.Play(movie);
        }
        public void EndMovie(string movie)
        {
            Console.WriteLine("Shutting movie");

            _popcornPopper.Off();
            _screen.Up();
            _projector.Off();
            _amplifier.Off();
            _streamingPlayer.Off();
        }
    }
}
