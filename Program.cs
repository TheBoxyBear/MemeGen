using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MemeGen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0)
                RunFromArguments(args);
            else
                Application.Run(new frmSettings());
        }

        static void RunFromArguments(string[] args)
        {
            if (args.Length % 2 != 0)
            {
                Console.WriteLine("Invalid number of parameters.");
                return;
            }

            List<(Image, string)> steps = new List<(Image, string)>();

            for (int i = 0; i < args.Length; i += 2)
            {
                Image image;

                try { image = Image.FromFile(args[i]); }
                catch (Exception e)
                {
                    Console.WriteLine($"Could not load image {args[i]}: {e.Message}");
                    return;
                }

                steps.Add((image, args[i + 1]));
            }

            Application.Run(new frmMeme(steps));
        }
    }
}
