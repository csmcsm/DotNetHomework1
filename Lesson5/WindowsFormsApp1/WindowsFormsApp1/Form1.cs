using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string rawHttp = "https://www.cnblogs.com/";
        public string ass;
        public Form1()
        {
            InitializeComponent();
        }
        public string sendHttpPost(string url, string paraJsonStr)
        {
            return download(url);
          
        }
        public string download(string url) {
            
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString(url);
            return html;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ass = "";
            System.Net.ServicePointManager.DefaultConnectionLimit = 5000;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        }

        private void start_Click(object sender, EventArgs e)
        { 
            showBox.Text = showBox.Text+sendHttpPost(rawHttp, "")
                +"\n\n\n\n\n\n\n______________________________________" +
                "____________________________________________________________________________";
            getNextPost(sendHttpPost("https://www.cnblogs.com/", ""));
        }

        public void getNextPost(string content) {
            string[] splitContent = Regex.Split(content, "href=\"", RegexOptions.IgnoreCase);
            List<string> processedNextWeb = new List<string>();
            for (int i = 1; i < splitContent.Length; i++) {
                string info= processWeb( splitContent[i].Split('\"')[0]);
                if (info == "") continue;
                if (processWeb2(info))
                {
                    processedNextWeb.Add(info);
                }
            }
            foreach (string s in processedNextWeb) {
                showBox.Text = "1" +showBox.Text + "1";
                getInfo(s);
            }
                    
        }
        public string processWeb(string webInfo) {
            string[] splitContent = Regex.Split(webInfo, "/" + "/", RegexOptions.IgnoreCase);
            if (splitContent.Length >1)
            {
                return webInfo;
            }
            else {
                splitContent = Regex.Split(webInfo, "/", RegexOptions.IgnoreCase);
                if (splitContent.Length>1)
                {
                    string returnStr=rawHttp;
                    for(int i = 1; i < splitContent.Length; i++)
                    {
                        if (i < splitContent.Length - 1)
                        {
                            returnStr += splitContent[i] + "/";
                        }
                        else {
                            returnStr += splitContent[i];
                        }
                    }
                    return returnStr;
                }
            }
            return "";
        }
        public bool processWeb2(string webInfo) {
            string[] splitContents = webInfo.Split('/');
            string splitContent = splitContents[splitContents.Length - 1];
            splitContents = splitContent.Split('#');
            splitContent = splitContents[0];

            if (splitContent == ""||
                Regex.IsMatch(splitContent, ".htm") || Regex.IsMatch(splitContent, ".html")
                  || Regex.IsMatch(splitContent, ".jsp") || Regex.IsMatch(splitContent, ".aspx")
                   || Regex.IsMatch(splitContent, ".php")) {
                return true;
            }
        
            return false;

        }
        void addText(string s) {
            ass += s;
            Console.WriteLine(s);
        }
        async void getInfo(string webInfo) {
            Task<string> task = Task.Run<string>(() => this.sendHttpPost(webInfo, ""));
            string returnValue = await task;
            Action<string> action = this.addText;
            Console.WriteLine(returnValue);
            showBox.BeginInvoke(action, returnValue);
        }

    }
}
