using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using Microsoft.Win32;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using System.Collections.Generic;
using System.IO;
using EnvDTE;
using Microsoft.Build.Utilities;
using System.Xml;
using System.Linq;


namespace 神棍工作室.NanQi_IDE
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(GuidList.guidNanQi_IDEPkgString)]
    public sealed class NanQi_IDEPackage : Package
    {
        #region Field
        const string ConfigFileName = "Trade.xml";

        const string _msBuildTemporaryRoute = "tmpFiles\\";
        const string _msBuildRoute = "NanQi.Project.Host\\bin\\Debug\\Trades\\";


        string _projName;
        string _tradeName;
        string _solutionPtr;
        #endregion
        
        public NanQi_IDEPackage()
        {
            Trace.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering constructor for: {0}", this.ToString()));
        }

        #region Package Members

        protected override void Initialize()
        {
            Trace.WriteLine (string.Format(CultureInfo.CurrentCulture, "Entering Initialize() of: {0}", this.ToString()));
            base.Initialize();

            OleMenuCommandService mcs = GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (null != mcs)
            {
                var queryStatusCommandId = new CommandID(GuidList.guidNanQi_IDECmdSet, (int)PkgCmdIDList.cmdidBuild);
                var queryStatusMenuCommand = new OleMenuCommand(MenuItemCallback, queryStatusCommandId);
                queryStatusMenuCommand.BeforeQueryStatus += new EventHandler(queryStatusMenuCommand_BeforeQueryStatus);
                mcs.AddCommand(queryStatusMenuCommand);
            }
        }

        private void MenuItemCallback(object sender, EventArgs e)
        {
            queryStatusMenuCommand_BeforeQueryStatus(sender, e);
            TradeBuild();
        }

        void queryStatusMenuCommand_BeforeQueryStatus(object sender, EventArgs e)
        {
            var menuCommand = sender as OleMenuCommand;

            if (menuCommand != null)
            {
                IntPtr hierarchyPtr, selectionContainerPtr;
                uint projectItemId;
                IVsMultiItemSelect mis;
                var monitorSelection = (IVsMonitorSelection)GetGlobalService(typeof(SVsShellMonitorSelection));
                monitorSelection.GetCurrentSelection(out hierarchyPtr, out projectItemId, out mis, out selectionContainerPtr);

                var hierarchy = Marshal.GetTypedObjectForIUnknown(hierarchyPtr, typeof(IVsHierarchy)) as IVsHierarchy;
                if (hierarchy != null)
                {
                    object nextSiblingName;
                    var siblingId = (int)projectItemId;
                    var isTradeProject = false;

                    while (siblingId != -1)
                    {
                        object nextSiblingId;
                        hierarchy.GetProperty((uint)siblingId, (int)__VSHPROPID.VSHPROPID_NextVisibleSibling, out nextSiblingId);
                        siblingId = (int)nextSiblingId;
                        hierarchy.GetProperty((uint)siblingId, (int)__VSHPROPID.VSHPROPID_Name, out nextSiblingName);
                        if (nextSiblingName != null && nextSiblingName.ToString().Equals(ConfigFileName))
                        {
                            isTradeProject = true;
                        }
                    }
                    if (isTradeProject)
                    {
                        GetTradeName(projectItemId, hierarchy);
                        GetProjName(projectItemId, hierarchy);
                        GetSolutionPath();

                        string xmlPath = Path.Combine(_solutionPtr + _projName + Path.DirectorySeparatorChar + ConfigFileName);
                        var doc = new XmlDocument();
                        doc.Load(xmlPath);

                        var trades = doc.SelectNodes("Root/Trade");
                        menuCommand.Visible = trades.Cast<XmlNode>().Any(xn =>
                            string.Compare(xn.Attributes["Key"].Value, _tradeName, true) == 0);
                    }
                    else
                    {
                        menuCommand.Visible = false;
                    }
                }
            }
        }
        #endregion

        #region GetPath
        private void GetTradeName(uint projectItemId, IVsHierarchy hierarchy)
        {
            object selectItemName;

            hierarchy.GetProperty(projectItemId, (int)__VSHPROPID.VSHPROPID_Name, out selectItemName);
            _tradeName = (string)selectItemName;
        }

        private void GetProjName(uint projectItemId, IVsHierarchy hierarchy)
        {
            object parentHierachy, itemid, projName;

            hierarchy.GetProperty(projectItemId, (int)__VSHPROPID.VSHPROPID_ParentHierarchy, out parentHierachy);
            hierarchy.GetProperty(projectItemId, (int)__VSHPROPID.VSHPROPID_ParentHierarchyItemid, out itemid);
            var hierarchy1 = (IVsHierarchy)parentHierachy;
            var parentId = (int)itemid;
            hierarchy1.GetProperty((uint)parentId, (int)__VSHPROPID.VSHPROPID_Name, out projName);
            _projName = (string)projName;
        }

        private void GetSolutionPath()
        {
            string solutionPtr, userOptsFile, solutionFile;
            var solution = (IVsSolution)GetGlobalService(typeof(SVsSolution));
            solution.GetSolutionInfo(out solutionPtr, out solutionFile, out userOptsFile);

            _solutionPtr = solutionPtr;
        }
        #endregion
      
        #region Build
       
        public bool TradeBuild()
        {
            var solution = (IVsSolution)Package.GetGlobalService(typeof(SVsSolution));
            const int cookie = 1;
            solution.SaveSolutionElement((uint)__VSSLNSAVEOPTIONS.SLNSAVEOPT_SaveIfDirty, null, cookie);

            string commonPath = string.Format("{0}{1}\\{2}", _solutionPtr, _projName, _projName);
            string tempPath = Path.Combine(_solutionPtr, _msBuildTemporaryRoute);

            Directory.CreateDirectory(tempPath);

            GenerateProjFile(string.Format("{0}.csproj", commonPath), string.Format("{0}tmp.csproj", tempPath));

            var msbuild = ToolLocationHelper.GetPathToDotNetFrameworkFile("msbuild.exe", TargetDotNetFrameworkVersion.Version40);
            var info = new ProcessStartInfo(msbuild,
                string.Format("\"{0}tmp.csproj\" /p:Configuration={1} /consoleloggerparameters:ErrorsOnly", tempPath, "Debug"))
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                ErrorDialog = false,
                CreateNoWindow = true,
            };
            var proc = System.Diagnostics.Process.Start(info);
            TradeBuildedStatus(BuildEnum.BuildProcess);
            var msbuildOutput = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();
            bool buildTradeReasult;
            ShowTradeBuildedMessage(msbuildOutput, out buildTradeReasult);
            if (buildTradeReasult)
            {
                CopyToDesFile();
                TradeBuildedStatus(BuildEnum.BuildSuccess);
                proc.Close();
                DeleteInDir(tempPath);
                return true;
            }
            TradeBuildedStatus(BuildEnum.BuildFail);
            proc.Close();
            DeleteInDir(tempPath);

            return false;
        }

      
        internal void ShowTradeBuildedMessage(string buildMessage, out bool buildReasult)
        {
            List<string> list = GetTradeBuildErrorStrings(buildMessage);
            if (list.Count > 0)
            {
                buildReasult = false;
            }
            else
            {
                buildReasult = true;
            }
        }

 
        internal List<string> GetTradeBuildErrorStrings(string msbuildOutput)
        {
            string[] split = msbuildOutput.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var list = new List<string>();

            for (var i = 3; i < split.Length; i++)
            {
                list.Add(split[i]);
            }

            return list;
        }

        internal ErrorListItem GetErrorItemMessage(string errorString)
        {
            var errorListItem = new ErrorListItem
            {
                FileName = errorString.Substring(0, errorString.IndexOf('(', 1)),
                Line = errorString.Substring(errorString.IndexOf('(', 1) + 1,
                                          errorString.IndexOf(',', 1) - errorString.IndexOf('(', 1) - 1),
                Column = errorString.Substring(errorString.IndexOf(',', 1) + 1, errorString.IndexOf(')', 1) - errorString.IndexOf(',', 1) - 1),
                Description = errorString.Substring(errorString.IndexOf(':', 2) + 1,
                                          errorString.IndexOf('[', 1) - errorString.IndexOf(':', 2) - 1)
            };
            return errorListItem;
        }

        internal void TradeBuildedStatus(BuildEnum status)
        {
            var statusBar = (IVsStatusbar)Package.GetGlobalService(typeof(SVsStatusbar));

            if (status == BuildEnum.BuildProcess)
            {
                statusBar.SetText("正在编译交易...");
            }
            else if (status == BuildEnum.BuildSuccess)
            {
                statusBar.SetText("编译成功");
            }
            else if (status == BuildEnum.BuildFail)
            {
                statusBar.SetText("编译失败");
            }
        }

        internal void DeleteInDir(string szDirPath)
        {
            if (string.IsNullOrEmpty(szDirPath.Trim()) || !Directory.Exists(szDirPath))
                return;
            var dirInfo = new DirectoryInfo(szDirPath);

            var fileInfos = dirInfo.GetFiles();
            if (fileInfos.Length > 0)
            {
                foreach (FileInfo fileInfo in fileInfos)
                {
                    File.Delete(fileInfo.FullName); 
                }
            }

            var dirInfos = dirInfo.GetDirectories();
            if (dirInfos.Length > 0)
            {
                foreach (DirectoryInfo childDirInfo in dirInfos)
                {
                    DeleteInDir(childDirInfo.FullName);
                }
            }
            Directory.Delete(dirInfo.FullName, true); 
        }

        internal bool CopyToDesFile()
        {
            var dllName = string.Format("{0}.{1}", _projName, _tradeName);
            if (_projName.Contains("["))
            {
                dllName = string.Format("{0}.{1}", _projName.Substring(0, _projName.IndexOf("[")), _tradeName);
            }

            var basePath = string.Format("{0}{1}{2}", _solutionPtr, _msBuildRoute, dllName);

            var dir = new DirectoryInfo(Path.Combine(_solutionPtr, _msBuildRoute));
            if (!dir.Exists)
            {
                dir.Create();
            }

            var baseTempPath = string.Format("{0}{1}{2}", _solutionPtr, _msBuildTemporaryRoute, dllName);

            if (File.Exists(string.Format("{0}{1}", baseTempPath, ".dll")))
            {
                File.Copy(string.Format("{0}{1}", baseTempPath, ".dll"),
                          string.Format("{0}{1}", basePath, ".dll"), true);
              
                File.Copy(string.Format("{0}{1}", baseTempPath, ".pdb"),
                          string.Format("{0}{1}", basePath, ".pdb"), true);
               
                return true;
            }
            return false;
        }
        #endregion

        #region ProjFile
       
        internal void GenerateProjFile(string tradeProjectProjFilePath, string tmpProjFile)
        {
            var doc = new XmlDocument();
            doc.Load(tradeProjectProjFilePath);
            var mgr = new XmlNamespaceManager(doc.NameTable);
            mgr.AddNamespace("x", "http://schemas.microsoft.com/developer/msbuild/2003");

            EditAssemblyName(doc, mgr);
            EditOutputPath(doc, mgr);
            EditItemGroup(doc, mgr);
            doc.Save(tmpProjFile);
        }

        internal void EditAssemblyName(XmlDocument doc, XmlNamespaceManager mgr)
        {
            var nodes = doc.SelectNodes("/x:Project/x:PropertyGroup/x:AssemblyName", mgr);

            if (nodes == null) return;
            var nodesCount = nodes.Count;
            foreach (XmlNode node in nodes)
            {
                if (node.Attributes != null)
                {
                    node.InnerText = string.Format("{0}.{1}", node.InnerText, _tradeName);
                }
            }
        }

        internal void EditItemGroup(XmlDocument doc, XmlNamespaceManager mgr)
        {
            var codeAnalysisDictionaryNodes = doc.SelectSingleNode("/x:Project/x:ItemGroup/x:CodeAnalysisDictionary", mgr);
            var resourceNode = doc.SelectSingleNode("/x:Project/x:ItemGroup/x:Resource", mgr);
            var nodes = doc.SelectNodes("/x:Project/x:ItemGroup/x:*[@Include]", mgr);

            if (nodes != null)
                foreach (XmlNode node in nodes)
                {
                    string includeText = node.Attributes["Include"].InnerText;
                    if (!node.Name.Equals("Reference") && !node.Name.Equals("ProjectReference"))
                    {
                        if (!(includeText.Contains(string.Format("{0}\\", _tradeName))) && !(includeText.Equals(ConfigFileName)))
                        {
                            if (node.ParentNode != null)
                                node.ParentNode.RemoveChild(node);
                        }
                        else if (includeText.Contains(string.Format("{0}\\", _tradeName)))
                        {
                            node.Attributes["Include"].InnerText = string.Format(@"{0}{1}\{2}", _solutionPtr, _projName, includeText);
                        }
                    }
                    if (node.Name.Equals("ProjectReference"))
                    {
                        node.Attributes["Include"].InnerText = includeText.Replace("..\\", _solutionPtr);
                    }
                }

            if (codeAnalysisDictionaryNodes != null)
                if (codeAnalysisDictionaryNodes.ParentNode != null)
                    codeAnalysisDictionaryNodes.ParentNode.ParentNode.RemoveChild(codeAnalysisDictionaryNodes.ParentNode);
            if (resourceNode != null)
                if (resourceNode.ParentNode != null)
                    resourceNode.ParentNode.ParentNode.RemoveChild(resourceNode.ParentNode);
        }

        internal void EditOutputPath(XmlDocument doc, XmlNamespaceManager mgr)
        {
            var outputPath = doc.SelectNodes("/x:Project/x:PropertyGroup/x:OutputPath", mgr);
            if (outputPath != null)
                foreach (XmlNode node in outputPath)
                {
                    var path = node.InnerText;
                    if (!string.IsNullOrEmpty(path))
                    {
                        node.InnerText = Path.Combine(_solutionPtr, _msBuildTemporaryRoute);
                    }
                }

        }
        #endregion
    }

    internal enum BuildEnum
    {
        BuildProcess = 0,
        BuildSuccess = 1,
        BuildFail = 2
    }

    internal class ErrorListItem
    {
        public string FileName { get; set; }
        public string Line { get; set; }
        public string Column { get; set; }
        public string Description { get; set; }
    }
}
