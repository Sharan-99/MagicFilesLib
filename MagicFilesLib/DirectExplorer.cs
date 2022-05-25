using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MagicFilesLib
{
    public interface IDirectExplorer
    {
        ICollection<string> GetFiles();
    }
    public class DirectExplorer:IDirectExplorer
    {
        IList<string> list = new List<string>();
        public DirectExplorer()
        {
            list.Add("file.txt");
            list.Add("file1.txt");
            

        }

        public ICollection<string> GetFiles()
        {
            return list;
        }
       /* public ICollection<string> GetFiles(string path)
        {
            string[] files = Directory.GetFiles(path);
            return files;
        } */

    }
}
