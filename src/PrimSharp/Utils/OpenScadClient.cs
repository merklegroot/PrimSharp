using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace PrimSharp.Utils
{
    /// <summary>
    /// Integrates with a local OpenSCAD installation.
    /// </summary>
    public class OpenScadClient
    {
        // Ridiculous...
        private const string DefaultOpenScadFolder = "C:\\Program Files\\OpenSCAD";
        private readonly string _openScadFolder;

        private string OpenScadExecutableFullFileName =>
            Path.Combine(DefaultOpenScadFolder, "openscad.exe");

        public OpenScadClient() : this(DefaultOpenScadFolder) { }

        public OpenScadClient(string openScadFolder) =>
            _openScadFolder = !string.IsNullOrWhiteSpace(openScadFolder)
                ? openScadFolder
                : DefaultOpenScadFolder;


        public void CreateStl(string scadSource)
        {
            var id = Guid.NewGuid();
            var stlFileName = $"tmp_{id}.stl";
            var scadFileName = $"tmp_{id}.scad";

            File.WriteAllText(Path.Combine(_openScadFolder, scadFileName), scadSource);

            RunApplication(stlFileName, scadFileName);
        }

        private void RunApplication(string stlFileName, string scadFileName)
        {
            var args = string.Join(" ", new List<string> { "-o", stlFileName, scadFileName });

            var info = new ProcessStartInfo
            {
                FileName = OpenScadExecutableFullFileName,
                Arguments = args,
                RedirectStandardOutput = true,
                RedirectStandardError= true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = _openScadFolder
            };

            var process = Process.Start(info);
            process.WaitForExit();
        }
    }
}
