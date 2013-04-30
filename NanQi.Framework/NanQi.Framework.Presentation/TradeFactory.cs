using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;

namespace NanQi.Framework.Presentation
{
    internal class TradeFactory
    {
        internal static ITrade CreateTrade(string actionName)
        {
            Type actionType = null;
            actionType = GetActionType(actionName);
            if (actionType == null)
            {
                return null;
            }
            else
            {
                var page = Activator.CreateInstance(actionType) as ITrade;
                if (page != null)
                    page.GUID = Guid.NewGuid();
                return page;
            }
        }

        private static Type GetActionType(string actionName)
        {
            Type actionType;

            var fileName = string.Concat(actionName, ".dll");
            var fileSymbolName = string.Concat(actionName, ".pdb");
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Trades", fileName);
            var fileSymbolPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Trades", fileSymbolName);
            byte[] rawAssembly = LoadFile(filePath);
            byte[] rawSymbolStore = LoadFile(fileSymbolPath);
            Assembly assemblyLoad = AppDomain.CurrentDomain.Load(rawAssembly, rawSymbolStore);
            return assemblyLoad.GetExportedTypes().
                           Where(x => x.GetInterfaces().Contains(typeof(ITrade))).Select(x => x).Select(x => x).
                           FirstOrDefault(x => { return x.FullName == actionName; });
        }

        private static byte[] LoadFile(string filename)
        {
            FileInfo info = new FileInfo(filename);
            if (!info.Exists)
            {
                return null;
            }
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[(int)fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            fs.Close();
            return buffer;
        }
    }
}
