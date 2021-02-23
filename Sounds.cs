using WMPLib;
namespace Snake
{
    public class Sounds
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;

        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }

        public void Play()
        {
            player.URL = pathToMedia + "rattlesnake6.mp3";
            player.settings.volume = 3;
            player.controls.play();
            player.settings.setMode("loop", true);
        }

        public void EatPlay()
        {
            player.URL = pathToMedia + "zvuk-hrusta-morkovi-8615.mp3";
            player.settings.volume = 50;
            player.controls.play();
        }

        public void PlaySpsEat()
        {
            player.URL = pathToMedia + "snakehit.mp3";
            player.settings.volume = 50;
            player.controls.play();
        }
        public void PlayBadEat()
        {
            player.URL = pathToMedia + "rattlesnakerattle.mp3";
            player.settings.volume = 50;
            player.controls.play();
        }
        public void PlayStop()
        {
            player.URL = pathToMedia + "main.mp3";
            player.controls.stop();
        }
    }
}



