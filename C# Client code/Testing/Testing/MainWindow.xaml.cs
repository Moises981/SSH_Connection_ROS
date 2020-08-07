using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Renci.SshNet;

namespace Testing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Get_Files(object sender, RoutedEventArgs e)
        {
            try
            {
                string IP_HOST; 
                IP_HOST = System.Net.Dns.GetHostName();

                SshClient sshClient = new SshClient(IP_SERVER.Text, 22, Username.Text, Password.Text);

                sshClient.ConnectionInfo.Timeout = TimeSpan.FromSeconds(120);
                sshClient.Connect();

                ShellStream shellStreamSSH = sshClient.CreateShellStream("Test", 80, 60, 800, 600, 65536);

                Thread thread = new Thread(() => recvSSHData(shellStreamSSH));

                thread.Start();

                string Location = "\'//" + IP_Client.Text + "/" + Shared_folder.Text+"\'";
                Console.WriteLine(Location);
                string command = "rostopic pub -1 /Clients_IP std_msgs/String \"data: " + Location + "\"; rostopic pub -1 /Status std_msgs/Int8 \"data: 5\"" ;

                shellStreamSSH.Write(command + "\n");
                shellStreamSSH.Flush();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }

        public static void recvSSHData(ShellStream shellStreamSSH)
        {
            while (true)
            {
                try
                {
                    if (shellStreamSSH != null && shellStreamSSH.DataAvailable)
                    {
                        string strData = shellStreamSSH.Read();

                        Console.WriteLine(strData);
                    }
                }
                catch
                {

                }

                System.Threading.Thread.Sleep(200);
            }
        }


    }
}


