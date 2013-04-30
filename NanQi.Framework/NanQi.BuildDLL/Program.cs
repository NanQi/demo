using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NanQi.BuildDLL
{
    class Program
    {
        const string LibsPath = @"e:\cygwin\home\Administrator\github\demo\NanQi.Project\Libs\";
        const string ToolsPath = @"e:\cygwin\home\Administrator\github\demo\NanQi.Project\Tools\NanQi.IDE.vsix";

        const string vsixPath = @"e:\cygwin\home\Administrator\github\demo\NanQi.Framework\NanQi.IDE\bin\Debug\NanQi.IDE.vsix";

        const string thisName = "NanQi.BuildDLL";

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(Environment.CurrentDirectory);
            foreach (var file in dir.GetFiles())
            {
                if (!file.Name.Contains(thisName))
                {
                    File.Copy(file.FullName, Path.Combine(LibsPath + file.Name), true);
                }
            }

            File.Copy(vsixPath, ToolsPath, true);

        }
    }
}
