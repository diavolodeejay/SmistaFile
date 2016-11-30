using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smista_File
{
    public partial class Form1 : Form
    {
        string source, destination;
        bool repeatBool,sistemamese;
        int repeatTime = 1;
        int tiposmistamento;
        bool[] dimensioni = new bool[7];
        bool[] tipi = new bool[7];
        bool shortname = false;
        string[] documentiArray = new string[] { ".doc", ".docx", ".log", ".msg	", ".odt", ".pages", ".rtf", ".tex", ".txt", ".wpd", ".wps",".xlr",".xls","xlsx",".pdf",".log" };
        string[] immaginiArray = new string[] { ".ico", ".3dm", ".3ds", ".max", ".bmp", ".jpeg", ".dds", ".gif", ".jpg", ".png", ".psd", ".pspimage", ".tga", ".thm", ".tif", ".tiff", ".yuv", ".raw", ".tiff", ".tif", ".tga", "targa" };
        string[] musicaArray = new string[] { ".aif", ".iff", ".m3u", ".m4a", ".mid", ".mp3", ".mpa", ".wav", ".wma", ".flac", ".aac" };
        string[] videoArray = new string[] { ".3g2", ".3gp", ".asf", ".avi", ".flv", ".m4v", ".mov", ".mp4", ".mpg", ".rm", ".srt", ".swf", ".vob", ".wmv", ".mkv", ".mpeg", ".mpe" };
        string[] archiviArray = new string[] { ".7z", ".cbr", ".deb", ".gz", ".pkg", ".rar", ".rpm", ".sitx", ".tar.gz", ".zip", ".zipx", ".rev", ".cab", ".gzip", ".bz2" };
        string[] exeArray = new string[] { ".apk", "app", ".bat", ".cgi", ".com", ".exe", ".gadget", ".jar", ".wsf", ".dll", ".ipa", ".class", ".msi", ".mup", ".msp" };

        public Form1()
        {
            InitializeComponent();
            this.Font = new Font("Segoe UI", 9.2f);
            SmistamentoDataWorker.ProgressChanged += SmistamentoDataWorker_ProgressChanged;
        }

        private void SmistamentoDataWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Progress.Invoke(new MethodInvoker(delegate { Progress.Value = e.ProgressPercentage; }));
            if(e.ProgressPercentage == 0)
            {
                Console.WriteLine(DateTime.Now.ToString());
            }
            else if(e.ProgressPercentage == 100)
            {
                Console.WriteLine(DateTime.Now.ToString());
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ciaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           /* var Popup = new Popup();
            DialogResult ris = Popup.ShowDialog(this);
            if (ris == DialogResult.OK)
            {
                TabPage agg = new TabPage(NomeNuovoSmist);
                tabControl1.TabPages.Add(agg);
                tabControl1.SelectedIndex = tabControl1.TabCount - 1;
                CreaUI();
            }
            NomeNuovoSmist = "";*/
        }

        private void aiutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var PopupInfo = new Info();
            PopupInfo.ShowDialog(this);
        }

        private void SfogliaSource_Click(object sender, EventArgs e)
        {
            bool posso = true;
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult r = folderBrowserDialog1.ShowDialog();
            string file = "";
            if (r == DialogResult.OK)
            {
                file = folderBrowserDialog1.SelectedPath;
                try
                {
                    System.Security.AccessControl.DirectorySecurity check = Directory.GetAccessControl(file);
                }
                catch
                {
                    posso = false;
                    DialogResult permessi = MessageBox.Show("Non hai i permessi necessari per utilizzare SmistaFile in questa cartella, vuoi provare ad avviare SmistaFile come amministratore?", "Permessi insufficenti!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (permessi == DialogResult.Yes)
                    {
                        ProcessStartInfo rest = new ProcessStartInfo();
                        rest.WorkingDirectory = Environment.CurrentDirectory;
                        rest.FileName = Application.ExecutablePath;
                        rest.Verb = "runas";
                        try
                        {
                            Process.Start(rest);
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Impossibile avviare SmistaFile come amministratore. Assicurati di avere i permessi necessari.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    file = "";
                }
                if (posso == true)
                {
                    SourceText.Text = file;
                    ComboMetodo.Enabled = true;
                    Repeat.Enabled = true;
                    SmistaAsk.ForeColor = Color.Black;
                    Repeat.ForeColor = Color.Black;
                    Everylabel.ForeColor = Color.Black;
                    Everylabel2.ForeColor = Color.Black;
                    destlabel.ForeColor = Color.Black;
                    source = file;
                }
            }
        }

        private void sfogliadest_Click(object sender, EventArgs e)
        {
            bool posso = true;
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult r = folderBrowserDialog1.ShowDialog();
            string file = "";
            if (r == DialogResult.OK)
            {
                file = folderBrowserDialog1.SelectedPath;
                try
                {
                    System.Security.AccessControl.DirectorySecurity check = Directory.GetAccessControl(file);
                }
                catch
                {
                    posso = false;
                    DialogResult permessi = MessageBox.Show("Non hai i permessi necessari per utilizzare SmistaFile in questa cartella, vuoi provare ad avviare SmistaFile come amministratore?", "Permessi insufficenti!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (permessi == DialogResult.Yes)
                    {
                        ProcessStartInfo rest = new ProcessStartInfo();
                        rest.WorkingDirectory = Environment.CurrentDirectory;
                        rest.FileName = Application.ExecutablePath;
                        rest.Verb = "runas";
                        try
                        {
                            Process.Start(rest);
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Impossibile avviare SmistaFile come amministratore. Assicurati di avere i permessi necessari.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    file = "";
                }
                if (posso == true)
                {
                    DestText.Text = file;
                    destination = file;
                    AvviaButton.Enabled = true;
                }
            }
        }

        private void ComboMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sfogliadest.Enabled = true;
            NascondiTutto();
            if (ComboMetodo.SelectedIndex == 0)
            {
                tiposmistamento = 0;
                AltroBox.Visible = true;
                ArchiviBox.Visible = true;
                DocumentiBox.Visible = true;
                exeBox.Visible = true;
                ImageBox.Visible = true;
                MusicaBox.Visible = true;
                VideoBox.Visible = true;

            }
            else if (ComboMetodo.SelectedIndex == 1)
            {
                tiposmistamento = 1;
                smallcheck.Visible = true;
                smallMedcheck.Visible = true;
                medbigcheck.Visible = true;
                mediumcheck.Visible = true;
                bigcgeck.Visible = true;
                hugecheck.Visible = true;
                megacheck.Visible = true;
                shortFoldersCheck.Visible = true;
            }
            else if (ComboMetodo.SelectedIndex == 2)
            {
                tiposmistamento = 2;
                tempoannoradio.Visible = true;
                tempomeseradio.Visible = true;
            }
        }

        private void NascondiTutto()
        {
           // sfogliadest.Enabled = false;
            AltroBox.Visible = false;
            ArchiviBox.Visible = false;
            DocumentiBox.Visible = false;
            exeBox.Visible = false;
            ImageBox.Visible = false;
            MusicaBox.Visible = false;
            VideoBox.Visible = false;
            tempoannoradio.Visible = false;
            tempomeseradio.Visible = false;
            tempotooltip.Visible = false;
            smallcheck.Visible = false;
            smallMedcheck.Visible = false;
            medbigcheck.Visible = false;
            mediumcheck.Visible = false;
            bigcgeck.Visible = false;
            hugecheck.Visible = false;
            megacheck.Visible = false;
            tempoannoradio.Checked = false;
            tempomeseradio.Checked = false;
            smallcheck.Checked = false;
            smallMedcheck.Checked = false;
            mediumcheck.Checked = false;
            medbigcheck.Checked = false;
            bigcgeck.Checked = false;
            hugecheck.Checked = false;
            megacheck.Checked = false;
            DocumentiBox.Checked = false;
            exeBox.Checked = false;
            ImageBox.Checked = false;
            MusicaBox.Checked = false;
            VideoBox.Checked = false;
            ArchiviBox.Checked = false;
            AltroBox.Checked = false;
            shortFoldersCheck.Checked = false;
            shortFoldersCheck.Visible = false;
            sfogliadest.Enabled = false;
        }

        private void AvviaButton_Click(object sender, EventArgs e)
        {
            if (repeatBool == true)
            {
                StopButton.Enabled = true;
                AvviaButton.Enabled = false;
                Repeat.Enabled = false;
                SfogliaSource.Enabled = false;
                sfogliadest.Enabled = false;
                ComboMetodo.Enabled = false;
                RepeatValue.Enabled = false;
            }
            try
            {
                SmistamentoDataWorker.RunWorkerAsync();
            }
            catch
            {
                MessageBox.Show("C'è stato un errore","",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Repeat_CheckedChanged(object sender, EventArgs e)
        {
            if(Repeat.Checked == true)
            {
                RepeatValue.Enabled = true;
            }
            else
            {
                RepeatValue.Enabled = false;
            }
            repeatBool = Repeat.Checked;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            SmistaAsk.Enabled = true;
            ComboMetodo.Enabled = true;
            sfogliadest.Enabled = true;
            AvviaButton.Enabled = true;
            StopButton.Enabled = false;
            Repeat.Enabled = true;
            RepeatValue.Enabled = true;
            try
            {
                SmistamentoDataWorker.CancelAsync();
            }
            catch
            {
                MessageBox.Show("HA");
            }
        }

        private void tempoannoradio_CheckedChanged(object sender, EventArgs e)
        {
            sfogliadest.Enabled = true;
            sistemamese = false;
        }

        private void tempomeseradio_CheckedChanged(object sender, EventArgs e)
        {
            sfogliadest.Enabled = true;
            sistemamese = true;
        }

        private void smallcheck_CheckedChanged(object sender, EventArgs e)
        {
            sfogliadest.Enabled = true;
            dimensioni[0] = smallcheck.Checked;
        }

        private void smallMedcheck_CheckedChanged(object sender, EventArgs e)
        {
            sfogliadest.Enabled = true;
            dimensioni[1] = smallMedcheck.Checked;
        }

        private void mediumcheck_CheckedChanged(object sender, EventArgs e)
        {
            sfogliadest.Enabled = true;
            dimensioni[2] = medbigcheck.Checked;
        }

        private void medbigcheck_CheckedChanged(object sender, EventArgs e)
        {
            sfogliadest.Enabled = true;
            dimensioni[3] = medbigcheck.Checked;
        }

        private void bigcgeck_CheckedChanged(object sender, EventArgs e)
        {
            sfogliadest.Enabled = true;
            dimensioni[4] = bigcgeck.Checked;
        }

        private void hugecheck_CheckedChanged(object sender, EventArgs e)
        {
            sfogliadest.Enabled = true;
            dimensioni[5] = hugecheck.Checked;
        }

        private void megacheck_CheckedChanged(object sender, EventArgs e)
        {
            sfogliadest.Enabled = true;
            dimensioni[6] = megacheck.Checked;
        }

        private void DocumentiBox_CheckedChanged(object sender, EventArgs e)
        {
            sfogliadest.Enabled = true;
            tipi[0] = DocumentiBox.Checked;
        }

        private void ImageBox_CheckedChanged(object sender, EventArgs e)
        {
            sfogliadest.Enabled = true;
            tipi[1] = ImageBox.Checked;
        }

        private void VideoBox_CheckedChanged(object sender, EventArgs e)
        {
            sfogliadest.Enabled = true;
            tipi[2] = VideoBox.Checked;
        }

        private void MusicaBox_CheckedChanged(object sender, EventArgs e)
        {
            sfogliadest.Enabled = true;
            tipi[3] = MusicaBox.Checked;
        }

        private void exeBox_CheckedChanged(object sender, EventArgs e)
        {
            sfogliadest.Enabled = true;
            tipi[4] = exeBox.Checked;
        }

        private void ArchiviBox_CheckedChanged(object sender, EventArgs e)
        {
            sfogliadest.Enabled = true;
            tipi[5] = ArchiviBox.Checked;
        }

        private void AltroBox_CheckedChanged(object sender, EventArgs e)
        {
            sfogliadest.Enabled = true;
            tipi[6] = AltroBox.Checked;
        }

        private void shortFoldersCheck_CheckedChanged(object sender, EventArgs e)
        {
            shortname = shortFoldersCheck.Checked;
        }

        private void RepeatValue_ValueChanged(object sender, EventArgs e)
        {
            if(RepeatValue.Value > 1)
            {
                Everylabel2.Text = "minuti.";
                if(RepeatValue.Value > 120)
                {
                    RepeatValue.Value = 120;
                }
            }
            else
            {
                Everylabel2.Text = "minuto.";
                if(RepeatValue.Value < 1)
                {
                    RepeatValue.Value = 0;
                }
            }
            repeatTime = (int)RepeatValue.Value * 60 * 1000;
        }

        private void SmistamentoDataWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            bool loop = true;
            while (loop)
            {
                BackgroundWorker lavoratore = sender as BackgroundWorker;
                if (lavoratore.CancellationPending == true)
                {
                    e.Cancel = true;
                }
                else
                {
                    string dirtemp = destination;
                    List<string> listafiles = new List<string>(Directory.EnumerateFiles(source));
                    //tipo
                    int l = listafiles.Count;
                    int count = 0;
                    if (tiposmistamento == 0)
                    {
                        foreach (string fi in listafiles)
                        {
                            dirtemp = destination;
                            string nome = Path.GetFileName(fi);
                            string ext = Path.GetExtension(fi);
                            if (documentiArray.Any(ext.Contains) && tipi[0])
                            {
                                dirtemp = dirtemp + "\\Documenti";
                                Functions.ControllaCartella(dirtemp);
                                File.Move(fi, dirtemp + "\\" + nome);
                            }
                            else if (immaginiArray.Any(ext.Contains) && tipi[1])
                            {
                                dirtemp = dirtemp + "\\Immagini";
                                Functions.ControllaCartella(dirtemp);
                                File.Move(fi, dirtemp + "\\" + nome);
                            }
                            else if (videoArray.Any(ext.Contains) && tipi[2])
                            {
                                dirtemp = dirtemp + "\\Video";
                                Functions.ControllaCartella(dirtemp);
                                File.Move(fi, dirtemp + "\\" + nome);
                            }
                            else if (musicaArray.Any(ext.Contains) && tipi[3])
                            {
                                dirtemp = dirtemp + "\\Musica";
                                Functions.ControllaCartella(dirtemp);
                                File.Move(fi, dirtemp + "\\" + nome);
                            }
                            else if (exeArray.Any(ext.Contains) && tipi[4])
                            {
                                dirtemp = dirtemp + "\\Programmi";
                                Functions.ControllaCartella(dirtemp);
                                File.Move(fi, dirtemp + "\\" + nome);
                            }
                            else if (archiviArray.Any(ext.Contains) && tipi[5])
                            {
                                dirtemp = dirtemp + "\\Archivi";
                                Functions.ControllaCartella(dirtemp);
                                File.Move(fi, dirtemp + "\\" + nome);
                            }
                            else if (tipi[6])
                            {
                                dirtemp = dirtemp + "\\Altro";
                                Functions.ControllaCartella(dirtemp);
                                File.Move(fi, dirtemp + "\\" + nome);
                            }
                            count++;
                            SmistamentoDataWorker.ReportProgress((count * 100) / l);
                        }
                    }
                    //dimensione
                    else if (tiposmistamento == 1)
                    {
                        foreach (string fi in listafiles)
                        {
                            dirtemp = destination;
                            string nome = Path.GetFileName(fi);
                            FileInfo file = new FileInfo(fi);
                            long size = file.Length;
                            if (size <= 51200 && dimensioni[0])
                            {
                                if (shortname)
                                {
                                    dirtemp = dirtemp + "\\0 - 50Kb";
                                }
                                else
                                {
                                    dirtemp = dirtemp + "\\Files under or 50Kb";
                                }
                                Functions.ControllaCartella(dirtemp);
                                File.Move(fi, dirtemp + "\\" + nome);
                            }
                            else if (size > 51200 && size <= 512000 && dimensioni[1])
                            {
                                if (shortname)
                                {
                                    dirtemp = dirtemp + "\\51Kb - 500Kb";
                                }
                                else
                                {
                                    dirtemp = dirtemp + "\\Files over 50Kb and under or 500Kb";
                                }
                                Functions.ControllaCartella(dirtemp);
                                File.Move(fi, dirtemp + "\\" + nome);
                            }
                            else if (size > 512000 && size <= 1048576 && dimensioni[2])
                            {
                                if (shortname)
                                {
                                    dirtemp = dirtemp + "\\501Kb - 1Mb";
                                }
                                else
                                {
                                    dirtemp = dirtemp + "\\Files over 500Kb and under or 1Mb";
                                }
                                Functions.ControllaCartella(dirtemp);
                                File.Move(fi, dirtemp + "\\" + nome);
                            }
                            else if (size > 1048576 && size <= 10485760 && dimensioni[3])
                            {
                                if (shortname)
                                {
                                    dirtemp = dirtemp + "\\1Mb - 10Mb";
                                }
                                else
                                {
                                    dirtemp = dirtemp + "\\Files over 1 Mb and under or 10Mb";
                                }
                                Functions.ControllaCartella(dirtemp);
                                File.Move(fi, dirtemp + "\\" + nome);
                            }
                            else if (size > 10485760 && size <= 104857600 && dimensioni[4])
                            {
                                if (shortname)
                                {
                                    dirtemp = dirtemp + "\\10.01Mb - 100Mb";
                                }
                                else
                                {
                                    dirtemp = dirtemp + "\\Files over 10 Mb and under or 100Mb";
                                }
                                Functions.ControllaCartella(dirtemp);
                                File.Move(fi, dirtemp + "\\" + nome);
                            }
                            else if (size > 104857600 && size <= 2147483648 && dimensioni[5])
                            {
                                if (shortname)
                                {
                                    dirtemp = dirtemp + "\\100.01Mb - 2Gb";
                                }
                                else
                                {
                                    dirtemp = dirtemp + "\\Files over 100Mb and under or 2Gb";
                                }
                                Functions.ControllaCartella(dirtemp);
                                File.Move(fi, dirtemp + "\\" + nome);
                            }
                            else if (size > 2147483648 && dimensioni[6])
                            {
                                if (shortname)
                                {
                                    dirtemp = dirtemp + "\\2Gb+";
                                }
                                else
                                {
                                    dirtemp = dirtemp + "\\Files over 2Gb";
                                }
                                Functions.ControllaCartella(dirtemp);
                                File.Move(fi, dirtemp + "\\" + nome);
                            }
                            count++;
                            SmistamentoDataWorker.ReportProgress((count * 100) / l);
                        }
                    }
                    //data
                    else if (tiposmistamento == 2)
                    {
                        if (sistemamese == true)
                        {
                            foreach (string fi in listafiles)
                            {
                                dirtemp = destination;
                                string nome = Path.GetFileName(fi);
                                DateTime edit = File.GetLastWriteTime(fi);
                                int a = edit.Year;
                                int m = edit.Month;
                                dirtemp = dirtemp + "\\" + a.ToString() + "\\" + m.ToString();
                                Functions.ControllaCartella(dirtemp);
                                File.Move(fi, dirtemp + "\\" + nome);
                                count++;
                                SmistamentoDataWorker.ReportProgress((count * 100) / l);
                            }
                        }
                        else
                        {
                            foreach (string fi in listafiles)
                            {
                                dirtemp = destination;
                                string nome = Path.GetFileName(fi);
                                DateTime edit = File.GetLastWriteTime(fi);
                                int a = edit.Year;
                                dirtemp = dirtemp + "\\" + a.ToString();
                                Functions.ControllaCartella(dirtemp);
                                File.Move(fi, dirtemp + "\\" + nome);
                                count++;
                                SmistamentoDataWorker.ReportProgress((count * 100) / l);
                            }
                        }
                    }
                }
                if (repeatBool)
                {
                    loop = true;
                    Thread.Sleep(repeatTime);
                }
                else
                {
                    loop = false;
                }
            }
        }

    }
}
