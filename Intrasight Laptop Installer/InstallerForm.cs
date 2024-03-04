using System.Diagnostics;

namespace Intrasight_Laptop_Installer
{
    public partial class download_form : Form
    {

        private bool downloadCompleted=false;
        private string buildVersion;
        public download_form()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            buildVersion = textBox1.Text;
            btn_install.Enabled = true;
        }

        private void download_form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_install_Click(object sender, EventArgs e)
        {
            //Stopping and deleting PSC services
            updateLabel("Stopping and deleting PSC services");
            runCommand("net stop pscservicehost");
            runCommand("sc delete pscservicehost");
        


            //Stopping and deleting Audit Trail services
            updateLabel("Stopping and deleting Audit Trail services");
             runCommand("net stop IPF-AuditTrailService");
             runCommand("sc delete IPF-AuditTrailService");
            
        }

        private void runCommand(string command)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Verb = "runas", // This will run the command prompt as administrator
                UseShellExecute = false, // Required for RedirectStandardOutput
                RedirectStandardOutput = true, // Redirect standard output
                RedirectStandardInput = true // Redirect standard input to write command
            };

            // Start the process
            try
            {
                Process process = Process.Start(psi);

                // Write command to the standard input
                process.StandardInput.WriteLine(command);

                // Close the input stream to signal that we are done writing commands
                process.StandardInput.Close();

                // Read the output of the command
                string output = process.StandardOutput.ReadToEnd();

                // Wait for the process to exit
                process.WaitForExit();

                // Display the output
                Console.WriteLine("Output:");
                Console.WriteLine(output);

                // Close the process
                process.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to start cmd.exe as administrator: " + ex.Message);
            }
        }

        private void updateLabel(string executedStep)
        {
            label2.Text = executedStep;
        }
    }
}