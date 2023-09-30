using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFileManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //指明路径
            string pathi = "C:\\Users\\haogu\\Desktop";
            //获取路径下所有文件
            DirectoryInfo info = new DirectoryInfo(pathi);

            //文件数据数组转换为List
            FileInfo[] allFile = info.GetFiles();
            List<FileInfo> lstFile = allFile.ToList();

            //循环文件
            for (int i = 0; i < lstFile.Count; i++)
            {
                //获取所有文件完整路径
                String fileName = lstFile[i].FullName;
                Console.WriteLine(fileName);

                // Delete input file
                if (fileName == "123.txt")
                {
                    File.Delete(lstFile[i].FullName);
                    Console.WriteLine("delete success");
                }


                string lowerFile = fileName.ToLower();
                bool judge = lowerFile.Contains("lo");
                //Console.WriteLine(file.Name);
                // Console.WriteLine(judge);
                if (judge)
                {
                    string srcFilename = lstFile[i].FullName;
                    string destFilename = lstFile[i].Directory.FullName + "/fuckasia" + lstFile[i].Extension;
                    File.Move(srcFilename, destFilename);

                }
            }

        }
    }
}
