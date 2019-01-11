using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace LeetTranslatorFun
{
  public partial class LeetForm : Form
  {
    public LeetForm()
    {
      InitializeComponent();
    }

    private void textBox_PlainText_ModifiedChanged(object sender, EventArgs e)
    {
      ConvertToLeet();
      //this.textBox_LeetText.Text = textBox_PlainText.Text;
      this.textBox_PlainText.Modified = false;
    }

    private void textBox_PlainText_TextChanged(object sender, EventArgs e)
    {
      ConvertToLeet();
      //this.textBox_LeetText.Text = textBox_PlainText.Text;
    }

    object l = new object();

    private void button_CopyFromClipboard_Click(object sender, EventArgs e)
    {
//try
//{
//  Console.WriteLine("enter try catch");
        
//  try
//  {
//    Console.WriteLine("enter try finally");
//    throw new Exception("try-finally exception");
//    Console.WriteLine("exit try finally");
//  }
//  finally
//  {
//    Console.WriteLine("finally called");
//  }

//  Console.WriteLine("exit try catch");
//}
//catch (Exception ex)
//{
//  Console.WriteLine("exception: " + ex.Message);
//}


      //if (NetworkInterface.GetIsNetworkAvailable())
      //{
      //  NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
      //  foreach (NetworkInterface iface in interfaces)
      //  {
      //    if (iface.OperationalStatus == OperationalStatus.Up && iface.NetworkInterfaceType != NetworkInterfaceType.Loopback)
      //    {
      //      IPv4InterfaceStatistics stats = iface.GetIPv4Statistics();
      //      long bytesReceived = stats.BytesReceived;
      //      long bytesSent = stats.BytesSent;

      //      Console.WriteLine("Network: " + iface.Description + " (" + iface.Name + "), has sent: " + bytesSent + " bytes and received: " + bytesReceived + " bytes");
      //    }
      //  }
      //}

      //string search = "and hello and my love and";
      //search = System.Text.RegularExpressions.Regex.Replace(search, @"^and\s+", string.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.Singleline);
      //search = System.Text.RegularExpressions.Regex.Replace(search, @"\s+and$", string.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.Singleline);

      //bool valid = System.Text.RegularExpressions.Regex.IsMatch("1,21", @"^\d+([,]\d+)*$");
      //valid = System.Text.RegularExpressions.Regex.IsMatch("1,hello,31,32", @"^\d+([,]\d+)*$");


      //System.Text.RegularExpressions.MatchCollection ms = System.Text.RegularExpressions.Regex.Matches("Dam It12 is not45 that g00d", @"\b(?=[-/\\\\A-Za-z]*[0-9])(?=[-/\\\\0-9]*[A-Za-z])[A-Za-z0-9]+(?:[-/\\\\][A-Za-z0-9]+)*\b");

      //foreach (System.Text.RegularExpressions.Match m in ms)
      //{
      //  Console.WriteLine(m.ToString());
      //}


      //System.Text.RegularExpressions.Regex CommaRegex = new System.Text.RegularExpressions.Regex(@",(?!(?<=(?:^|,)\s*\x22(?:[^\x22]|\x22\x22|\\\x22)*,)(?:[^\x22]|\x22\x22|\\\x22)*\x22\s*(?:,|$))", System.Text.RegularExpressions.RegexOptions.Compiled | System.Text.RegularExpressions.RegexOptions.Singleline);

      //string input = "\"CRUDE OIL, LIGHT SWEET - ICE FUTURES EUROPE\" ,110517 ,2011-05-17,067411, \"(CONTRACTS OF 1,000 BARRELS)\"";
      //string[] strings = System.Text.RegularExpressions.Regex.Split(input, @",(?!(?<=(?:^|,)\s*\x22(?:[^\x22]|\x22\x22|\\\x22)*,)(?:[^\x22]|\x22\x22|\\\x22)*\x22\s*(?:,|$))");

      //try
      //{
      //try
      //{
      //  throw new Exception("Inner try finally");
      //}
      //finally
      //{
      //  System.Diagnostics.Debugger.Break();
      //}

      //}
      //catch (Exception ex)
      //{
      //  System.Diagnostics.Debugger.Break();
      //}

      // For each screen, add the screen properties to a list box.
      //foreach (Screen screen in Screen.AllScreens)
      //{
      //  Console.WriteLine("Device Name: " + screen.DeviceName);
      //  Console.WriteLine("Bounds: " +
      //      screen.Bounds.ToString());
      //  Console.WriteLine("Type: " +
      //      screen.GetType().ToString());
      //  Console.WriteLine("Working Area: " +
      //      screen.WorkingArea.ToString());
      //  Console.WriteLine("Primary Screen: " +
      //      screen.Primary.ToString());
      //}


      if (Clipboard.ContainsText())
      {
        this.textBox_PlainText.Text = Clipboard.GetText();
      }
    }

    private void button_CopyToClipboard_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrWhiteSpace(this.textBox_LeetText.Text))
        Clipboard.SetText(this.textBox_LeetText.Text);
    }

    private void trackBar_LeetDegree_Scroll(object sender, EventArgs e)
    {
      this.label_LeetDegree.Text = string.Format("Leet degree: {0}", this.trackBar_LeetDegree.Value);
      ConvertToLeet();
    }

    private void checkBox_LeetAlternateCharset_CheckedChanged(object sender, EventArgs e)
    {
      ConvertToLeet();
    }

    private void ConvertToLeet()
    {
      this.textBox_LeetText.Text = Translator.Leet.Translate(this.textBox_PlainText.Text, this.trackBar_LeetDegree.Value);
    }
  }
}
