using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using WMPLib;

namespace GuessWhat
{
    internal class Melody
    {
        private string Path = "music";
        public List<string> MelodyNameList = new List<string>();
        public List<string> MelodyPathList = new List<string>();
        WindowsMediaPlayer Player = new WindowsMediaPlayer();

        public Melody()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path);
            Init(directoryInfo);
        }

        private void Init(DirectoryInfo directoryInfo)
        {
            FileInfo[] fileInfos = directoryInfo.GetFiles("*.mp3"); 
            foreach (var file in fileInfos)
            {
                MelodyNameList.Add(file.Name);
                MelodyPathList.Add(file.FullName);
            }
        }

        public void Begin(int index)
        {
            Random rnd = new Random();
            Player.URL = MelodyPathList[index];
            Player.settings.volume = 10;
            Player.controls.play();
        }

        public string GetMelody(int index)
        {
            return MelodyNameList[index];
        }

        public string GetPath(int index)
        {
            return MelodyPathList[index];
        }

        public int Count()
        {
            return MelodyNameList.Count;
        }

        public bool Check(string filePath, string file)
        {
            return MelodyPathList.IndexOf(filePath) == MelodyNameList.IndexOf(file);
        }
    }
}
