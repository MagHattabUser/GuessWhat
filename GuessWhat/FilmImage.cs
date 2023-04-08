using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessWhat
{
    internal class FilmImage
    {
        private string Path = "images";
        private List<string> FilmImageNameList = new List<string>();
        private List<string> FilmImagePathList = new List<string>();

        public FilmImage(string filmTheme)
        {
            var path = Path + "\\" + filmTheme;
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            Init(directoryInfo);
        }

        private void Init(DirectoryInfo directoryInfo)
        {

            FileInfo[] fileInfos = directoryInfo.GetFiles("*.jpg");
            foreach (var file in fileInfos)
            {
                FilmImageNameList.Add(file.Name);
                FilmImagePathList.Add(file.FullName);
            }
        }

        public string GetPath(int index)
        {
            return FilmImagePathList[index];
        }

        public string GetImage(int index)
        {
            return FilmImageNameList[index].Remove(FilmImageNameList[index].Length - 4);
        }

        public bool Check(string filePath, string file)
        {
            var fullNameFile = file + ".jpg";
            return FilmImagePathList.IndexOf(filePath) == FilmImageNameList.IndexOf(fullNameFile);
        }

        public int Count()
        {
            return FilmImageNameList.Count;
        }
    }
}
