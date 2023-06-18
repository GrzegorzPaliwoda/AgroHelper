﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroApp.Forms
{
    public partial class FormShowField : Form
    {
        int farmId;
        int fieldId;
        public FormShowField()
        {
            InitializeComponent();
            InitBrowser();
        }
        private async Task initiated() 
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser() 
        {
            await initiated();
            webView21.CoreWebView2.Navigate(new Uri("C:\\projekty\\AgroApp\\main\\showField.html").ToString());
        }
        public async void sendCords() 
        {
            string exampleCords = "[[52.62449, 18.614724],[52.62449, 18.614724],[52.625007, 18.614901],[52.625007, 18.614901],[52.625935, 18.606548],[52.625935, 18.606548],[52.625362, 18.606752],[52.625362, 18.606752]]";
            await webView21.CoreWebView2.ExecuteScriptAsync($"receiveCords({exampleCords});");
            
        }

        private void webView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            sendCords();
        }
    }
}