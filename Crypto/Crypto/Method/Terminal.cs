using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Crypto.Method
{
    public class Terminal
    {
        public static string py { get; } = "py -u Form.py";

        public static List<string> result { get; set; } = new List<string>();

        public static void DosReady(string text,bool message = false)
        {
            Task.Run(() => DosExecute(text,message));
        }

        public static void DosExecute(string text,bool message)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
            process.Start();
            process.StandardInput.AutoFlush = true;
            process.StandardInput.WriteLine("@echo off");
            process.StandardInput.WriteLine(text);
            process.StandardInput.WriteLine("exit");
            StreamReader reader = process.StandardOutput;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (message && line == "<SUCCESS>")
                {
                    HintMessage("操作成功!");
                }
                else if (message && line == "<FAILED>")
                {
                    ErrorMessage("操作失敗!","失敗");
                }
                result.Add(line);
                line = reader.ReadLine();
            }
            process.WaitForExit();
            reader.Close();
            process.Close();
        }

        public static void ErrorMessage(string message,string title = "錯誤")
        {
            MessageBox.Show(message,title,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public static void HintMessage(string message,string title = "成功")
        {
            MessageBox.Show(message,title,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public static bool QuestionMessage(string message)
        {
            if (MessageBox.Show(message, "Whether",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int GetTerminal(int ItemsCount, int Height, int ItemHeight)
        {
            return ItemsCount - (Height / ItemHeight);
        }

        public static Tuple<string, int> SetTerminal(int top)
        {
            return Tuple.Create("\n", top);
        }

        public static string GetRouteResult(string name)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
            process.Start();
            process.StandardInput.AutoFlush = true;
            process.StandardInput.WriteLine("@echo off");
            process.StandardInput.WriteLine($"where {name}");
            process.StandardInput.WriteLine("exit");
            StreamReader reader = process.StandardOutput;
            string line = reader.ReadLine();
            string res = string.Empty;
            while (line != null)
            {
                if (line.StartsWith("C:\\") && !line.EndsWith("@echo off"))
                {
                    res = line;
                    break;
                }
                line = reader.ReadLine();
            }
            process.WaitForExit();
            reader.Close();
            process.Close();
            return res;
        }
    }
}
